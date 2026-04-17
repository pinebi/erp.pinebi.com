using System.ComponentModel.DataAnnotations;

namespace MACHINEBISS_Web.Models.Sistem
{
    public class Lisanslar
    {
        [Key]
        public int Id { get; set; }
        public int? FirmaId { get; set; }
        public Guid? LisansKodu { get; set; }
        public string? PlanTipi { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public int? MaxKullanici { get; set; }
        public int? MaxFaturaAylik { get; set; }
        public int? MaxStok { get; set; }
        public int? MaxCari { get; set; }
        public bool? EFaturaAktif { get; set; }
        public bool? EIrsaliyeAktif { get; set; }
        public bool? EArsivAktif { get; set; }
        public decimal? Tutar { get; set; }
        public string? ParaBirimi { get; set; }
        public string? OdemeDurumu { get; set; }
        public bool? OtomatikYenileme { get; set; }
        public string? YenilemePeriyodu { get; set; }
        public bool? Aktif { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
