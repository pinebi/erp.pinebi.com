using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class Projeler
    {
        public int Id { get; set; }
        public DateTime? Tarih { get; set; } 
        public string? FirmaKodu { get; set; }
        [Column("FirmaUnvani")]
        public string? FirmaUnvani { get; set; } 
        public string? ProjeKodu { get; set; }
        [Column("ProjeAdi")]
        public string? ProjeAdi { get; set; }
        [Column("ProjeBaslangicTarihi")]
        public DateTime? ProjeBaslangicTarihi { get; set; }
        [Column("ProjeBitisTarihi")]
        public DateTime? ProjeBitisTarihi { get; set; }
        public string? ProjeyiOlusturan { get; set; }
        public bool? Aktif { get; set; }
    }

    public class SatinAlmaTalepleri
    {
        public int Id { get; set; }
        public DateTime? Tarih { get; set; }
        public int? ProformaId { get; set; }
        public string? FisNo { get; set; }
        public string? BelgeNo { get; set; }
        public int? ProjeId { get; set; }
        public string? ProjeKodu { get; set; }
        [Column("ProjeAdi")]
        public string? ProjeAdi { get; set; }
        [Column("Aciklama")]
        public string? Aciklama { get; set; }
        public string? TalepEden { get; set; }
    }

    public class SatinAlmaTalepleriSatirlar
    {
        public int Id { get; set; }
        public int? TalepId { get; set; }
        public int? StokId { get; set; }
        [NotMapped]
        public bool? Sec { get; set; } = false;
        public string? MalzemeKodu { get; set; }
        [Column("MalzemeAdi")]
        public string? MalzemeAdi { get; set; }
        public string? Birim { get; set; }
        public double? Miktar { get; set; }
        public double? TalepEdilenMiktar { get; set; } = 0;
        public string? Durumu { get; set; }
        public int? TeklifId { get; set; }
    }

    public class SatinAlmaTalepleriSatirlarView
    {
        public int Id { get; set; }
        public int? TalepId { get; set; }
        [NotMapped]
        public bool? Sec { get; set; } = false;

        public DateTime? Tarih { get; set; }
        public int? ProformaId { get; set; }
        public string? FisNo { get; set; }
        public string? BelgeNo { get; set; }
        [Column("FirmaUnvani")]
        public string? FirmaUnvani { get; set; }
        public int? ProjeId { get; set; }
        public string? ProjeKodu { get; set; }
        [Column("ProjeAdi")]
        public string? ProjeAdi { get; set; }
        [Column("Aciklama")]
        public string? Aciklama { get; set; }
        public string? TalepEden { get; set; }
        public int? StokId { get; set; }
       
        public string? MalzemeKodu { get; set; }
        [Column("MalzemeAdi")]
        public string? MalzemeAdi { get; set; }
        public string? Birim { get; set; }
        public double? Miktar { get; set; }
        public double? TalepEdilenMiktar { get; set; } = 0;
        public string? Durumu { get; set; }
        public int? TeklifId { get; set; }
    }
}
