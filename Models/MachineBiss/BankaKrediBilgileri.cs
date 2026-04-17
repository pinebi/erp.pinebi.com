using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class BankaKrediBilgileri
    {
        public int Id { get; set; }
        public DateTime? Tarih { get; set; }
        public string? KrediTuru { get; set; }
        public int? BankaId { get; set; }
        [Column("BankaAdi")]
        public string? BankaAdi { get; set; }
        [Column("KrediTutari")]
        public double? KrediTutari { get; set; }
        public int? KrediVadesi { get; set; }
        [Column("KrediFaizTutari")]
        public double? KrediFaizTutari { get; set; }
        [Column("GeriOdenecekTutar")]
        public double? GeriOdenecekTutar { get; set; }
        [Column("IlkOdemeTarihi")]
        public DateTime? IlkOdemeTarihi { get; set; }
        [Column("AylikOdemeTutari")]
        public double? AylikOdemeTutari { get; set; }
        [Column("Kapandi")]
        public bool? Kapandi { get; set; }
        public bool? Iptal { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string? OlusturanKullanici { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenKullanici { get; set; }
    }

    public class BankaKrediBilgileriDetay
    {
        public int Id { get; set; }
        [Column("Sira")]
        public string? Sira { get; set; }
        public DateTime? Tarih { get; set; }
        public int? IslemId { get; set; }
        [Column("BankaAdi")]
        public string? BankaAdi { get; set; }
        [Column("Yil")]
        public int? Yil { get; set; }
        public string? Ay { get; set; }
        [Column("AyAdi")]
        public string? AyAdi { get; set; }
        public double? Tutar { get; set; }
        [Column("Odendi")]
        public bool? Odendi { get; set; }
        public int? Okundu { get; set; }
    }
}
