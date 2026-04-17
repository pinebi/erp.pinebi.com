using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.BlockBiss
{
    public class LoginTablo
    {
        public int Id { get; set; }
        public int SirketKodu { get; set; }
        public string? SirketAdi { get; set; }
        public bool? KullaniciId { get; set; }
        public string? ErpKullaniciAdi { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? Sifre { get; set; }
        public string? ServerName { get; set; }
        public string? Database { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public int Port { get; set; }

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
}
