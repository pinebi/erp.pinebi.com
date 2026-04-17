using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.PineERP.Stok;

namespace MACHINEBISS_Web.Controllers.Api;

[Route("api/stok")]
public class StokController : BaseApiController
{
    private readonly IDbContextFactory<PineErpContext> _factory;
    public StokController(IDbContextFactory<PineErpContext> factory) => _factory = factory;

    // ===== STOK KARTLARI =====

    /// <summary>
    /// Stok kartlari listesi (sayfalama + arama + grup filtre).
    /// GET api/stok/kartlar?sayfa=1&boyut=50&arama=laptop&grup=HAMMADDE
    /// </summary>
    [HttpGet("kartlar")]
    public async Task<IActionResult> GetKartlar(int sayfa = 1, int boyut = 50, string? arama = null, string? grup = null)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var query = db.Stoklar.AsNoTracking().Where(s => !s.RecIptal && !s.RecGizli);

            if (!string.IsNullOrEmpty(arama))
            {
                query = query.Where(s =>
                    EF.Functions.Collate(s.StoKod, "Latin1_General_CI_AI").Contains(arama) ||
                    EF.Functions.Collate(s.StoIsim, "Latin1_General_CI_AI").Contains(arama) ||
                    (s.StoBarkod1 != null && s.StoBarkod1.Contains(arama)));
            }

            if (!string.IsNullOrEmpty(grup))
                query = query.Where(s => s.StoAnagrupKod == grup);

            var toplam = await query.CountAsync();

            var data = await query
                .OrderBy(s => s.StoKod)
                .Skip((sayfa - 1) * boyut)
                .Take(boyut)
                .Select(s => new
                {
                    s.Id, s.StoKod, s.StoIsim, s.StoBirim1Ad,
                    StoAnagrupKod = s.StoAnagrupKod,
                    s.StoPerakendeVergi, s.StoMinStok, s.StoMaxStok,
                    StoBarkod1 = s.StoBarkod1,
                    s.StoPasifFl, s.RecKilitli,
                    Fiyat = db.StokFiyatlari.AsNoTracking()
                        .Where(f => f.SfyStokKod == s.StoKod && f.SfyFiyatGrubu == 1 && !f.RecIptal
                                    && (f.SfyDepoKod == null || f.SfyDepoKod == ""))
                        .Select(f => (decimal?)f.SfyFiyat).FirstOrDefault() ?? 0m
                })
                .ToListAsync();

