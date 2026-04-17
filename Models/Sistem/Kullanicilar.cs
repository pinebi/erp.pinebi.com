using System.ComponentModel.DataAnnotations;

namespace MACHINEBISS_Web.Models.Sistem
{
    public class Kullanicilar
    {
        [Key]
        public int Id { get; set; }
        public int? FirmaId { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? SifreHash { get; set; }
        public string? AdSoyad { get; set; }
        public string? Email { get; set; }
        public string? Telefon { get; set; }
        public string? Rol { get; set; }
        public string? Gorevi { get; set; }
        public bool? Aktif { get; set; }
        public DateTime? SonGirisTarihi { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
