using System.ComponentModel.DataAnnotations;

namespace MACHINEBISS_Web.Models.Sistem
{
    public class Firmalar
    {
        [Key]
        public int Id { get; set; }
        public string? FirmaKodu { get; set; }
        public string? FirmaUnvani { get; set; }
        public string? VergiNo { get; set; }
        public string? VergiDairesi { get; set; }
        public string? Telefon { get; set; }
        public string? Email { get; set; }
        public string? Adres { get; set; }
        public string? Sehir { get; set; }
        public string? Ilce { get; set; }
        public string? PostaKodu { get; set; }
        public string? WebSitesi { get; set; }
        public string? LogoUrl { get; set; }
        public bool? Aktif { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
