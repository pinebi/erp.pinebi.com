using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class Personeller
    {
        public int Id { get; set; }
        public byte[] Resim { get; set; }
        public bool? ErpKullanicisi { get; set; }
        public string? AdSoyad { get; set; }
        public string? Unvan { get; set; }
        public string? TCKNo { get; set; }
        public string? SGKNo { get; set; }
        public string? PersonelOzluk { get; set; }
        public string? Telefon { get; set; }
        public string? Email { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public double? OrtaklikPayi { get; set; }
        public string? MaasTuru { get; set; }
        public string? MedeniDurumu { get; set; }
        public string? EsiCalisiyormu { get; set; }
        public Int16? CocukSayisi { get; set; }
        public double? NetMaas { get; set; }
        public double? BrutMaas { get; set; }
        public string? GorevVeSorumluluklar { get; set; }
        public string? KasaKodu { get; set; }
        public bool? IstenAyrildi { get; set; }
        public DateTime? IseGirisTarihi { get; set; }
        public DateTime? IsiBirakmaTarihi { get; set; }
        public string? IsiBirakmaSebebi { get; set; }
        public bool? Iptal { get; set; }

        public bool? SatisTeklifi { get; set; }
        public bool? Planlama { get; set; }
        public bool? SatinalmaTalep { get; set; }
        public bool? SatinalmaEmri { get; set; }
        public bool? ProjeGorme { get; set; }
        public bool? MuhasebeIslemleri { get; set; }
        public bool? CariIslemler { get; set; }
        public bool? SatisIslemleri { get; set; }
        public bool? SatinalmaIslemleri { get; set; }
        public bool? NetworkGorme { get; set; }
        public bool? NetworkKullanimi { get; set; }
        public bool? IlanVerme { get; set; }
        public bool? IzinTalepleriOnay { get; set; }
        public bool? KullaniciTanimlama { get; set; }
        public bool? PersonelIslemleri { get; set; }
        public bool? EFaturaIslemleri { get; set; }
        public bool? EFaturaGonder { get; set; }
        public bool? EFaturaOnay { get; set; }
        public bool? SirketProfili { get; set; }
        public bool? FirmaBilgileri { get; set; }
        public bool? EnvarterYonetimi { get; set; }
        public bool? PersonelYonetimi { get; set; }
        public bool? FirmaAnalizi { get; set; }

    }

    public class PersonelYetkileri
    {
        public int Id { get; set; }
        public bool PersonelID { get; set; }
        public bool Teklif { get; set; }
        public bool Planlama { get; set; }
        public bool SatinAlmaTalep { get; set; }
        public bool SatinAlmaEmri { get; set; }
        public bool ProjeGorme { get; set; }
        public bool Muhasebe { get; set; }
        public bool NetworkGorme { get; set; }
        public bool NetworkKullanim { get; set; }
        public bool IlanVerme { get; set; }
    }
}
