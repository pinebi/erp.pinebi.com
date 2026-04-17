using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.BlockBiss
{
    public class SirketBilgileri
    {
        public int Id { get; set; }
        public int? SirketNo { get; set; }
        public string? FirmaUnvani { get; set; }
        public string? Adres { get; set; }
        public int? IlceId { get; set; }
        public string? Ilce { get; set; }
        public int? SehirId { get; set; }
        public string? Sehir { get; set; }
        public string? Ulke { get; set; }
        public int? UlkeId { get; set; }
        public string? VdKodu { get; set; }
        public string? Vd { get; set; }
        public string? Vn { get; set; }
        public string? MersisNo { get; set; }
        public string? TicaretSicilNo { get; set; }
        public string? Telefon { get; set; }
        public string? Gsm { get; set; }
        public string? Faks { get; set; }
        public string? Web { get; set; }
        public string? EPosta { get; set; }
        public bool EFaturaMukellefi { get; set; }
        public bool EIrsaliyeMukellefi { get; set; }
        public string? EFaturaGelenUrnMail { get; set; }
        public string? EFaturaGidenUrnMail { get; set; }
        public string? EArsivUrnMail { get; set; }
        public string? EIrsaliyeUrnMail { get; set; }
        public string? ApiInstitutionId { get; set; }
        public string? ApiKullaniciAdi { get; set; }
        public string? ApiKullaniciSifresi { get; set; }
    }

    public class SirketBelgeleri
    {
        public int Id { get; set; }
        public int? SirketNo { get; set; }
        public byte[] FirmaLogosu { get; set; }
        public byte[] ImzaSirkusu { get; set; }
        public byte[] FaaliyetBelgesi { get; set; }
        public byte[] TicaretSicilGazetesi { get; set; }
        public byte[] VergiLevhasi { get; set; }
        public byte[] ImzaKasesi { get; set; }
    }
}
