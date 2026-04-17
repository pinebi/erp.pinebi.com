using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.MachineBiss;

/// <summary>
/// Stok karti fiyat tanimlari - Her stok icin farkli fiyat gruplari tanimlanabilir
/// </summary>
public class StokFiyatlar
{
    [Key]
    public int Id { get; set; }

    // Iliski
    public int StokId { get; set; }
    public int FiyatGrubu { get; set; } = 1;

    // Fiyat Bilgileri
    public decimal Fiyat { get; set; }
    public decimal? EskiFiyat { get; set; }
    public decimal? MinFiyat { get; set; }
    public decimal? MaxFiyat { get; set; }
    public decimal? KarMarji { get; set; }
    public decimal? AlisFiyati { get; set; }

    // Doviz
    public string? DovizKodu { get; set; } = "TL";
    public decimal? DovizKuru { get; set; } = 1;
    public decimal? TLKarsiligi { get; set; }

    // KDV
    public bool KdvDahil { get; set; } = false;
    public decimal? KdvOrani { get; set; }
    public decimal? KdvTutari { get; set; }
    public decimal? KdvDahilFiyat { get; set; }
    public decimal? KdvHaricFiyat { get; set; }

    // Iskonto
    public decimal? IskontoOrani1 { get; set; }
    public decimal? IskontoOrani2 { get; set; }
    public decimal? IskontoOrani3 { get; set; }
    public decimal? IskontoTutari { get; set; }
    public decimal? NetFiyat { get; set; }

    // Gecerlilik
    public DateTime? GecerlilikBaslangic { get; set; }
    public DateTime? GecerlilikBitis { get; set; }
    public bool Aktif { get; set; } = true;

    // Birim Fiyat
    public string? BirimKodu { get; set; }
    public decimal? BirimCarpani { get; set; } = 1;

    // Miktar Bazli Fiyat
    public decimal? MinMiktar { get; set; }
    public decimal? MaxMiktar { get; set; }

    // Kampanya/Promosyon
    public bool KampanyaFiyati { get; set; } = false;
    public string? KampanyaKodu { get; set; }
    public string? KampanyaAciklama { get; set; }

    // Aciklama
    public string? Aciklama { get; set; }
    public string? Not1 { get; set; }
    public string? Not2 { get; set; }

    // Onay
    public bool Onaylandi { get; set; } = false;
    public string? OnaylayanKullanici { get; set; }
    public DateTime? OnayTarihi { get; set; }

    // Audit
    public DateTime? OlusturmaTarihi { get; set; }
    public string? OlusturanKullanici { get; set; }
    public DateTime? GuncellemeTarihi { get; set; }
    public string? GuncelleyenKullanici { get; set; }
}

/// <summary>
/// Fiyat gruplari tanimi - Perakende, Toptan, Bayi vb.
/// </summary>
public class FiyatGruplari
{
    [Key]
    public int Id { get; set; }
    public int GrupNo { get; set; }
    public string? GrupAdi { get; set; }
    public string? Aciklama { get; set; }
    public decimal? VarsayilanIskontoOrani { get; set; }
    public string? VarsayilanDovizKodu { get; set; } = "TL";
    public bool KdvDahil { get; set; } = false;
    public int? OncelikSirasi { get; set; }
    public bool Aktif { get; set; } = true;

    // Audit
    public DateTime? OlusturmaTarihi { get; set; }
    public string? OlusturanKullanici { get; set; }
    public DateTime? GuncellemeTarihi { get; set; }
    public string? GuncelleyenKullanici { get; set; }
}

/// <summary>
/// Cari ozel fiyat tanimlari - Belirli bir cariye ozel fiyat verilebilir
/// </summary>
public class CariFiyatlar
{
    [Key]
    public int Id { get; set; }

    // Iliski
    public int CariId { get; set; }
    public int StokId { get; set; }

    // Fiyat
    public decimal Fiyat { get; set; }
    public string? DovizKodu { get; set; } = "TL";
    public bool KdvDahil { get; set; } = false;

    // Iskonto
    public decimal? IskontoOrani1 { get; set; }
    public decimal? IskontoOrani2 { get; set; }

    // Gecerlilik
    public DateTime? GecerlilikBaslangic { get; set; }
    public DateTime? GecerlilikBitis { get; set; }
    public bool Aktif { get; set; } = true;

    // Aciklama
    public string? Aciklama { get; set; }

    // Audit
    public DateTime? OlusturmaTarihi { get; set; }
    public string? OlusturanKullanici { get; set; }
    public DateTime? GuncellemeTarihi { get; set; }
    public string? GuncelleyenKullanici { get; set; }
}

/// <summary>
/// Stok fiyat degisiklik gecmisi - Her fiyat degisikligi loglanir
/// </summary>
public class StokFiyatGecmisi
{
    [Key]
    public int Id { get; set; }
    public int StokId { get; set; }
    public int FiyatGrubu { get; set; }
    public decimal EskiFiyat { get; set; }
    public decimal YeniFiyat { get; set; }
    public decimal? DegisimOrani { get; set; }
    public string? DovizKodu { get; set; }
    public string? DegisiklikNedeni { get; set; }
    public DateTime DegisiklikTarihi { get; set; } = DateTime.Now;
    public string? DegistirenKullanici { get; set; }
}
