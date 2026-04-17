using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    // FaturalarView = SELECT f.*, c.CariKodu, c.Unvani, c.Vn AS CariVn, c.Email AS CariEmail, c.Telefon1 AS CariTelefon FROM Faturalar f LEFT JOIN CariKart c ON f.CariId = c.Id
    public class FaturalarView : IBelge
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        public bool Sec { get; set; }
        public string? FisTipi { get; set; }
        [NotMapped]
        public string? Fis { get; set; }
        public int TrCode { get; set; }
        public string? FaturaTuru { get; set; }
        public string? IhracatTasimaKodu { get; set; }
        public int? EvrakTipi { get; set; }
        public string? IslemTipi { get; set; }
        public DateTime Tarih { get; set; }
        [NotMapped]
        public TimeSpan? Saat { get; set; }
        public DateTime? SevkTarihi { get; set; }
        public string? FisNo { get; set; }
        public string? BelgeNo { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? OzelKod3 { get; set; }
        public int CariId { get; set; }
        public string? CariKodu { get; set; }
        public string? Unvani { get; set; }
        [NotMapped]
        public string? Yetkili1 { get; set; }
        [NotMapped]
        public string? Telefon1 { get; set; }
        public int? FaturaTipi { get; set; }
        public int? OdemeTipi { get; set; }
        public int? KapayanHesapId { get; set; }
        public DateTime? VadeTarihi { get; set; }
        public DateTime? TemlikTarihi { get; set; }
        public DateTime? OpsiyonTarihi { get; set; }
        public string? SiparisNo { get; set; }
        public DateTime? SiparisTarihi { get; set; }
        public int? IsyeriNo { get; set; }
        public int? AmbarNo { get; set; }
        public string? DovizKodu { get; set; }
        [NotMapped]
        public string? DovizCinsi { get; set; }
        public int? DovizTuru { get; set; }
        public decimal? DovizKuru { get; set; }
        public string? Personel { get; set; }
        public string? SatinalmaSorumlusu { get; set; }
        public string? BolumSatinAlmaSorumlusu { get; set; }
        public string? ProformaNo { get; set; }
        public int? ProjeId { get; set; }
        public int? PlasiyerId { get; set; }
        public int? SorumlulukMerkeziId { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Aciklama2 { get; set; }
        public string? Aciklama3 { get; set; }
        public string? Aciklama4 { get; set; }
        public string? Aciklama5 { get; set; }
        [NotMapped]
        public string? TasiyiciFirmaKodu { get; set; }
        [NotMapped]
        public string? TasiyiciFirmaUnvani { get; set; }
        [NotMapped]
        public string? TasiyiciSoforAdi { get; set; }
        [NotMapped]
        public string? TasiyiciSoforSoyadi { get; set; }
        [NotMapped]
        public string? TasiyiciSoforTckNo { get; set; }
        [NotMapped]
        public string? TasiyiciAracPlakaNo { get; set; }

        public decimal? Tutar { get; set; }
        public decimal? ToplamIndirim { get; set; }
        public decimal? KdvMatrahi { get; set; }
        public decimal? KdvTutari { get; set; }
        public decimal? TevkifatMuafiyeti { get; set; }
        public decimal? ToplamTutar { get; set; }
        public decimal? OdenecekTutar { get; set; }

        public decimal? TLTutar { get; set; }
        public decimal? TLToplamIndirim { get; set; }
        public decimal? TLKdvMatrahi { get; set; }
        public decimal? TLKdvTutari { get; set; }
        public decimal? TLToplamTutar { get; set; }
        public decimal? TLOdenecekTutar { get; set; }

        public string? GibGonderimDurumu { get; set; }
        public string? FaturaDurumu { get; set; }
        public string? ETTN { get; set; }
        public string? ZarfDurumu { get; set; }
        public string? ZarfDurumAciklama { get; set; }
        public bool? Iptal { get; set; }
        public DateTime? IptalTarihi { get; set; }
        public string? IptalEden { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public int? OlusturanKullanici { get; set; }

        // View additional columns
        public string? CariVn { get; set; }
        public string? CariEmail { get; set; }
        public string? CariTelefon { get; set; }

        // NotMapped - used in UI but not in DB
        [NotMapped]
        public int? FaturaTuruId { get; set; }
        [NotMapped]
        public string? Guid { get; set; }
        [NotMapped]
        public int? Status { get; set; }
        [NotMapped]
        public string? GibDurumKodu { get; set; }
        [NotMapped]
        public string? InvoiceStatus { get; set; }
        [NotMapped]
        public string? InvoiceStatusDescription { get; set; }
        [NotMapped]
        public int? GelenFaturaId { get; set; }
        [NotMapped]
        public int? SevkAdresId { get; set; }
        [NotMapped]
        public string? SevkiyatBaslik { get; set; }
        [NotMapped]
        public string? SevkiyatAdresi { get; set; }
        [NotMapped]
        public string? SevkiyatTelefon { get; set; }
        [NotMapped]
        public string? SevkiyatPostaKodu { get; set; }
        [NotMapped]
        public string? SevkiyatUlke { get; set; }
        [NotMapped]
        public string? SevkiyatSehir { get; set; }
        [NotMapped]
        public string? SevkiyatIlce { get; set; }
    }

    // IrsaliyelerView uses same view structure
    public class IrsaliyelerView : IBelge
    {
        [Key]
        public int Id { get; set; }
        public string? FisTipi { get; set; }
        [NotMapped]
        public string? Fis { get; set; }
        public int TrCode { get; set; }
        public string? FaturaTuru { get; set; }
        public string? IhracatTasimaKodu { get; set; }
        public DateTime Tarih { get; set; }
        [NotMapped]
        public TimeSpan? Saat { get; set; }
        public DateTime? SevkTarihi { get; set; }
        public string? FisNo { get; set; }
        public string? BelgeNo { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? OzelKod3 { get; set; }
        public int CariId { get; set; }
        public string? CariKodu { get; set; }
        public string? Unvani { get; set; }
        [NotMapped]
        public string? Yetkili1 { get; set; }
        [NotMapped]
        public string? Telefon1 { get; set; }
        public int? FaturaTipi { get; set; }
        public int? OdemeTipi { get; set; }
        public DateTime? VadeTarihi { get; set; }
        public DateTime? TemlikTarihi { get; set; }
        public DateTime? OpsiyonTarihi { get; set; }
        [NotMapped]
        public string? SiparisNo { get; set; }
        [NotMapped]
        public DateTime? SiparisTarihi { get; set; }
        public int? IsyeriNo { get; set; }
        public int? AmbarNo { get; set; }
        public string? DovizKodu { get; set; }
        public decimal? DovizKuru { get; set; }
        public string? Personel { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Aciklama2 { get; set; }
        public string? Aciklama3 { get; set; }
        public string? Aciklama4 { get; set; }
        public string? Aciklama5 { get; set; }
        [NotMapped]
        public string? TasiyiciFirmaKodu { get; set; }
        [NotMapped]
        public string? TasiyiciFirmaUnvani { get; set; }
        [NotMapped]
        public string? TasiyiciSoforAdi { get; set; }
        [NotMapped]
        public string? TasiyiciSoforSoyadi { get; set; }
        [NotMapped]
        public string? TasiyiciSoforTckNo { get; set; }
        [NotMapped]
        public string? TasiyiciAracPlakaNo { get; set; }
        public decimal? Tutar { get; set; }
        public decimal? ToplamIndirim { get; set; }
        public decimal? KdvMatrahi { get; set; }
        public decimal? KdvTutari { get; set; }
        public decimal? TevkifatMuafiyeti { get; set; }
        public decimal? ToplamTutar { get; set; }
        public decimal? OdenecekTutar { get; set; }
        public string? GibGonderimDurumu { get; set; }
        public string? FaturaDurumu { get; set; }
        public string? ETTN { get; set; }
        public string? ZarfDurumu { get; set; }
        public string? ZarfDurumAciklama { get; set; }
        public bool? Iptal { get; set; }
        [NotMapped]
        public int? FaturaTuruId { get; set; }
        [NotMapped]
        public string? Guid { get; set; }
        [NotMapped]
        public int? Status { get; set; }
        [NotMapped]
        public string? GibDurumKodu { get; set; }
        [NotMapped]
        public int? GelenFaturaId { get; set; }
        [NotMapped]
        public string? ProformaNo { get; set; }
        [NotMapped]
        public string? SatinalmaSorumlusu { get; set; }
        [NotMapped]
        public string? BolumSatinAlmaSorumlusu { get; set; }
        [NotMapped]
        public int? SevkAdresId { get; set; }
        [NotMapped]
        public string? SevkiyatBaslik { get; set; }
        [NotMapped]
        public string? SevkiyatAdresi { get; set; }
        [NotMapped]
        public string? SevkiyatTelefon { get; set; }
        [NotMapped]
        public string? SevkiyatPostaKodu { get; set; }
        [NotMapped]
        public string? SevkiyatUlke { get; set; }
        [NotMapped]
        public string? SevkiyatSehir { get; set; }
        [NotMapped]
        public string? SevkiyatIlce { get; set; }
    }

    public class SiparislerView : IBelge
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        public string? FisTipi { get; set; }
        [NotMapped]
        public string? Fis { get; set; }
        public int TrCode { get; set; }
        public DateTime Tarih { get; set; }
        [NotMapped]
        public TimeSpan? Saat { get; set; }
        public DateTime? SevkTarihi { get; set; }
        public string? FisNo { get; set; }
        public string? BelgeNo { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? OzelKod3 { get; set; }
        [NotMapped]
        public string? IhracatTasimaKodu { get; set; }
        public int CariId { get; set; }
        public string? CariKodu { get; set; }
        public string? Unvani { get; set; }
        [NotMapped]
        public string? Yetkili1 { get; set; }
        [NotMapped]
        public string? Telefon1 { get; set; }
        public int? FaturaTipi { get; set; }
        public int? OdemeTipi { get; set; }
        public string? FaturaTuru { get; set; }
        public DateTime? VadeTarihi { get; set; }
        public DateTime? TemlikTarihi { get; set; }
        public DateTime? OpsiyonTarihi { get; set; }
        [NotMapped]
        public string? SiparisNo { get; set; }
        [NotMapped]
        public DateTime? SiparisTarihi { get; set; }
        public int? IsyeriNo { get; set; }
        public int? AmbarNo { get; set; }
        public string? DovizKodu { get; set; }
        public decimal? DovizKuru { get; set; }
        public string? Personel { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Aciklama2 { get; set; }
        public string? Aciklama3 { get; set; }
        public string? Aciklama4 { get; set; }
        public string? Aciklama5 { get; set; }
        [NotMapped]
        public string? TasiyiciFirmaKodu { get; set; }
        [NotMapped]
        public string? TasiyiciFirmaUnvani { get; set; }
        [NotMapped]
        public string? TasiyiciSoforAdi { get; set; }
        [NotMapped]
        public string? TasiyiciSoforSoyadi { get; set; }
        [NotMapped]
        public string? TasiyiciSoforTckNo { get; set; }
        [NotMapped]
        public string? TasiyiciAracPlakaNo { get; set; }
        public decimal? Tutar { get; set; }
        public decimal? ToplamIndirim { get; set; }
        public decimal? KdvMatrahi { get; set; }
        public decimal? KdvTutari { get; set; }
        public decimal? TevkifatMuafiyeti { get; set; }
        public decimal? ToplamTutar { get; set; }
        public decimal? OdenecekTutar { get; set; }
        [NotMapped]
        public int? FaturaTuruId { get; set; }
        [NotMapped]
        public string? Guid { get; set; }
        [NotMapped]
        public int? Status { get; set; }
        [NotMapped]
        public string? GibGonderimDurumu { get; set; }
        [NotMapped]
        public string? GibDurumKodu { get; set; }
        public bool? Iptal { get; set; }
        [NotMapped]
        public int? GelenFaturaId { get; set; }
        [NotMapped]
        public string? ProformaNo { get; set; }
        [NotMapped]
        public string? SatinalmaSorumlusu { get; set; }
        [NotMapped]
        public string? BolumSatinAlmaSorumlusu { get; set; }
        [NotMapped]
        public int? SevkAdresId { get; set; }
        [NotMapped]
        public string? SevkiyatBaslik { get; set; }
        [NotMapped]
        public string? SevkiyatAdresi { get; set; }
        [NotMapped]
        public string? SevkiyatTelefon { get; set; }
        [NotMapped]
        public string? SevkiyatPostaKodu { get; set; }
        [NotMapped]
        public string? SevkiyatUlke { get; set; }
        [NotMapped]
        public string? SevkiyatSehir { get; set; }
        [NotMapped]
        public string? SevkiyatIlce { get; set; }
        [NotMapped]
        public string? FaturaDurumu { get; set; }
    }

    public class FaturaTipleri
    {
        public int Id { get; set; }
        public Int16 NR { get; set; }
        public string? NAME { get; set; }
    }

    public class FaturaSecenekleri
    {
        public int Id { get; set; }
        public string? ACIKLAMA { get; set; }
    }

    public class IrsaliyeTipleri
    {
        public int Id { get; set; }
        public Int16 NR { get; set; }
        public string? NAME { get; set; }
    }
}
