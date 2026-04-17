using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class FatIrsSatirlar
    {
        [Key]
        public int Id { get; set; }
        public int? FaturaId { get; set; }
        public int? SiraNo { get; set; }
        public int? StokId { get; set; }
        public string? StokKodu { get; set; }
        public string? StokCinsi { get; set; }
        public string? Barkod { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Aciklama2 { get; set; }
        public string? Aciklama3 { get; set; }
        public string? Aciklama4 { get; set; }
        public decimal? Miktar { get; set; }
        public string? Birim { get; set; }
        public decimal? Fiyat { get; set; }
        public decimal? KdvOrani { get; set; }
        public decimal? Tutar { get; set; }
        public decimal? IskontoOrani { get; set; }
        public decimal? IskontoTutari { get; set; }
        public decimal? KdvMatrahi { get; set; }
        public decimal? KdvTutari { get; set; }
        public decimal? NetTutar { get; set; }
        public string? TevkifatKodu { get; set; }
        public string? KdvMuafiyetSebebi { get; set; }
        public string? GTipKodu { get; set; }
        public bool? Iptal { get; set; }

        [NotMapped]
        public string? ParaSimgesi { get; set; }
        [NotMapped]
        public int? Yenile { get; set; } = 0;
    }

    public class FatIrsSatirlarView
    {
        [Key]
        public int Id { get; set; }
        public int? FaturaId { get; set; }
        public int? SiraNo { get; set; }
        public int? StokId { get; set; }
        public string? StokKodu { get; set; }
        public string? StokCinsi { get; set; }
        public string? Barkod { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Aciklama2 { get; set; }
        public string? Aciklama3 { get; set; }
        public string? Aciklama4 { get; set; }
        public decimal? Miktar { get; set; }
        public string? Birim { get; set; }
        public decimal? Fiyat { get; set; }
        public decimal? KdvOrani { get; set; }
        public decimal? Tutar { get; set; }
        public decimal? IskontoOrani { get; set; }
        public decimal? IskontoTutari { get; set; }
        public decimal? KdvMatrahi { get; set; }
        public decimal? KdvTutari { get; set; }
        public decimal? NetTutar { get; set; }
        public string? TevkifatKodu { get; set; }
        public string? KdvMuafiyetSebebi { get; set; }
        public string? GTipKodu { get; set; }
        public bool? Iptal { get; set; }

        [NotMapped]
        public string? ParaSimgesi { get; set; }
        [NotMapped]
        public int? Yenile { get; set; } = 0;
    }
}
