using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public interface IBelge
    {
        int Id { get; set; }
        string? FisTipi { get; set; }
        string? Fis { get; set; }
        int TrCode { get; set; }
        string? FaturaTuru { get; set; }
        string? IhracatTasimaKodu { get; set; }
        DateTime Tarih { get; set; }
        TimeSpan? Saat { get; set; }
        DateTime? SevkTarihi { get; set; }
        string? FisNo { get; set; }
        string? BelgeNo { get; set; }
        string? OzelKod1 { get; set; }
        string? OzelKod2 { get; set; }
        string? OzelKod3 { get; set; }
        int CariId { get; set; }
        string? CariKodu { get; set; }
        string? Unvani { get; set; }
        string? Yetkili1 { get; set; }
        string? Telefon1 { get; set; }
        int? FaturaTipi { get; set; }
        int? OdemeTipi { get; set; }
        DateTime? VadeTarihi { get; set; }
        DateTime? TemlikTarihi { get; set; }
        DateTime? OpsiyonTarihi { get; set; }
        string? SiparisNo { get; set; }
        DateTime? SiparisTarihi { get; set; }
        int? IsyeriNo { get; set; }
        int? AmbarNo { get; set; }
        string? DovizKodu { get; set; }
        decimal? DovizKuru { get; set; }
        string? Personel { get; set; }
        string? Aciklama1 { get; set; }
        string? Aciklama2 { get; set; }
        string? Aciklama3 { get; set; }
        string? Aciklama4 { get; set; }
        string? Aciklama5 { get; set; }
        string? TasiyiciFirmaKodu { get; set; }
        string? TasiyiciFirmaUnvani { get; set; }
        string? TasiyiciSoforAdi { get; set; }
        string? TasiyiciSoforSoyadi { get; set; }
        string? TasiyiciSoforTckNo { get; set; }
        string? TasiyiciAracPlakaNo { get; set; }
        string? Guid { get; set; }
        decimal? Tutar { get; set; }
        decimal? ToplamIndirim { get; set; }
        decimal? KdvMatrahi { get; set; }
        decimal? KdvTutari { get; set; }
        decimal? TevkifatMuafiyeti { get; set; }
        decimal? ToplamTutar { get; set; }
        decimal? OdenecekTutar { get; set; }
        int? FaturaTuruId { get; set; }
        string? GibGonderimDurumu { get; set; }
        string? GibDurumKodu { get; set; }
        bool? Iptal { get; set; }
        int? GelenFaturaId { get; set; }
        string? ProformaNo { get; set; }
        string? SatinalmaSorumlusu { get; set; }
        string? BolumSatinAlmaSorumlusu { get; set; }
        int? SevkAdresId { get; set; }
        string? SevkiyatBaslik { get; set; }
        string? SevkiyatAdresi { get; set; }
        string? SevkiyatTelefon { get; set; }
        string? SevkiyatPostaKodu { get; set; }
        string? SevkiyatUlke { get; set; }
        string? SevkiyatSehir { get; set; }
        string? SevkiyatIlce { get; set; }
        string? FaturaDurumu { get; set; }
    }
}
