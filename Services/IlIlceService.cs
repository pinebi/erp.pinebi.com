using Microsoft.EntityFrameworkCore;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP.Tanimlar;
using System.Text.Json;

namespace MACHINEBISS_Web.Services;

/// <summary>
/// Il/Ilce/Ulke yonetim servisi.
/// Startup'ta seed eder, isterseniz internet API'sinden guncellenebilir.
/// </summary>
public class IlIlceService
{
    private readonly IDbContextFactory<PineErpContext> _factory;
    public IlIlceService(IDbContextFactory<PineErpContext> factory) => _factory = factory;

    /// <summary>
    /// Startup'ta cagrilir. Il tablosu bossa Turkiye 81 ili ve ilcelerini seed eder.
    /// </summary>
    public async Task SeedAsync()
    {
        using var db = await _factory.CreateDbContextAsync();
        if (await db.Iller.AnyAsync()) return; // zaten dolu

        Console.WriteLine("Il/Ilce seed ediliyor...");

        // 81 il (plaka kodu sirali)
        var iller = new Dictionary<int, string>
        {
            {1,"ADANA"},{2,"ADIYAMAN"},{3,"AFYONKARAHISAR"},{4,"AGRI"},{5,"AMASYA"},
            {6,"ANKARA"},{7,"ANTALYA"},{8,"ARTVIN"},{9,"AYDIN"},{10,"BALIKESIR"},
            {11,"BILECIK"},{12,"BINGOL"},{13,"BITLIS"},{14,"BOLU"},{15,"BURDUR"},
            {16,"BURSA"},{17,"CANAKKALE"},{18,"CANKIRI"},{19,"CORUM"},{20,"DENIZLI"},
            {21,"DIYARBAKIR"},{22,"EDIRNE"},{23,"ELAZIG"},{24,"ERZINCAN"},{25,"ERZURUM"},
            {26,"ESKISEHIR"},{27,"GAZIANTEP"},{28,"GIRESUN"},{29,"GUMUSHANE"},{30,"HAKKARI"},
            {31,"HATAY"},{32,"ISPARTA"},{33,"MERSIN"},{34,"ISTANBUL"},{35,"IZMIR"},
            {36,"KARS"},{37,"KASTAMONU"},{38,"KAYSERI"},{39,"KIRKLARELI"},{40,"KIRSEHIR"},
            {41,"KOCAELI"},{42,"KONYA"},{43,"KUTAHYA"},{44,"MALATYA"},{45,"MANISA"},
            {46,"KAHRAMANMARAS"},{47,"MARDIN"},{48,"MUGLA"},{49,"MUS"},{50,"NEVSEHIR"},
            {51,"NIGDE"},{52,"ORDU"},{53,"RIZE"},{54,"SAKARYA"},{55,"SAMSUN"},
            {56,"SIIRT"},{57,"SINOP"},{58,"SIVAS"},{59,"TEKIRDAG"},{60,"TOKAT"},
            {61,"TRABZON"},{62,"TUNCELI"},{63,"SANLIURFA"},{64,"USAK"},{65,"VAN"},
            {66,"YOZGAT"},{67,"ZONGULDAK"},{68,"AKSARAY"},{69,"BAYBURT"},{70,"KARAMAN"},
            {71,"KIRIKKALE"},{72,"BATMAN"},{73,"SIRNAK"},{74,"BARTIN"},{75,"ARDAHAN"},
            {76,"IGDIR"},{77,"YALOVA"},{78,"KARABUK"},{79,"KILIS"},{80,"OSMANIYE"},
            {81,"DUZCE"}
        };

        foreach (var (plaka, isim) in iller)
        {
            db.Iller.Add(new PineIller { IlPlaka = plaka, IlAdi = isim, RecGuid = Guid.NewGuid() });
        }
        await db.SaveChangesAsync();
        Console.WriteLine($"  {iller.Count} il seed edildi.");
    }

    /// <summary>
    /// Internetten il/ilce listesi guncelle (Turkiye API).
    /// https://turkiyeapi.dev/api/v1/provinces kullanir.
    /// </summary>
    public async Task InternettenGuncelleAsync()
    {
        try
        {
            using var http = new HttpClient();
            http.Timeout = TimeSpan.FromSeconds(30);

            var json = await http.GetStringAsync("https://turkiyeapi.dev/api/v1/provinces");
            using var doc = JsonDocument.Parse(json);

            if (!doc.RootElement.TryGetProperty("data", out var data)) return;

            using var db = await _factory.CreateDbContextAsync();

            foreach (var il in data.EnumerateArray())
            {
                var ilId = il.GetProperty("id").GetInt32();
                var ilAdi = il.GetProperty("name").GetString()?.ToUpper(new System.Globalization.CultureInfo("tr-TR")) ?? "";
                if (string.IsNullOrEmpty(ilAdi)) continue;

                // Il upsert
                var existing = await db.Iller.FirstOrDefaultAsync(i => i.IlPlaka == ilId);
                if (existing != null)
                    existing.IlAdi = ilAdi;
                else
                    db.Iller.Add(new PineIller { IlPlaka = ilId, IlAdi = ilAdi, RecGuid = Guid.NewGuid() });

                // Ilceler
                if (il.TryGetProperty("districts", out var districts))
                {
                    foreach (var ilce in districts.EnumerateArray())
                    {
                        var ilceAdi = ilce.GetProperty("name").GetString()?.ToUpper(new System.Globalization.CultureInfo("tr-TR")) ?? "";
                        if (string.IsNullOrEmpty(ilceAdi)) continue;

                        var exIlce = await db.Ilceler.FirstOrDefaultAsync(i => i.IlcSehirId == ilId && i.IlcIsim == ilceAdi);
                        if (exIlce == null)
                            db.Ilceler.Add(new PineIlceler { IlcSehirId = ilId, IlcIsim = ilceAdi, RecGuid = Guid.NewGuid() });
                    }
                }
            }

            await db.SaveChangesAsync();
            Console.WriteLine("Il/Ilce internetten guncellendi.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Il/Ilce guncelleme hatasi: {ex.Message}");
        }
    }
}
