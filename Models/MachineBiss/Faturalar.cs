using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class Faturalar
    {
        [Key]
        public int Id { get; set; }
        public string? FisTipi { get; set; }
        public int TrCode { get; set; }
        public string? FaturaTuru { get; set; }
        public string? IhracatTasimaKodu { get; set; }
        public int? EvrakTipi { get; set; }
        public string? IslemTipi { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime? SevkTarihi { get; set; }
        public string? FisNo { get; set; }
        public string? BelgeNo { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? OzelKod3 { get; set; }
        public int CariId { get; set; }
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
        public DateTime? GuncellemeTarihi { get; set; }
        public int? GuncelleyenKullanici { get; set; }
    }

    public class FaturaIptalLog
    {
        [Key]
        public int Id { get; set; }
        public int? FaturaTipi { get; set; }
        public string? FaturaTuru { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public string? FaturaNo { get; set; }
        public DateTime IptalTarihi { get; set; }
        public string? IptalEden { get; set; }
    }

    public class FaturalarTemp
    {
        [Key]
        public int Id { get; set; }
        public string? FisTipi { get; set; }
        public int TrCode { get; set; }
        public string? FaturaTuru { get; set; }
        public string? IhracatTasimaKodu { get; set; }
        public int? EvrakTipi { get; set; }
        public string? IslemTipi { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime? SevkTarihi { get; set; }
        public string? FisNo { get; set; }
        public string? BelgeNo { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? OzelKod3 { get; set; }
        public int CariId { get; set; }
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
        public int? DovizTuru { get; set; }
        public decimal? DovizKuru { get; set; }
        public string? Personel { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Aciklama2 { get; set; }
        public string? Aciklama3 { get; set; }
        public string? Aciklama4 { get; set; }
        public string? Aciklama5 { get; set; }
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
    }
}
