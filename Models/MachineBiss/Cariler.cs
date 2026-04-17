using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    [Table("CariKart")]
    public class Cariler
    {
        public int Id { get; set; }
        public bool? EFatura { get; set; }
        public bool? SahisSirketi { get; set; }
        public bool? YurtDisi { get; set; }
        public string? CariGrubu { get; set; }
        public string? CariKodu { get; set; }
        public string? Unvani { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? TckNo { get; set; }
        public string? Yetkili1 { get; set; }
        public string? Yetkili2 { get; set; }
        public int? VdSehirId { get; set; }
        public string? VdSehir { get; set; }
        public string? VdKodu { get; set; }
        public string? Vd { get; set; }
        public string? Vn { get; set; }
        public string? GsmNo { get; set; }
        public string? Telefon1 { get; set; }
        public string? Telefon2 { get; set; }
        public string? Faks { get; set; }
        public string? Email { get; set; }
        public string? Adres1 { get; set; }
        public string? Adres2 { get; set; }
        public string? PostaKodu { get; set; }
        public int? UlkeId { get; set; }
        public string? Ulke { get; set; }
        public int? IlceId { get; set; }
        public string? Ilce { get; set; }
        public int? SehirId { get; set; }
        public string? Sehir { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? OzelKod3 { get; set; }
        public string? OzelKod4 { get; set; }
        public string? OzelKod5 { get; set; }
        public string? EFaturaUrnMail { get; set; }
        public string? EIrsaliyeUrnMail { get; set; }
        public int? FiyatGrubu { get; set; } = 1;
        public bool? Aktif { get; set; }
    }

    public class CarikartView
    {
        public int Id { get; set; }
        public bool EFatura { get; set; }
        public bool? SahisSirketi { get; set; }
        public string? CariGrubu { get; set; }
        public string? CariKodu { get; set; }
        public string? Unvani { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? TckNo { get; set; }
        public string? Yetkili1 { get; set; }
        public string? Yetkili2 { get; set; }
        public int VdSehirId { get; set; }
        public string? VdSehir { get; set; }
        public string? VdKodu { get; set; }
        public string? Vd { get; set; }
        public string? Vn { get; set; }
        public string? GsmNo { get; set; }
        public string? Telefon1 { get; set; }
        public string? Telefon2 { get; set; }
        public string? Faks { get; set; }
        public string? Email { get; set; }
        public string? Adres1 { get; set; }
        public string? Adres2 { get; set; }
        public string? PostaKodu { get; set; }
        public int? UlkeId { get; set; }
        public string? Ulke { get; set; }
        public int IlceId { get; set; }
        public string? Ilce { get; set; }
        public int SehirId { get; set; }
        public string? Sehir { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? OzelKod3 { get; set; }
        public string? OzelKod4 { get; set; }
        public string? OzelKod5 { get; set; }
        public string? EFaturaUrnMail { get; set; }
        public string? EIrsaliyeUrnMail { get; set; }
        public bool Aktif { get; set; }
    }

    public class CariGruplar
    {
        public int Id { get; set; }
        public string? CariGrubu { get; set; }
    }

    public class CariCalisanlar
    {
        public int Id { get; set; }
        public int CariId { get; set; }
        public string? AdSoyad { get; set; }
        public string? Birim { get; set; }
        public string? Telefon { get; set; }
        public string? EPosta { get; set; }
    }

    public class CariSevkAdresleri
    {
        public int Id { get; set; }
        [Column("SevkBaslik")]
        public string? Baslik { get; set; }
        public string? Telefon { get; set; }
        public int? CariId { get; set; }
        public string? Adres { get; set; }
        public string? PostaKodu { get; set; }
        public int? UlkeId { get; set; }
        public int? SehirId { get; set; }
        public int? IlceId { get; set; }
    }

    public class CariSevkAdresleriView
    {
        public int Id { get; set; }
        [Column("SevkBaslik")]
        public string? Baslik { get; set; }
        public string? Telefon { get; set; }
        public int? CariId { get; set; }
        public string? Adres { get; set; }
        public string? PostaKodu { get; set; }
        public int? UlkeId { get; set; }
        [Column("Ulke")]
        public string? Ulke { get; set; }
        public int? SehirId { get; set; }
        [Column("SehirAdi")]
        public string? Sehir { get; set; }
        public int? IlceId { get; set; }
        [Column("IlceAdi")]
        public string? Ilce { get; set; }
    }

    public class CariGorusmeler
    {
        public int Id { get; set; }
        public int? CariId { get; set; }
        public DateTime? GorusmeTarihi { get; set; }
        public string? GorusulenKisi { get; set; }
        public string? Aciklama { get; set; }
    }
    /*
    public class CariSevkAdresleri
    {
        public int Id { get; set; }
        public string? Telefon { get; set; }
        public int? CariId { get; set; }
        public string? Adres { get; set; }
        public string? PostaKodu { get; set; }
        public int? UlkeId { get; set; }
        public BlockBiss.Ulkeler Ulkeler { get; set; }
        public int? SehirId { get; set; }
        public BlockBiss.Sehirler Sehirler { get; set; }
        public int? IlceId { get; set; }
        public BlockBiss.Ilceler Ilceler { get; set; }
    }
    */
}
