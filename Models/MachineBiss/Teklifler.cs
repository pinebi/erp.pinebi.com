using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class Teklifler
    {
        public int Id { get; set; }
        public string? FisTipi { get; set; }
        public int TrCode { get; set; }
        [NotMapped]
        public string? FaturaTuru { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime? SevkTarihi { get; set; }
        public string? FisNo { get; set; }
        public string? BelgeNo { get; set; }
        public string? ProjeNo { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? OzelKod3 { get; set; }
        public int CariId { get; set; }
        public int? FaturaTipi { get; set; }
        public int? OdemeTipi { get; set; }
        public DateTime? VadeTarihi { get; set; }
        public DateTime? TemlikTarihi { get; set; }
        public DateTime? OpsiyonTarihi { get; set; }
        public string? SiparisNo { get; set; }
        public DateTime? SiparisTarihi { get; set; }
        public int? IsyeriNo { get; set; }
        public int? AmbarNo { get; set; }
        public string? DovizKodu { get; set; }
        public string? Personel { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Aciklama2 { get; set; }
        public string? Aciklama3 { get; set; }
        public string? Aciklama4 { get; set; }
        public string? Aciklama5 { get; set; }
        public double? Tutar { get; set; }
        public double? ToplamIndirim { get; set; }
        public double? KdvMatrahi { get; set; }
        public double? KdvTutari { get; set; }
        public double? TevkifatMuafiyeti { get; set; }
        public double? ToplamTutar { get; set; }
        public double? OdenecekTutar { get; set; }

        public double? TLTutar { get; set; }
        public double? TLToplamIndirim { get; set; }
        public double? TLKdvMatrahi { get; set; }
        public double? TLKdvTutari { get; set; }
        public double? TLTevkifatMuafiyeti { get; set; }
        public double? TLToplamTutar { get; set; }
        public double? TLOdenecekTutar { get; set; }

        public int? FaturaTuruId { get; set; }
        public double? DovizKuru { get; set; }
        public string? Guid { get; set; }
        public int? Status { get; set; }
        public string? GibGonderimDurumu { get; set; }
        public string? GibDurumKodu { get; set; }
        public string? InvoiceStatus { get; set; }
        public string? InvoiceStatusDescription { get; set; }
        [Column("EnvelopeStatus")]
        public string? ZarfDurumu { get; set; }
        [Column("EnvelopeStatusDescription")]
        public string? ZarfDurumAciklama { get; set; }
        public bool? Iptal { get; set; }
        public int? GelenFaturaId { get; set; }
        public string? ProformaNo { get; set; }
        public string? SatinalmaSorumlusu { get; set; }
        public string? BolumSatinAlmaSorumlusu { get; set; }
        public int? SevkAdresId { get; set; }
        public string? FaturaDurumu { get; set; }
    }

    public class TekliflerView
    {
        public int Id { get; set; }
        [NotMapped]
        public bool Sec { get; set; }
        public string? FisTipi { get; set; }
        [Column("FisTipiAciklama")]
        public string? Fis { get; set; }
        public int TrCode { get; set; }
        public string? FaturaTuru { get; set; }
        public DateTime Tarih { get; set; }
        public TimeSpan? Saat { get; set; }
        public DateTime? SevkTarihi { get; set; }
        public string? FisNo { get; set; }
        public string? BelgeNo { get; set; }
        public string? ProjeNo { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? OzelKod3 { get; set; }
        public int CariId { get; set; }
        public string? CariKodu { get; set; }
        public string? Unvani { get; set; }
        public string? Yetkili1 { get; set; }
        public string? Telefon1 { get; set; }
        public int? FaturaTipi { get; set; }
        public int? OdemeTipi { get; set; }
        public DateTime? VadeTarihi { get; set; }
        public DateTime? TemlikTarihi { get; set; }
        public DateTime? OpsiyonTarihi { get; set; }
        public string? SiparisNo { get; set; }
        public DateTime? SiparisTarihi { get; set; }
        public int? IsyeriNo { get; set; }
        public int? AmbarNo { get; set; }
        public string? DovizKodu { get; set; }
        public string? DovizCinsi { get; set; }
        public double? DovizKuru { get; set; }
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

        public double? Tutar { get; set; }
        public double? ToplamIndirim { get; set; }
        public double? KdvMatrahi { get; set; }
        public double? KdvTutari { get; set; }
        public double? TevkifatMuafiyeti { get; set; }
        public double? ToplamTutar { get; set; }
        public double? OdenecekTutar { get; set; }

        public double? TLTutar { get; set; }
        public double? TLToplamIndirim { get; set; }
        public double? TLKdvMatrahi { get; set; }
        public double? TLKdvTutari { get; set; }
        public double? TLTevkifatMuafiyeti { get; set; }
        public double? TLToplamTutar { get; set; }
        public double? TLOdenecekTutar { get; set; }

        public int? FaturaTuruId { get; set; }
        public string? Guid { get; set; }
        public int? Status { get; set; }
        public string? GibGonderimDurumu { get; set; }
        public string? GibDurumKodu { get; set; }
        public string? InvoiceStatus { get; set; }
        public string? InvoiceStatusDescription { get; set; }
        public bool? Iptal { get; set; }
        public int? GelenFaturaId { get; set; }
        public string? ProformaNo { get; set; }
        public string? SatinalmaSorumlusu { get; set; }
        public string? BolumSatinAlmaSorumlusu { get; set; }
        public int? SevkAdresId { get; set; }
        [Column("SevkBaslik")]
        public string? SevkiyatBaslik { get; set; }
        [Column("SevkAdresi")]
        public string? SevkiyatAdresi { get; set; }
        [Column("SevkTelefon")]
        public string? SevkiyatTelefon { get; set; }
        [Column("SevkPostaKodu")]
        public string? SevkiyatPostaKodu { get; set; }
        [Column("SevkUlke")]
        public string? SevkiyatUlke { get; set; }
        [Column("SevkSehir")]
        public string? SevkiyatSehir { get; set; }
        [Column("SevkIlce")]
        public string? SevkiyatIlce { get; set; }
        public string? FaturaDurumu { get; set; }
    }

    public class TeklifSatirlar
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int TrCode { get; set; }
        public int? FaturaId { get; set; }
        public int? IrsaliyeId { get; set; }
        public int? FaturaTipi { get; set; }
        public int? CariId { get; set; }
        public int? StokId { get; set; }
        public string? Barkod { get; set; }
        public string? StokKodu { get; set; }
        public string? StokCinsi { get; set; }
        public string? Aciklama { get; set; }
        public int? IsyeriNo { get; set; }
        public int? AmbarNo { get; set; }
        public string? Birim { get; set; }
        public double Miktar { get; set; }
        public double? OnaylananMiktar { get; set; }
        public string? DovizKodu { get; set; }
        public double Fiyat { get; set; }
        public double Indirim1 { get; set; }
        public double Indirim2 { get; set; }
        public double Indirim3 { get; set; }
        public double IndirimTutari { get; set; }
        public double Tutar { get; set; }
        public double Kdv { get; set; }
        public double KdvMatrahi { get; set; }
        public double KdvTutari { get; set; }
        public double NetTutar { get; set; }
        public string? KdvMuafiyetSebebi { get; set; }
        public Int16? TevkifatId { get; set; }
        public string? TevkifatKodu { get; set; }
        public double? TevkifatCarpan { get; set; }
        public double? TevkifatBolen { get; set; }
        public double? TevkifatMuafiyeti { get; set; }
        public bool? Iptal { get; set; }
        [NotMapped]
        public string? ParaSimgesi { get; set; }
        [NotMapped]
        public int? Yenile { get; set; } = 0;
    }

    public class TeklifSatirlarView
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int TrCode { get; set; }
        public int? FaturaId { get; set; }
        public int? IrsaliyeId { get; set; }
        public int FaturaTipi { get; set; }
        public int CariId { get; set; }
        public string? Aciklama { get; set; }
        public int StokId { get; set; }
        public string? Barkod { get; set; }
        public string? StokKodu { get; set; }
        public string? StokCinsi { get; set; }
        public int? IsyeriNo { get; set; }
        public int? AmbarNo { get; set; }
        public string? Birim { get; set; }
        public double Miktar { get; set; }
        public double? OnaylananMiktar { get; set; }
        public string? DovizKodu { get; set; }
        public double Fiyat { get; set; }
        public double Indirim1 { get; set; }
        public double Indirim2 { get; set; }
        public double Indirim3 { get; set; }
        public double IndirimTutari { get; set; }
        public double Tutar { get; set; }
        public double Kdv { get; set; }
        public double KdvMatrahi { get; set; }
        public double KdvTutari { get; set; }
        public double NetTutar { get; set; }
        public string? KdvMuafiyetSebebi { get; set; }
        public Int16 TevkifatId { get; set; }
        public string? TevkifatKodu { get; set; }
        public double? TevkifatCarpan { get; set; }
        public double? TevkifatBolen { get; set; }
        public double? TevkifatMuafiyeti { get; set; }
        public bool? Iptal { get; set; }
        [NotMapped]
        public string? ParaSimgesi { get; set; }
        [NotMapped]
        public int? Yenile { get; set; } = 0;
    }
}
