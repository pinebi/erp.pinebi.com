using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class GelenFaturalar
    {
        public int Id { get; set; }

        public int? RequestNumber { get; set; }

        public int? ReferenceNo { get; set; }

        public DateTime? Tarih { get; set; }

        public int? ProfileID { get; set; }

        public int? FaturaTipi { get; set; }

        public string? FaturaNo { get; set; }

        [Column("Tedarikci")]
        public string? Tedarikci { get; set; }

        public string? VergiDairesi { get; set; }

        public string? VergiNo { get; set; }

        public string? PostaKutusu { get; set; }

        public string? Adres { get; set; }

        [Column("Ilce")]
        public string Ilce { get; set; }

        [Column("Sehir")]
        public string Sehir { get; set; }

        [Column("Ulke")]
        public string Ulke { get; set; }

        [Column("Doviz")]
        public string? Doviz { get; set; }

        public string? FiyatlandirilanDovizKodu { get; set; }

        public string? OdemeYapilacakDovizKodu { get; set; }

        [Column("KdvMatrahi")]
        public double? KdvMatrahi { get; set; }

        [Column("ToplamIskonto")]
        public double? ToplamIskonto { get; set; }

        [Column("KdvTutari")]
        public double? KdvTutari { get; set; }

        public double? ToplamTutar { get; set; }

        public string? ETTN { get; set; }

        public string? ReceiverAlias { get; set; }

        public string? SenderAlias { get; set; }

        public string? ResponseCode { get; set; }

        public string? Durumu { get; set; }

        public string? FatUrl { get; set; }

        public string? TevkifatKodu { get; set; }

        public string? TevkifatAciklama { get; set; }

        public decimal TevkifatYuzdesi { get; set; }
    }

    public class GelenFaturalarView
    {
        public int Id { get; set; }

        [NotMapped]
        public bool Sec { get; set; }

        public int? RequestNumber { get; set; }

        public int? ReferenceNo { get; set; }

        public string? FaturaTipi { get; set; }

        public string? FaturaTuru { get; set; }

        public DateTime? FaturaTarihi { get; set; }

        public DateTime? Tarih { get; set; }

        public string? FaturaNo { get; set; }

        [Column("Tedarikci")]
        public string? Tedarikci { get; set; }

        public string? VergiDairesi { get; set; }

        public string? VergiNo { get; set; }

        public string? Adres { get; set; }

        [Column("Ilce")]
        public string Ilce { get; set; }

        [Column("Sehir")]
        public string Sehir { get; set; }

        [Column("Ulke")]
        public string Ulke { get; set; }

        public string? PostaKutusu { get; set; }

        [Column("Doviz")]
        public string? Doviz { get; set; }

        public string? FiyatlandirilanDovizKodu { get; set; }

        public string? OdemeYapilacakDovizKodu { get; set; }

        [Column("KdvMatrahi")]
        public double? KdvMatrahi { get; set; }

        [Column("ToplamIskonto")]
        public double? ToplamIskonto { get; set; }

        [Column("KdvTutari")]
        public double? KdvTutari { get; set; }

        public double? ToplamTutar { get; set; }

        public string? TevkifatKodu { get; set; }

        public string? TevkifatAciklama { get; set; }

        public decimal TevkifatYuzdesi { get; set; }

        public string? ETTN { get; set; }

        public string? ReceiverAlias { get; set; }

        public string? SenderAlias { get; set; }

        public string? ResponseCode { get; set; }

        public string? Durumu { get; set; }

        public string? FatUrl { get; set; }

        [Column("KayitDurumu")]
        public string? KayitDurumu { get; set; }
    }

    public class GelenFaturalarSatirlar
    {
        public int Id { get; set; }

        public int FatId { get; set; }

        public string? MalzemeKodu { get; set; }

        [Column("MalzemeAdi")]
        public string? MalzemeAdi { get; set; }

        public decimal Miktar { get; set; }

        public string? BirimKodu { get; set; }

        public decimal Fiyat { get; set; }

        public decimal Tutar { get; set; }

        [Column("Indirim1")]
        public decimal Indirim1 { get; set; }

        [Column("Indirim2")]
        public decimal Indirim2 { get; set; }

        [Column("Indirim3")]
        public decimal Indirim3 { get; set; }

        [Column("Artirim")]
        public decimal Artirim { get; set; }

        [Column("IndirimTutari")]
        public decimal IndirimTutari { get; set; }

        [Column("KdvMatrahi")]
        public decimal KdvMatrahi { get; set; }

        [Column("KdvOrani")]
        public string? KdvOrani { get; set; }

        [Column("KdvTutari")]
        public decimal KdvTutari { get; set; }

        [Column("MalHizmetTutari")]
        public decimal MalHizmetTutari { get; set; }

        public string? ParaBirimi { get; set; }

        public string? VergiMuafiyetKodu { get; set; }

        public string? VergiMuafiyetNedeni { get; set; }

        public string? TevkifatKodu { get; set; }

        public string? TevkifatAciklama { get; set; }

        public decimal TevkifatYuzdesi { get; set; }
    }
}
