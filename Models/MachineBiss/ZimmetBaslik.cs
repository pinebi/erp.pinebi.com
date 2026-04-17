using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class ZimmetListesi
    {
        public int Id { get; set; }
        [NotMapped]
        public bool Sec { get; set; }
        [Column("DonanimTuru")]
        public string? DonanimTuru { get; set; } 
    }

    public class ZimmetBaslik
    {
        public int Id { get; set; }
        public string? DokumanNo { get; set; }
        public DateTime? Tarih { get; set; }
        [Column("DuzenlemeTarihi")]
        public DateTime? DuzenlemeTarihi { get; set; }
        public int? PersonelKodu { get; set; }
        [Column("PersonelAdi")]
        public string? PersonelAdi { get; set; }
        public string? PersonelTckNo { get; set; }
        [Column("PersonelGorevi")]
        public string? PersonelGorevi { get; set; }
        public string? TeslimEden { get; set; }
        [Column("TeslimEdenGorevi")]
        public string? TeslimEdenGorevi { get; set; }
        [Column("Aciklama")]
        public string? Aciklama { get; set; }
        public bool? Iptal { get; set; }
    }

    public class ZimmetSatir
    {
        public int Id { get; set; }
        public int? ZimmetId { get; set; }
        public string? DonanimAdi { get; set; }
        public string? MarkaModel { get; set; } = "";
        public string? SeriNo { get; set; } = "";
        public int? Miktar { get; set; }
    }
}
