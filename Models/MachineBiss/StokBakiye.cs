using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class StokBakiye
    {
        public int Id { get; set; }
        public string? Barkod { get; set; }
        public string? StokKodu { get; set; }
        [Column("StokCinsi")]
        public string? StokAdi { get; set; }
        public string? Birim { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? OzelKod3 { get; set; }
        public string? OzelKod4 { get; set; }
        public string? OzelKod5 { get; set; }
        public double? GirenMiktar { get; set; }
        [Column("CikanMiktar")]
        public double? CikanMiktar { get; set; }
        public double? StokBakiyesi { get; set; }
    }

    public class StokMinimumSeviye
    {
        public int Id { get; set; }
        public string? Barkod { get; set; }
        public string? StokKodu { get; set; }
        [Column("StokCinsi")]
        public string? StokAdi { get; set; }
        public string? Birim { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? OzelKod3 { get; set; }
        public string? OzelKod4 { get; set; }
        public string? OzelKod5 { get; set; }
        public double? GirenMiktar { get; set; }
        [Column("CikanMiktar")]
        public double? CikanMiktar { get; set; }
        public double? StokBakiyesi { get; set; }
        public double? MinimumSeviye { get; set; }
    }

    public class MalzemeHareketleri
    {
        public int Id { get; set; }
        public int? TrCode { get; set; }
        public int? FaturaId { get; set; }
        public DateTime? Tarih { get; set; }
        [Column("FisNo")]
        public string? FaturaNo { get; set; }
        [Column("Unvani")]
        public string Unvan { get; set; }
        public int? StokId { get; set; }
        public string? StokKodu { get; set; }
        [Column("StokCinsi")]
        public string? StokAdi { get; set; }
        public string? Birim { get; set; }
        public double? Miktar { get; set; }
        public double? Fiyat { get; set; }
        public double? Tutar { get; set; }
        [Column("IndirimTutari")]
        public double? IndirimTutari { get; set; }
        [Column("KdvTutari")]
        public double? KdvTutari { get; set; }
        public double? NetTutar { get; set; }
    }
}
