using System.Xml;

namespace MACHINEBISS_Web.Services;

public class DovizKuru
{
    public string DovizKodu { get; set; } = "";
    public string DovizAdi { get; set; } = "";
    public double Alis { get; set; }
    public double Satis { get; set; }
    public DateTime Tarih { get; set; }
}

public class DovizKuruService : IHostedService, IDisposable
{
    private Timer? _timer;
    private readonly ILogger<DovizKuruService> _logger;
    private readonly HttpClient _httpClient;

    public List<DovizKuru> Kurlar { get; private set; } = new();
    public DateTime SonGuncelleme { get; private set; }
    public bool Yuklendi { get; private set; }
    public string? Hata { get; private set; }

    public event Action? OnKurlarGuncellendi;

    public DovizKuruService(ILogger<DovizKuruService> logger)
    {
        _logger = logger;
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "MachineBiss-ERP/2.0");
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("DovizKuruService baslatildi. 5 saatte bir TCMB'den kur cekilecek.");

        // Hemen bir kez cek, sonra 5 saatte bir tekrarla
        _timer = new Timer(async _ => await KurlariGuncelle(), null, TimeSpan.Zero, TimeSpan.FromHours(5));

        return Task.CompletedTask;
    }

    public async Task KurlariGuncelle()
    {
        try
        {
            _logger.LogInformation("TCMB'den doviz kurlari cekiliyor...");

            var xml = await _httpClient.GetStringAsync("https://www.tcmb.gov.tr/kurlar/today.xml");

            var doc = new XmlDocument();
            doc.LoadXml(xml);

            var yeniKurlar = new List<DovizKuru>();
            var tarihStr = doc.SelectSingleNode("//Tarih_Date")?.Attributes?["Tarih"]?.Value;
            var tarih = DateTime.Today;
            if (!string.IsNullOrEmpty(tarihStr))
            {
                DateTime.TryParseExact(tarihStr, "dd.MM.yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out tarih);
            }

            // USD
            var usdNode = doc.SelectSingleNode("//Currency[@Kod='USD']");
            if (usdNode != null)
            {
                yeniKurlar.Add(new DovizKuru
                {
                    DovizKodu = "USD",
                    DovizAdi = "ABD Dolari",
                    Alis = ParseDouble(usdNode.SelectSingleNode("ForexBuying")?.InnerText),
                    Satis = ParseDouble(usdNode.SelectSingleNode("ForexSelling")?.InnerText),
                    Tarih = tarih
                });
            }

            // EUR
            var eurNode = doc.SelectSingleNode("//Currency[@Kod='EUR']");
            if (eurNode != null)
            {
                yeniKurlar.Add(new DovizKuru
                {
                    DovizKodu = "EUR",
                    DovizAdi = "Euro",
                    Alis = ParseDouble(eurNode.SelectSingleNode("ForexBuying")?.InnerText),
                    Satis = ParseDouble(eurNode.SelectSingleNode("ForexSelling")?.InnerText),
                    Tarih = tarih
                });
            }

            // GBP
            var gbpNode = doc.SelectSingleNode("//Currency[@Kod='GBP']");
            if (gbpNode != null)
            {
                yeniKurlar.Add(new DovizKuru
                {
                    DovizKodu = "GBP",
                    DovizAdi = "Ingiliz Sterlini",
                    Alis = ParseDouble(gbpNode.SelectSingleNode("ForexBuying")?.InnerText),
                    Satis = ParseDouble(gbpNode.SelectSingleNode("ForexSelling")?.InnerText),
                    Tarih = tarih
                });
            }

            Kurlar = yeniKurlar;
            SonGuncelleme = DateTime.Now;
            Yuklendi = true;
            Hata = null;

            _logger.LogInformation($"Doviz kurlari guncellendi. USD: {Kurlar.FirstOrDefault(k => k.DovizKodu == "USD")?.Satis:N4}");

            OnKurlarGuncellendi?.Invoke();
        }
        catch (Exception ex)
        {
            Hata = ex.Message;
            _logger.LogError(ex, "TCMB doviz kurlari cekilemedi.");
        }
    }

    private double ParseDouble(string? value)
    {
        if (string.IsNullOrEmpty(value)) return 0;
        // TCMB nokta kullanir (orn: 38.5234)
        if (double.TryParse(value, System.Globalization.NumberStyles.Any,
            System.Globalization.CultureInfo.InvariantCulture, out var result))
            return result;
        return 0;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _timer?.Dispose();
        _httpClient.Dispose();
    }
}
