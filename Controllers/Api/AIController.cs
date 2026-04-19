using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace MACHINEBISS_Web.Controllers.Api;

/// <summary>
/// Pinebi AI yardimci. Desteklenen saglayicilar: Gemini (ucretsiz), Groq (ucretsiz), Anthropic.
/// </summary>
[ApiController]
[Route("api/mail-yardim")]
public class AIController : ControllerBase
{
    private readonly IConfiguration _config;
    private readonly IHttpClientFactory _httpFactory;
    public AIController(IConfiguration config, IHttpClientFactory httpFactory)
    {
        _config = config; _httpFactory = httpFactory;
    }

    public class MailDuzeltDto
    {
        public string Metin { get; set; } = "";
        public string? Konu { get; set; }
        public string Aksiyon { get; set; } = "duzelt"; // duzelt | profesyonel | ozetle | genislet | yanit
        public string? BaglamYanit { get; set; }
    }

    [HttpPost("metin-iyilestir")]
    public async Task<IActionResult> MailDuzelt([FromBody] MailDuzeltDto dto)
    {
        var sistem = @"Sen bir Turkce mail yardimcisisin. Pinebi ERP sistemi icinde calisiyorsun.
Kurallar:
- Sadece duzeltilmis / iyilestirilmis mail govdesini dondur, aciklama veya baslik ekleme.
- HTML kullanma; duz metin dondur (paragraflar bos satirla ayrilsin).
- Kullanici niyetini koru, asla yeni bilgi uydurma.
- Asiri nezaket ekleme; mevcut tonu koru.";

        string talimat = dto.Aksiyon switch
        {
            "profesyonel" => "Asagidaki mail metnini profesyonel ve resmi bir is tonuna cevir. Anlam degismesin.",
            "ozetle"      => "Asagidaki mail metnini 3-5 cumleye ozetle. Onemli bilgileri kaybetme.",
            "genislet"    => "Asagidaki kisa mail taslagini, konuya uygun sekilde daha dolgun bir profesyonel maile donustur. Uyduruk detay ekleme.",
            "yanit"       => $"Asagidaki gelen maile uygun, kisa ve profesyonel bir yanit tasla. Gelen mail:\n---\n{dto.BaglamYanit}\n---\nKullanici yanit taslagi (bunu iyilestir, bostaysa sifirdan yaz):",
            _             => "Asagidaki mail metninin yazim, gramer ve akiciligini duzelt. Anlam ve ton degismesin."
        };

        var prompt = $"{talimat}\n\nMetin:\n{dto.Metin}";
        var provider = (_config["AI:Provider"] ?? "offline").ToLowerInvariant();

        // Hicbir key yoksa otomatik offline moda dus
        if (string.IsNullOrWhiteSpace(_config["AI:Gemini:ApiKey"])
            && string.IsNullOrWhiteSpace(_config["AI:Groq:ApiKey"])
            && string.IsNullOrWhiteSpace(_config["AI:Anthropic:ApiKey"]))
            provider = "offline";

        try
        {
            string metin = provider switch
            {
                "gemini"    => await CallGemini(sistem, prompt),
                "groq"      => await CallGroq(sistem, prompt),
                "anthropic" => await CallAnthropic(sistem, prompt),
                _           => OfflineDuzelt(dto.Metin, dto.Aksiyon)
            };
            return Ok(new { metin = metin.Trim(), saglayici = provider });
        }
        catch (InvalidOperationException iex) when (iex.Message.StartsWith("AI_KEY_YOK"))
        {
            // Key problemiyse offline fallback
            return Ok(new { metin = OfflineDuzelt(dto.Metin, dto.Aksiyon), saglayici = "offline", not = "API key yok, yerel duzeltici kullanildi" });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = ex.Message });
        }
    }

    // ===== OFFLINE YEREL DUZELTICI =====
    private static string OfflineDuzelt(string metin, string aksiyon)
    {
        if (string.IsNullOrWhiteSpace(metin)) metin = "";
        var s = metin.Trim();

        // Cok satirli normallestirme
        s = System.Text.RegularExpressions.Regex.Replace(s, @"[ \t]+", " ");
        s = System.Text.RegularExpressions.Regex.Replace(s, @"\n{3,}", "\n\n");
        s = System.Text.RegularExpressions.Regex.Replace(s, @" +\n", "\n");
        s = System.Text.RegularExpressions.Regex.Replace(s, @"\n +", "\n");

        // Sik yapilan Turkce yazim hatalari
        var replacements = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "merhabalar", "Merhaba" },
            { "slm", "Merhaba" },
            { "tsk ederim", "Tesekkur ederim" },
            { "tskler", "Tesekkurler" },
            { "tsk", "Tesekkurler" },
            { " bi ", " bir " },
            { " bisey ", " bir sey " },
            { " yaptim.", " yaptim." },
            { " yaparim.", " yaparim." },
            { "iyi calismalar.", "Iyi calismalar." },
            { "saygilarimla", "Saygilarimla" },
        };
        foreach (var kv in replacements)
            s = System.Text.RegularExpressions.Regex.Replace(s, @"\b" + System.Text.RegularExpressions.Regex.Escape(kv.Key) + @"\b", kv.Value, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        // Cumle basi buyuk harf
        s = System.Text.RegularExpressions.Regex.Replace(s, @"(^|[.!?]\s+|\n)([a-zcgiosu])",
            m => m.Groups[1].Value + m.Groups[2].Value.ToUpperInvariant());

        // Noktalama arasi bosluk
        s = System.Text.RegularExpressions.Regex.Replace(s, @"\s+([.,!?;:])", "$1");
        s = System.Text.RegularExpressions.Regex.Replace(s, @"([.,!?;:])(?=[^\s\d])", "$1 ");

        switch (aksiyon)
        {
            case "profesyonel":
                if (!s.StartsWith("Sayin", StringComparison.OrdinalIgnoreCase) && !s.StartsWith("Merhaba", StringComparison.OrdinalIgnoreCase))
                    s = "Sayin Ilgili,\n\n" + s;
                if (!s.Contains("Saygilarimla", StringComparison.OrdinalIgnoreCase) && !s.Contains("Iyi calismalar", StringComparison.OrdinalIgnoreCase))
                    s = s.TrimEnd() + "\n\nSaygilarimla,";
                break;
            case "ozetle":
                // Basit: ilk 3 cumleyi tut
                var cumleler = System.Text.RegularExpressions.Regex.Split(s, @"(?<=[.!?])\s+");
                if (cumleler.Length > 3) s = string.Join(" ", cumleler.Take(3));
                break;
            case "genislet":
                if (!s.StartsWith("Merhaba", StringComparison.OrdinalIgnoreCase) && !s.StartsWith("Sayin", StringComparison.OrdinalIgnoreCase))
                    s = "Merhaba,\n\n" + s;
                if (!s.Contains("Iyi calismalar", StringComparison.OrdinalIgnoreCase) && !s.Contains("Saygilarimla", StringComparison.OrdinalIgnoreCase))
                    s = s.TrimEnd() + "\n\nBu konuda bilgi vermenizi rica ederim.\n\nIyi calismalar,";
                break;
        }

        return s.Trim();
    }

    // ===== GEMINI (ucretsiz tier: 1500 istek/gun) =====
    // Anahtar: https://aistudio.google.com/apikey
    private async Task<string> CallGemini(string sistem, string prompt)
    {
        var key = _config["AI:Gemini:ApiKey"];
        if (string.IsNullOrWhiteSpace(key))
            throw new InvalidOperationException("AI_KEY_YOK: Gemini API key yok. appsettings.json > AI:Gemini:ApiKey alanina ekleyin. Ucretsiz: aistudio.google.com/apikey");

        var model = _config["AI:Gemini:Model"] ?? "gemini-2.5-flash";
        var body = new
        {
            system_instruction = new { parts = new[] { new { text = sistem } } },
            contents = new[] { new { role = "user", parts = new[] { new { text = prompt } } } },
            generationConfig = new { temperature = 0.4, maxOutputTokens = 1024 }
        };

        using var http = _httpFactory.CreateClient();
        http.Timeout = TimeSpan.FromSeconds(60);
        var url = $"https://generativelanguage.googleapis.com/v1beta/models/{model}:generateContent?key={key}";
        using var resp = await http.PostAsync(url, new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json"));
        var text = await resp.Content.ReadAsStringAsync();
        if (!resp.IsSuccessStatusCode) throw new Exception("Gemini: " + text);

        using var doc = JsonDocument.Parse(text);
        return doc.RootElement.GetProperty("candidates")[0].GetProperty("content").GetProperty("parts")[0].GetProperty("text").GetString() ?? "";
    }

    // ===== GROQ (ucretsiz) =====
    // Anahtar: https://console.groq.com/keys
    private async Task<string> CallGroq(string sistem, string prompt)
    {
        var key = _config["AI:Groq:ApiKey"];
        if (string.IsNullOrWhiteSpace(key))
            throw new InvalidOperationException("AI_KEY_YOK: Groq API key yok. appsettings.json > AI:Groq:ApiKey alanina ekleyin. Ucretsiz: console.groq.com/keys");

        var model = _config["AI:Groq:Model"] ?? "llama-3.3-70b-versatile";
        var body = new
        {
            model,
            max_tokens = 1024,
            temperature = 0.4,
            messages = new[]
            {
                new { role = "system", content = sistem },
                new { role = "user",   content = prompt }
            }
        };

        using var http = _httpFactory.CreateClient();
        http.Timeout = TimeSpan.FromSeconds(60);
        using var req = new HttpRequestMessage(HttpMethod.Post, "https://api.groq.com/openai/v1/chat/completions");
        req.Headers.Add("Authorization", "Bearer " + key);
        req.Content = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");
        using var resp = await http.SendAsync(req);
        var text = await resp.Content.ReadAsStringAsync();
        if (!resp.IsSuccessStatusCode) throw new Exception("Groq: " + text);

        using var doc = JsonDocument.Parse(text);
        return doc.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString() ?? "";
    }

    // ===== ANTHROPIC =====
    private async Task<string> CallAnthropic(string sistem, string prompt)
    {
        var key = _config["AI:Anthropic:ApiKey"];
        if (string.IsNullOrWhiteSpace(key))
            throw new InvalidOperationException("AI_KEY_YOK: Anthropic API key yok.");

        var model = _config["AI:Anthropic:Model"] ?? "claude-sonnet-4-6";
        var body = new
        {
            model, max_tokens = 1024, system = sistem,
            messages = new[] { new { role = "user", content = prompt } }
        };

        using var http = _httpFactory.CreateClient();
        http.Timeout = TimeSpan.FromSeconds(60);
        using var req = new HttpRequestMessage(HttpMethod.Post, "https://api.anthropic.com/v1/messages");
        req.Headers.Add("x-api-key", key);
        req.Headers.Add("anthropic-version", "2023-06-01");
        req.Content = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");
        using var resp = await http.SendAsync(req);
        var text = await resp.Content.ReadAsStringAsync();
        if (!resp.IsSuccessStatusCode) throw new Exception("Anthropic: " + text);

        using var doc = JsonDocument.Parse(text);
        return doc.RootElement.GetProperty("content")[0].GetProperty("text").GetString() ?? "";
    }
}
