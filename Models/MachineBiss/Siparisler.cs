using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class Siparisler
    {
        public int Id { get; set; }
        public int TrCode { get; set; }
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
        public DateTime? VadeTarihi { get; set; }
        public DateTime? TemlikTarihi { get; set; }
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
        public double? TevkifatMuafiyeti { get; set; }
        public double? KdvTutari { get; set; }
        public double? ToplamTutar { get; set; }
        public double? OdenecekTutar { get; set; }
        [NotMapped]
        public int? FaturaTuruId { get; set; }
        public double? DovizKuru { get; set; }
        public double? UsdKur { get; set; }
        public double? EuroKur { get; set; }
        public string? Guid { get; set; }
        [NotMapped]
        public string? GibGonderimDurumu { get; set; }
        [NotMapped]
        public string? GibDurumKodu { get; set; }
        public bool? Iptal { get; set; }
    }
}