            return OkPaged(data, toplam, sayfa, boyut);
        }
        catch (Exception ex)
        {
            return Error($"Stok kartlari yuklenirken hata: {ex.Message}", 500);
        }
    }

    /// <summary>
    /// Tek stok karti ID ile getir.
    /// GET api/stok/kart/5
    /// </summary>
    [HttpGet("kart/{id}")]
    public async Task<IActionResult> GetKart(int id)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var kart = await db.Stoklar.AsNoTracking()
                .FirstOrDefaultAsync(s => s.Id == id && !s.RecIptal && !s.RecGizli);

            if (kart == null)
                return Error("Stok karti bulunamadi", 404);

            return Ok(kart);
        }
        catch (Exception ex)
        {
            return Error($"Stok karti yuklenirken hata: {ex.Message}", 500);
        }
    }

    /// <summary>
    /// Stok arama (Fatura formu icin). Kod, isim ve barkod'da arar.
    /// GET api/stok/ara?q=sivri&limit=50
    /// </summary>
    [HttpGet("ara")]
    public async Task<IActionResult> StokAra([FromQuery] string? q = null, [FromQuery] int limit = 50)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var query = db.Stoklar.AsNoTracking().Where(s => !s.RecIptal && !s.RecGizli);

            if (!string.IsNullOrWhiteSpace(q))
            {
                var arama = q.Replace("*", "").Trim();
                if (!string.IsNullOrEmpty(arama))
                {
                    query = query.Where(s =>
                        EF.Functions.Collate(s.StoKod, "Latin1_General_CI_AI").Contains(arama) ||
                        EF.Functions.Collate(s.StoIsim, "Latin1_General_CI_AI").Contains(arama) ||
                        (s.StoBarkod1 != null && s.StoBarkod1.Contains(arama)));
                }
            }

            var data = await query
                .OrderBy(s => s.StoKod)
                .Take(limit)
                .Select(s => new
                {
                    StoKod = s.StoKod,
                    StoIsim = s.StoIsim,
                    StoBirim = s.StoBirim1Ad ?? "AD",
                    StoSatisFiyat = db.StokFiyatlari.AsNoTracking()
                        .Where(f => f.SfyStokKod == s.StoKod && f.SfyFiyatGrubu == 1 && !f.RecIptal
                                    && (f.SfyDepoKod == null || f.SfyDepoKod == ""))
                        .Select(f => (decimal?)f.SfyFiyat).FirstOrDefault() ?? 0m,
                    StoKdvOrani = s.StoPerakendeVergi
                })
                .ToListAsync();

            return Ok(data);
        }
        catch (Exception ex)
        {
            return Error($"Stok arama hatasi: {ex.Message}", 500);
        }
    }

    /// <summary>
    /// Tek stok karti KOD ile getir.
    /// GET api/stok/kart/kod/STK-001
    /// </summary>
    [HttpGet("kart/kod/{kod}")]
    public async Task<IActionResult> GetKartByKod(string kod)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var kart = await db.Stoklar.AsNoTracking()
                .FirstOrDefaultAsync(s => s.StoKod == kod && !s.RecIptal && !s.RecGizli);

            if (kart == null)
                return Error("Stok karti bulunamadi", 404);

            return Ok(kart);
        }
        catch (Exception ex)
        {
            return Error($"Stok karti yuklenirken hata: {ex.Message}", 500);
        }
    }

    /// <summary>
    /// Yeni stok karti olustur.
    /// POST api/stok/kart
    /// </summary>
    [HttpPost("kart")]
    public async Task<IActionResult> CreateKart([FromBody] PineStoklar model)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(model.StoKod))
                return Error("Stok kodu bos olamaz");

            if (string.IsNullOrWhiteSpace(model.StoIsim))
                return Error("Stok ismi bos olamaz");

            using var db = await _factory.CreateDbContextAsync();

            // Kod tekrari kontrolu
            var varMi = await db.Stoklar.AnyAsync(s => s.StoKod == model.StoKod && !s.RecIptal && !s.RecGizli);
            if (varMi)
                return Error($"'{model.StoKod}' kodlu stok zaten mevcut");

            model.RecCreateDate = DateTime.Now;
            model.RecCreateUser = "system"; // TODO: Auth'dan alinacak
            model.RecGuid = Guid.NewGuid();

            db.Stoklar.Add(model);
            await db.SaveChangesAsync();

            return Ok(model, "Stok karti basariyla olusturuldu");
        }
        catch (Exception ex)
        {
            return Error($"Stok karti olusturulurken hata: {ex.Message}", 500);
        }
    }

    /// <summary>
    /// Stok karti guncelle.
    /// PUT api/stok/kart/5
    /// </summary>
    [HttpPut("kart/{id}")]
    public async Task<IActionResult> UpdateKart(int id, [FromBody] PineStoklar model)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var kart = await db.Stoklar.FirstOrDefaultAsync(s => s.Id == id && !s.RecIptal && !s.RecGizli);

            if (kart == null)
                return Error("Stok karti bulunamadi", 404);

            if (kart.RecKilitli)
                return Error("Bu stok karti kilitli, duzenlenemez");

            // Kod degisiyorsa tekrar kontrolu
            if (model.StoKod != kart.StoKod)
            {
                var varMi = await db.Stoklar.AnyAsync(s => s.StoKod == model.StoKod && s.Id != id && !s.RecIptal && !s.RecGizli);
                if (varMi)
                    return Error($"'{model.StoKod}' kodlu stok zaten mevcut");
            }

            // Temel bilgiler
            kart.StoKod = model.StoKod;
            kart.StoIsim = model.StoIsim;
            kart.StoKisaIsim = model.StoKisaIsim;
            kart.StoYabanciIsim = model.StoYabanciIsim;

            // Siniflandirma
            kart.StoCins = model.StoCins;
            kart.StoAnagrupKod = model.StoAnagrupKod;
            kart.StoAltgrupKod = model.StoAltgrupKod;
            kart.StoKategoriKodu = model.StoKategoriKodu;
            kart.StoMarkaKodu = model.StoMarkaKodu;
            kart.StoSektorKodu = model.StoSektorKodu;

            // Birim
            kart.StoBirim1Ad = model.StoBirim1Ad;
            kart.StoBirim2Ad = model.StoBirim2Ad;
            kart.StoBirim3Ad = model.StoBirim3Ad;
            kart.StoBirim2Katsayi = model.StoBirim2Katsayi;
            kart.StoBirim3Katsayi = model.StoBirim3Katsayi;
            kart.StoBirim4Ad = model.StoBirim4Ad;
            kart.StoBirim4Katsayi = model.StoBirim4Katsayi;

            // Boyut/Agirlik
            kart.StoBirimAgirlik = model.StoBirimAgirlik;
            kart.StoBirimEn = model.StoBirimEn;
            kart.StoBirimBoy = model.StoBirimBoy;
            kart.StoBirimYukseklik = model.StoBirimYukseklik;
            kart.StoBirimHacim = model.StoBirimHacim;

            // Stok seviyeleri
            kart.StoMinStok = model.StoMinStok;
            kart.StoMaxStok = model.StoMaxStok;
            kart.StoSiparisStok = model.StoSiparisStok;
            kart.StoSiparisSure = model.StoSiparisSure;

            // Vergi
            kart.StoPerakendeVergi = model.StoPerakendeVergi;
            kart.StoToptanVergi = model.StoToptanVergi;
            kart.StoOtvUygulama = model.StoOtvUygulama;
            kart.StoOtvTutari = model.StoOtvTutari;

            // Barkod
            kart.StoBarkod1 = model.StoBarkod1;
            kart.StoBarkod2 = model.StoBarkod2;
            kart.StoBarkod3 = model.StoBarkod3;

            // Referans
            kart.StoUreticiKodu = model.StoUreticiKodu;
            kart.StoTedarikciKodu = model.StoTedarikciKodu;
            kart.StoGtipKodu = model.StoGtipKodu;
            kart.StoMensei = model.StoMensei;

            // Takip
            kart.StoGarantiSuresi = model.StoGarantiSuresi;
            kart.StoRafOmru = model.StoRafOmru;
            kart.StoSeriTakibi = model.StoSeriTakibi;
            kart.StoLotTakibi = model.StoLotTakibi;
            kart.StoSktTakibi = model.StoSktTakibi;

            // Durum
            kart.StoPasifFl = model.StoPasifFl;
            kart.StoSatisDursun = model.StoSatisDursun;
            kart.StoSiparisDursun = model.StoSiparisDursun;

            // E-fatura
            kart.StoEfatSinifKodu = model.StoEfatSinifKodu;

            // Medya
            kart.StoResimUrl = model.StoResimUrl;

            // Notlar
            kart.StoAciklama = model.StoAciklama;
            kart.StoNot1 = model.StoNot1;
            kart.StoNot2 = model.StoNot2;
            kart.StoNot3 = model.StoNot3;

            // Ozel kodlar
            kart.StoOzelkod1 = model.StoOzelkod1;
            kart.StoOzelkod2 = model.StoOzelkod2;
            kart.StoOzelkod3 = model.StoOzelkod3;
            kart.StoOzelkod4 = model.StoOzelkod4;
            kart.StoOzelkod5 = model.StoOzelkod5;

            // Diger
            kart.StoKomisyonOrani = model.StoKomisyonOrani;
            kart.StoKaliteKontrol = model.StoKaliteKontrol;
            kart.StoAmbalajTipi = model.StoAmbalajTipi;
            kart.StoKoliAdedi = model.StoKoliAdedi;

            // ===== MIKRO: Stok tanitim karti ek =====
            kart.StoPesinSatisFiyati = model.StoPesinSatisFiyati;
            kart.StoPesinSatisDoviz = model.StoPesinSatisDoviz;
            kart.StoIskontoKodu = model.StoIskontoKodu;
            kart.StoStandartMaliyet = model.StoStandartMaliyet;
            kart.StoOtvBirimi = model.StoOtvBirimi;
            kart.StoOtvListeNo = model.StoOtvListeNo;
            kart.StoOtvTevkifatUygulama = model.StoOtvTevkifatUygulama;
            kart.StoOivUygulama = model.StoOivUygulama;
            kart.StoOivTutarOran = model.StoOivTutarOran;
            kart.StoOivTuru = model.StoOivTuru;
            kart.StoOivVergiTipi = model.StoOivVergiTipi;
            kart.StoKdvTevkifatUygulama = model.StoKdvTevkifatUygulama;

            // ===== MIKRO: Detaylar =====
            kart.StoHedefStok = model.StoHedefStok;
            kart.StoMinSeviyeBelirlemeGun = model.StoMinSeviyeBelirlemeGun;
            kart.StoSiparisSeviyeBelirlemeGun = model.StoSiparisSeviyeBelirlemeGun;
            kart.StoHedefSeviyeBelirlemeGun = model.StoHedefSeviyeBelirlemeGun;
            kart.StoSeviyeDegerlendirilmesin = model.StoSeviyeDegerlendirilmesin;
            kart.StoVerilenSiparisBirim = model.StoVerilenSiparisBirim;
            kart.StoDepoAdresi = model.StoDepoAdresi;
            kart.StoKarOrani = model.StoKarOrani;
            kart.StoPrimOrani = model.StoPrimOrani;
            kart.StoPuani = model.StoPuani;
            kart.StoKomisyonHizmetKodu = model.StoKomisyonHizmetKodu;
            kart.StoOngorulenGarantiBirim = model.StoOngorulenGarantiBirim;
            kart.StoMikroshopMaksIskonto = model.StoMikroshopMaksIskonto;
            kart.StoOndalikliUretim = model.StoOndalikliUretim;
            kart.StoZRaporuDepartman = model.StoZRaporuDepartman;
            kart.StoIplikNeNumarasi = model.StoIplikNeNumarasi;
            kart.StoKanbanKasaMiktari = model.StoKanbanKasaMiktari;
            kart.StoIskontoMatrisiKasalar = model.StoIskontoMatrisiKasalar;
            kart.StoIskontoOrani = model.StoIskontoOrani;
            kart.StoIskontoTutari = model.StoIskontoTutari;
            kart.StoVarsayilanGiderKodu = model.StoVarsayilanGiderKodu;
            kart.StoGelirPayi = model.StoGelirPayi;

            // ===== MIKRO: Takip detaylari =====
            kart.StoSktKullanimi = model.StoSktKullanimi;
            kart.StoTeraziSkt = model.StoTeraziSkt;
            kart.StoKasadaTaksitlenebilir = model.StoKasadaTaksitlenebilir;
            kart.StoHalRusumu = model.StoHalRusumu;
            kart.StoKaynakPlanlamaDegerlendirilsin = model.StoKaynakPlanlamaDegerlendirilsin;
            kart.StoCrmAktarilacak = model.StoCrmAktarilacak;
            kart.StoUtsGonderilsin = model.StoUtsGonderilsin;
            kart.StoGeriKazanimBeyanname = model.StoGeriKazanimBeyanname;
            kart.StoGekapKodu = model.StoGekapKodu;
            kart.StoGekapBirimi = model.StoGekapBirimi;
            kart.StoGekapDepOnayKodu = model.StoGekapDepOnayKodu;
            kart.StoSttOncesiKaldirma = model.StoSttOncesiKaldirma;
            kart.StoToplamRafOmru = model.StoToplamRafOmru;
            kart.StoCabukBozulabilen = model.StoCabukBozulabilen;
            kart.StoSatinalmaTalepBirim = model.StoSatinalmaTalepBirim;
            kart.StoUrunNiteligi = model.StoUrunNiteligi;
            kart.StoGtinUno = model.StoGtinUno;
            kart.StoTibbiLotParti = model.StoTibbiLotParti;
            kart.StoKarsiProgramKodu = model.StoKarsiProgramKodu;

            // ===== MIKRO: Entegrasyon kodlari =====
            kart.StoMuhStok = model.StoMuhStok;
            kart.StoMuhStokIade = model.StoMuhStokIade;
            kart.StoMuhYurticiSatis = model.StoMuhYurticiSatis;
            kart.StoMuhSatilanMalMaliyeti = model.StoMuhSatilanMalMaliyeti;
            kart.StoMuhYurtdisiSatis = model.StoMuhYurtdisiSatis;
            kart.StoMuhYurtdisiMaliyet = model.StoMuhYurtdisiMaliyet;
            kart.StoMuhSatisIade = model.StoMuhSatisIade;
            kart.StoMuhSatisIskonto = model.StoMuhSatisIskonto;
            kart.StoMuhAlisIskonto = model.StoMuhAlisIskonto;
            kart.StoMuhIlaveMasraf = model.StoMuhIlaveMasraf;
            kart.StoMuhYatirimTesvik = model.StoMuhYatirimTesvik;
            kart.StoMuhDepolarArasiSatis = model.StoMuhDepolarArasiSatis;
            kart.StoMuhDepolarArasiMaliyet = model.StoMuhDepolarArasiMaliyet;
            kart.StoMuhBagliOrtaklikSatis = model.StoMuhBagliOrtaklikSatis;
            kart.StoMuhBagliOrtaklikIade = model.StoMuhBagliOrtaklikIade;
            kart.StoMuhBagliOrtaklikIskonto = model.StoMuhBagliOrtaklikIskonto;
            kart.StoMuhBagliOrtaklikMaliyet = model.StoMuhBagliOrtaklikMaliyet;
            kart.StoMuhSatisFiyatFarki = model.StoMuhSatisFiyatFarki;
            kart.StoMuhSifirBedelMaliyet = model.StoMuhSifirBedelMaliyet;
            kart.StoMuhIhracKayitliSatis = model.StoMuhIhracKayitliSatis;
            kart.StoMuhIhracKayitliMaliyet = model.StoMuhIhracKayitliMaliyet;
            kart.StoMuhKodArtikeli = model.StoMuhKodArtikeli;

            // ===== MIKRO: Grup tanitim kodlari =====
            kart.StoPozisyonGrupKodu = model.StoPozisyonGrupKodu;
            kart.StoAnaSaglayiciKodu = model.StoAnaSaglayiciKodu;
            kart.StoReyonKodu = model.StoReyonKodu;
            kart.StoAmbalajKodu = model.StoAmbalajKodu;
            kart.StoMuhasebeGrupKodu = model.StoMuhasebeGrupKodu;
            kart.StoUrunSorumlusuKodu = model.StoUrunSorumlusuKodu;
            kart.StoKaliteKontrolKodu = model.StoKaliteKontrolKodu;
            kart.StoModelKodu = model.StoModelKodu;
            kart.StoSezonKodu = model.StoSezonKodu;
            kart.StoAnahammaddeKodu = model.StoAnahammaddeKodu;
            kart.StoPrimGrupKodu = model.StoPrimGrupKodu;
            kart.StoBedenDetayli = model.StoBedenDetayli;
            kart.StoBedenKodu = model.StoBedenKodu;
            kart.StoRenkDetayli = model.StoRenkDetayli;
            kart.StoRenkKodu = model.StoRenkKodu;
            kart.StoPaketKodu = model.StoPaketKodu;
            kart.StoTamamlayiciKodu = model.StoTamamlayiciKodu;

            // ===== MIKRO: Pozisyon bayraklari =====
            kart.StoRafEtiketi = model.StoRafEtiketi;
            kart.StoElektronikEtiketTipi = model.StoElektronikEtiketTipi;
            kart.StoEtiketBasilsin = model.StoEtiketBasilsin;
            kart.StoMalKabulDursun = model.StoMalKabulDursun;
            kart.StoMalKabulGunleri = model.StoMalKabulGunleri;
            kart.StoSiparisGunleri = model.StoSiparisGunleri;
            kart.StoIskontoYapilamaz = model.StoIskontoYapilamaz;
            kart.StoKasadaTartilan = model.StoKasadaTartilan;
            kart.StoEksiDusmeGozardi = model.StoEksiDusmeGozardi;
            kart.StoWebGonderilecek = model.StoWebGonderilecek;
            kart.StoMenseiTipi = model.StoMenseiTipi;
            kart.StoFiyatKasadaBelirlensin = model.StoFiyatKasadaBelirlensin;
            kart.StoFranchiseSiparisDursun = model.StoFranchiseSiparisDursun;
            kart.StoTasfiyede = model.StoTasfiyede;
            kart.StoYerlilikOrani = model.StoYerlilikOrani;

            // Audit
            kart.RecLastupDate = DateTime.Now;
            kart.RecLastupUser = "system"; // TODO: Auth'dan alinacak

            await db.SaveChangesAsync();
            return Ok(kart, "Stok karti basariyla guncellendi");
        }
        catch (Exception ex)
        {
            return Error($"Stok karti guncellenirken hata: {ex.Message}", 500);
        }
    }

    /// <summary>
    /// Stok karti soft delete (RecGizli=true).
    /// DELETE api/stok/kart/5
    /// </summary>
    [HttpDelete("kart/{id}")]
    public async Task<IActionResult> DeleteKart(int id)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var kart = await db.Stoklar.FirstOrDefaultAsync(s => s.Id == id && !s.RecIptal && !s.RecGizli);

            if (kart == null)
                return Error("Stok karti bulunamadi", 404);

            if (kart.RecKilitli)
                return Error("Bu stok karti kilitli, silinemez");

            // Hareket kontrolu - hareketli stok silinemez
            var hareketVar = await db.StokHareketleri.AnyAsync(h => h.SthStokKod == kart.StoKod && !h.RecIptal);
            if (hareketVar)
                return Error("Bu stok kartina ait hareketler mevcut, silinemez. Oncelikle pasif yapabilirsiniz.");

            kart.RecGizli = true;
            kart.RecLastupDate = DateTime.Now;
            kart.RecLastupUser = "system";

            await db.SaveChangesAsync();
            return OkMessage("Stok karti basariyla silindi");
        }
        catch (Exception ex)
        {
            return Error($"Stok karti silinirken hata: {ex.Message}", 500);
        }
    }

    // ===== STOK HAREKETLERI =====

    /// <summary>
    /// Stok hareketleri listesi (sayfalama + filtre).
    /// GET api/stok/hareketler?stokKod=STK-001&baslangic=2024-01-01&bitis=2024-12-31&tip=1&sayfa=1&boyut=50
    /// </summary>
    [HttpGet("hareketler")]
    public async Task<IActionResult> GetHareketler(
        string? stokKod = null,
        DateTime? baslangic = null,
        DateTime? bitis = null,
        int? tip = null,
        int? depoNo = null,
        string? belgeNo = null,
        int sayfa = 1,
        int boyut = 50)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var query = db.StokHareketleri.AsNoTracking().Where(h => !h.RecIptal && !h.RecGizli);

            if (!string.IsNullOrEmpty(stokKod))
                query = query.Where(h => h.SthStokKod == stokKod);

            if (baslangic.HasValue)
                query = query.Where(h => h.SthTarih >= baslangic.Value);

            if (bitis.HasValue)
                query = query.Where(h => h.SthTarih <= bitis.Value.Date.AddDays(1));

            if (tip.HasValue)
                query = query.Where(h => h.SthTip == tip.Value);

            if (depoNo.HasValue)
                query = query.Where(h => h.SthDepoNo == depoNo.Value);

            if (!string.IsNullOrEmpty(belgeNo))
                query = query.Where(h => h.SthBelgeNo != null && h.SthBelgeNo.Contains(belgeNo));

            var toplam = await query.CountAsync();
            var data = await query
                .OrderByDescending(h => h.SthTarih)
                .ThenByDescending(h => h.Id)
                .Skip((sayfa - 1) * boyut)
                .Take(boyut)
                .ToListAsync();

            return OkPaged(data, toplam, sayfa, boyut);
        }
        catch (Exception ex)
        {
            return Error($"Stok hareketleri yuklenirken hata: {ex.Message}", 500);
        }
    }

    // ===== STOK GRUPLARI =====

    /// <summary>
    /// Stok gruplari listesi.
    /// GET api/stok/gruplar?tip=1
    /// </summary>
    [HttpGet("gruplar")]
    public async Task<IActionResult> GetGruplar(int? tip = null)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var query = db.StokGruplari.AsNoTracking().Where(g => !g.RecIptal && !g.RecGizli && g.SgrAktif);

            if (tip.HasValue)
                query = query.Where(g => g.SgrTip == tip.Value);

            var data = await query.OrderBy(g => g.SgrTip).ThenBy(g => g.SgrSira).ThenBy(g => g.SgrKod).ToListAsync();
            return Ok(data);
        }
        catch (Exception ex)
        {
            return Error($"Stok gruplari yuklenirken hata: {ex.Message}", 500);
        }
    }

    /// <summary>
    /// Yeni stok grubu olustur.
    /// POST api/stok/grup
    /// </summary>
    [HttpPost("grup")]
    public async Task<IActionResult> CreateGrup([FromBody] PineStokGruplari model)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(model.SgrKod))
                return Error("Grup kodu bos olamaz");

            using var db = await _factory.CreateDbContextAsync();

            var varMi = await db.StokGruplari.AnyAsync(g => g.SgrKod == model.SgrKod && g.SgrTip == model.SgrTip && !g.RecIptal && !g.RecGizli);
            if (varMi)
                return Error($"'{model.SgrKod}' kodlu grup zaten mevcut");

            model.RecCreateDate = DateTime.Now;
            model.RecCreateUser = "system";
            model.RecGuid = Guid.NewGuid();

            db.StokGruplari.Add(model);
            await db.SaveChangesAsync();

            return Ok(model, "Grup basariyla olusturuldu");
        }
        catch (Exception ex)
        {
            return Error($"Grup olusturulurken hata: {ex.Message}", 500);
        }
    }

    [HttpPut("grup/{id:int}")]
    public async Task<IActionResult> UpdateGrup(int id, [FromBody] PineStokGruplari model)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var g = await db.StokGruplari.FirstOrDefaultAsync(x => x.Id == id && !x.RecIptal);
            if (g == null) return Error("Grup bulunamadi", 404);
            g.SgrKod = model.SgrKod;
            g.SgrIsim = model.SgrIsim;
            g.SgrUstKod = model.SgrUstKod;
            g.SgrAciklama = model.SgrAciklama;
            g.SgrSira = model.SgrSira;
            g.SgrAktif = model.SgrAktif;
            g.RecLastupDate = DateTime.Now;
            g.RecLastupUser = "system";
            await db.SaveChangesAsync();
            return Ok(g, "Grup guncellendi");
        }
        catch (Exception ex) { return Error($"Grup guncellenemedi: {ex.Message}", 500); }
    }

    [HttpDelete("grup/{id:int}")]
    public async Task<IActionResult> DeleteGrup(int id)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var g = await db.StokGruplari.FirstOrDefaultAsync(x => x.Id == id);
            if (g == null) return Error("Grup bulunamadi", 404);
            g.RecIptal = true;
            g.RecLastupDate = DateTime.Now;
            await db.SaveChangesAsync();
            return Ok(true, "Grup silindi");
        }
        catch (Exception ex) { return Error($"Grup silinemedi: {ex.Message}", 500); }
    }

    // ===== STOK FIYATLARI =====

    /// <summary>
    /// Stok fiyatlari (stok id veya stok kodu ile).
    /// GET api/stok/fiyatlar/5
    /// </summary>
    [HttpGet("fiyatlar/{stokId}")]
    public async Task<IActionResult> GetFiyatlar(int stokId)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();

            // Oncelikle stok kodunu bul
            var stok = await db.Stoklar.AsNoTracking().FirstOrDefaultAsync(s => s.Id == stokId);
            if (stok == null)
                return Error("Stok bulunamadi", 404);

            var data = await db.StokFiyatlari.AsNoTracking()
                .Where(f => f.SfyStokKod == stok.StoKod && !f.RecIptal && !f.RecGizli)
                .OrderBy(f => f.SfyFiyatGrubu)
                .ToListAsync();

            return Ok(data);
        }
        catch (Exception ex)
        {
            return Error($"Fiyatlar yuklenirken hata: {ex.Message}", 500);
        }
    }

    /// <summary>
    /// Yeni stok fiyati olustur veya guncelle.
    /// POST api/stok/fiyat
    /// </summary>
    [HttpPost("fiyat")]
    public async Task<IActionResult> CreateFiyat([FromBody] PineStokFiyatlari model)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(model.SfyStokKod))
                return Error("Stok kodu bos olamaz");

            using var db = await _factory.CreateDbContextAsync();

            // Ayni stok + fiyat grubu icin mevcut kayit var mi kontrol
            var mevcut = await db.StokFiyatlari.FirstOrDefaultAsync(f =>
                f.SfyStokKod == model.SfyStokKod &&
                f.SfyFiyatGrubu == model.SfyFiyatGrubu &&
                !f.RecIptal && !f.RecGizli);

            if (mevcut != null)
            {
                // Guncelle
                mevcut.SfyFiyat = model.SfyFiyat;
                mevcut.SfyEskiFiyat = mevcut.SfyFiyat;
                mevcut.SfyMinFiyat = model.SfyMinFiyat;
                mevcut.SfyMaxFiyat = model.SfyMaxFiyat;
                mevcut.SfyKarMarji = model.SfyKarMarji;
                mevcut.SfyAlisFiyati = model.SfyAlisFiyati;
                mevcut.SfyDovizKodu = model.SfyDovizKodu;
                mevcut.SfyDovizKuru = model.SfyDovizKuru;
                mevcut.SfyKdvDahil = model.SfyKdvDahil;
                mevcut.SfyKdvOrani = model.SfyKdvOrani;
                mevcut.SfyIskontoOrani1 = model.SfyIskontoOrani1;
                mevcut.SfyIskontoOrani2 = model.SfyIskontoOrani2;
                mevcut.SfyIskontoOrani3 = model.SfyIskontoOrani3;
                mevcut.SfyGecerlilikBaslangic = model.SfyGecerlilikBaslangic;
                mevcut.SfyGecerlilikBitis = model.SfyGecerlilikBitis;
                mevcut.SfyAktif = model.SfyAktif;
                mevcut.SfyAciklama = model.SfyAciklama;
                mevcut.RecLastupDate = DateTime.Now;
                mevcut.RecLastupUser = "system";

                await db.SaveChangesAsync();
                return Ok(mevcut, "Fiyat basariyla guncellendi");
            }
            else
            {
                // Yeni kayit
                model.RecCreateDate = DateTime.Now;
                model.RecCreateUser = "system";
                model.RecGuid = Guid.NewGuid();

                db.StokFiyatlari.Add(model);
                await db.SaveChangesAsync();
                return Ok(model, "Fiyat basariyla olusturuldu");
            }
        }
        catch (Exception ex)
        {
            return Error($"Fiyat kaydedilirken hata: {ex.Message}", 500);
        }
    }

    // ===== DEPOLAR =====

    /// <summary>
    /// Depo listesi.
    /// GET api/stok/depolar
    /// </summary>
    [HttpGet("depolar")]
    public async Task<IActionResult> GetDepolar()
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var data = await db.Depolar.AsNoTracking()
                .Where(d => !d.RecIptal && !d.RecGizli && d.DepAktif)
                .OrderBy(d => d.DepKod)
                .ToListAsync();
            return Ok(data);
        }
        catch (Exception ex)
        {
            return Error($"Depolar yuklenirken hata: {ex.Message}", 500);
        }
    }

    [HttpPost("depo")]
    public async Task<IActionResult> CreateDepo([FromBody] PineDepolar model)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(model.DepKod)) return Error("Depo kodu bos olamaz");
            using var db = await _factory.CreateDbContextAsync();
            var varMi = await db.Depolar.AnyAsync(d => d.DepKod == model.DepKod && !d.RecIptal);
            if (varMi) return Error($"'{model.DepKod}' kodlu depo zaten mevcut");
            model.RecCreateDate = DateTime.Now;
            model.RecCreateUser = "system";
            model.RecGuid = Guid.NewGuid();
            db.Depolar.Add(model);
            await db.SaveChangesAsync();
            return Ok(model, "Depo olusturuldu");
        }
        catch (Exception ex) { return Error($"Depo olusturulamadi: {ex.Message}", 500); }
    }

    [HttpPut("depo/{id:int}")]
    public async Task<IActionResult> UpdateDepo(int id, [FromBody] PineDepolar model)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var d = await db.Depolar.FirstOrDefaultAsync(x => x.Id == id && !x.RecIptal);
            if (d == null) return Error("Depo bulunamadi", 404);
            d.DepKod = model.DepKod;
            d.DepIsim = model.DepIsim;
            d.DepAdres = model.DepAdres;
            d.DepSehir = model.DepSehir;
            d.DepIlce = model.DepIlce;
            d.DepSorumlu = model.DepSorumlu;
            d.DepTel = model.DepTel;
            d.DepAktif = model.DepAktif;
            d.DepAdresliDepo = model.DepAdresliDepo;
            d.RecLastupDate = DateTime.Now;
            d.RecLastupUser = "system";
            await db.SaveChangesAsync();
            return Ok(d, "Depo guncellendi");
        }
        catch (Exception ex) { return Error($"Depo guncellenemedi: {ex.Message}", 500); }
    }

    [HttpDelete("depo/{id:int}")]
    public async Task<IActionResult> DeleteDepo(int id)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var d = await db.Depolar.FirstOrDefaultAsync(x => x.Id == id);
            if (d == null) return Error("Depo bulunamadi", 404);
            d.RecIptal = true;
            d.RecLastupDate = DateTime.Now;
            await db.SaveChangesAsync();
            return Ok(true, "Depo silindi");
        }
        catch (Exception ex) { return Error($"Depo silinemedi: {ex.Message}", 500); }
    }

    // ===== BIRIMLER =====

    /// <summary>
    /// Birim listesi.
    /// GET api/stok/birimler
    /// </summary>
    [HttpGet("birimler")]
    public async Task<IActionResult> GetBirimler()
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var data = await db.StokBirimleri.AsNoTracking()
                .Where(b => !b.RecIptal && !b.RecGizli && b.SbrAktif)
                .OrderBy(b => b.SbrKod)
                .ToListAsync();
            return Ok(data);
        }
        catch (Exception ex)
        {
            return Error($"Birimler yuklenirken hata: {ex.Message}", 500);
        }
    }

    // ===== STOK BAKIYE =====

    /// <summary>
    /// Stok bakiye sorgulama (depo/stok bazinda giris-cikis ozet).
    /// GET api/stok/bakiye?stokKod=STK-001&depoNo=1
    /// </summary>
    [HttpGet("bakiye")]
    public async Task<IActionResult> GetBakiye(string? stokKod = null, int? depoNo = null)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var query = db.StokHareketleriOzet.AsNoTracking().Where(o => !o.RecIptal && !o.RecGizli);

            if (!string.IsNullOrEmpty(stokKod))
                query = query.Where(o => o.ShoStokKod == stokKod);

            if (depoNo.HasValue)
                query = query.Where(o => o.ShoDepoNo == depoNo.Value);

            var ozet = await query.ToListAsync();

            // Stok bazinda toplam giren/cikan hesapla
            var bakiyeler = ozet
                .GroupBy(o => new { o.ShoStokKod, o.ShoDepoNo })
                .Select(g => new
                {
                    StokKod = g.Key.ShoStokKod,
                    DepoNo = g.Key.ShoDepoNo,
                    ToplamGiren = g.Sum(x => x.ShoGirenMiktar),
                    ToplamCikan = g.Sum(x => x.ShoCikanMiktar),
                    Bakiye = g.Sum(x => x.ShoGirenMiktar) - g.Sum(x => x.ShoCikanMiktar),
                    ToplamGirenTutar = g.Sum(x => x.ShoGirenTutar),
                    ToplamCikanTutar = g.Sum(x => x.ShoCikanTutar)
                })
                .OrderBy(b => b.StokKod)
                .ThenBy(b => b.DepoNo)
                .ToList();

            return Ok(bakiyeler);
        }
        catch (Exception ex)
        {
            return Error($"Bakiye sorgulanirken hata: {ex.Message}", 500);
        }
    }

    // ===== BARKODLAR (Mikro Barkod tanitim karti) =====

    [HttpGet("barkodlar/{stokId:int}")]
    public async Task<IActionResult> GetBarkodlar(int stokId)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var list = await db.StokBarkodlari
                .Where(b => b.SbkStokId == stokId && !b.RecIptal)
                .OrderByDescending(b => b.SbkMaster)
                .ThenBy(b => b.Id)
                .ToListAsync();
            return Ok(list);
        }
        catch (Exception ex) { return Error($"Barkodlar alinamadi: {ex.Message}", 500); }
    }

    [HttpPost("barkod")]
    public async Task<IActionResult> AddBarkod([FromBody] PineStokBarkodlari model)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(model.SbkKodu)) return Error("Barkod kodu bos olamaz");
            using var db = await _factory.CreateDbContextAsync();
            model.RecCreateDate = DateTime.Now;
            model.RecCreateUser = "system";
            model.RecGuid = Guid.NewGuid();
            db.StokBarkodlari.Add(model);
            await db.SaveChangesAsync();
            return Ok(model, "Barkod eklendi");
        }
        catch (Exception ex) { return Error($"Barkod eklenemedi: {ex.Message}", 500); }
    }

    [HttpPut("barkod/{id:int}")]
    public async Task<IActionResult> UpdateBarkod(int id, [FromBody] PineStokBarkodlari model)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var b = await db.StokBarkodlari.FirstOrDefaultAsync(x => x.Id == id && !x.RecIptal);
            if (b == null) return Error("Barkod bulunamadi", 404);
            b.SbkBaglantiTipi = model.SbkBaglantiTipi;
            b.SbkPartiKodu = model.SbkPartiKodu;
            b.SbkLotNo = model.SbkLotNo;
            b.SbkSeriNo = model.SbkSeriNo;
            b.SbkAsortiKodu = model.SbkAsortiKodu;
            b.SbkBarkodTipi = model.SbkBarkodTipi;
            b.SbkIcerik = model.SbkIcerik;
            b.SbkKodu = model.SbkKodu;
            b.SbkBirimi = model.SbkBirimi;
            b.SbkBedeni = model.SbkBedeni;
            b.SbkRengi = model.SbkRengi;
            b.SbkMaster = model.SbkMaster;
            b.RecLastupDate = DateTime.Now;
            b.RecLastupUser = "system";
            await db.SaveChangesAsync();
            return Ok(b, "Barkod guncellendi");
        }
        catch (Exception ex) { return Error($"Barkod guncellenemedi: {ex.Message}", 500); }
    }

    [HttpDelete("barkod/{id:int}")]
    public async Task<IActionResult> DeleteBarkod(int id)
    {
        try
        {
            using var db = await _factory.CreateDbContextAsync();
            var b = await db.StokBarkodlari.FirstOrDefaultAsync(x => x.Id == id);
            if (b == null) return Error("Barkod bulunamadi", 404);
            b.RecIptal = true;
            b.RecLastupDate = DateTime.Now;
            await db.SaveChangesAsync();
            return Ok(true, "Barkod silindi");
        }
        catch (Exception ex) { return Error($"Barkod silinemedi: {ex.Message}", 500); }
    }
}
