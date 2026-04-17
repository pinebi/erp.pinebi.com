using System.ComponentModel.DataAnnotations;

namespace MACHINEBISS_Web.Models.Sistem
{
    public class KullaniciYetkileri
    {
        [Key]
        public int Id { get; set; }
        public int? KullaniciId { get; set; }
        public bool? SirketProfili { get; set; }
        public bool? FirmaBilgileri { get; set; }
        public bool? EnvanterYonetimi { get; set; }
        public bool? PersonelYonetimi { get; set; }
        public bool? MuhasebeIslemleri { get; set; }
        public bool? CariIslemler { get; set; }
        public bool? SatisIslemleri { get; set; }
        public bool? SatinalmaIslemleri { get; set; }
        public bool? EFaturaIslemleri { get; set; }
        public bool? EFaturaGonder { get; set; }
        public bool? StokYonetimi { get; set; }
        public bool? RaporGorme { get; set; }
        public bool? KullaniciTanimlama { get; set; }
        public bool? AyarlarDuzenleme { get; set; }
    }
}
