using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class OdemePlani
    {
        public int Id { get; set; }
        public string? IslemTipi { get; set; }
        public string? FisNo { get; set; }
        public string? BelgeNo { get; set; }
        public int? CariId { get; set; }
        public string? CariUnvan { get; set; }
        public string? OdemeTipi { get; set; }
        public double? ToplamTutar { get; set; }
        public double? OnOdemeTutari { get; set; }
        public double? KalanTutar { get; set; }
        public DateTime? OnOdemeTarihi { get; set; }
        public int? TaksitSayisi { get; set; }
        public bool? Iptal { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string? OlusturanKullanici { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenKullanici { get; set; }
    }

    public class OdemePlaniDetay
    {
        public int Id { get; set; }
        public int? IslemId { get; set; }
        public DateTime? Tarih { get; set; }
        public double? TaksitTutari { get; set; }
        public string? Durumu { get; set; }
    }

    public class OdemePlaniDetayView
    {
        public int Id { get; set; }
        public int? IslemId { get; set; }
        public string? IslemTipi { get; set; }
        public string? CariUnvan { get; set; }
        public int? SiraNo { get; set; }
        public DateTime? Tarih { get; set; }
        public decimal? TaksitTutari { get; set; }
        public string? Durumu { get; set; }
    }

    public class OdemePlaniDetayHatirlatma
    {
        public int Id { get; set; }
        public int? IslemId { get; set; }
        public string? IslemTipi { get; set; }
        public string? CariUnvan { get; set; }
        public double SiraNo { get; set; }
        public DateTime? Tarih { get; set; }
        public decimal? TaksitTutari { get; set; }
        public string? Durumu { get; set; }
    }
}
