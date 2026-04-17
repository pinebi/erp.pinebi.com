using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class KasaHareketleri
    {
        public int Id { get; set; }
        public int? FisId { get; set; }
        public DateTime Tarih { get; set; }
        public string? FisNo { get; set; }
        public int KasaId { get; set; }
        public int IslemId { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Aciklama2 { get; set; }
        public decimal Tutar { get; set; }
        public string? DovizId { get; set; }
        public bool? Iptal { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string? OlusturanKullanici { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenKullanici { get; set; }
    }

    public class KasaHareketleriView
    {
        public int Id { get; set; }
        public int? FisId { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Saat { get; set; }
        public string? FisNo { get; set; }
        public int KasaId { get; set; }
        public int IslemId { get; set; }
        public string? IslemAciklama { get; set; }
        [Column("Aciklama1")]
        public string? Aciklama1 { get; set; }
        [Column("Aciklama2")]
        public string? Aciklama2 { get; set; }
        [Column("KasaGirisi")]
        public double KasaGirisi { get; set; }
        [Column("KasaCikisi")]
        public double KasaCikisi { get; set; }
        public string? DovizId { get; set; }
        [Column("Doviz")]
        public string? Doviz { get; set; }
        public bool? Iptal { get; set; }
    }
}
