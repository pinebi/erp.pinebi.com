using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class Isyerleri
    {
        public int Id { get; set; }
        public string? IsyeriNo { get; set; }
        public string? IsyeriAdi { get; set; }
    }

    public class Ambarlar
    {
        public int Id { get; set; }
        public string? AmbarNo { get; set; }
        public string? AmbarAdi { get; set; }
    }

    public class DovizTurleri
    {
        public int Id { get; set; }
        public string? DovizKodu { get; set; }
        public string? DovizTuru { get; set; } 
    }

    public class DovizKurlari
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string? DovizKodu { get; set; }
        public string? DovizTuru { get; set; }
        public double DovizKuru { get; set; }
    }

    public class OdemeTipleri
    {
        public int Id { get; set; }
        public string? OdemeKodu { get; set; }
        public string? OdemeTipi { get; set; }
    }

    public class Numarator
    {
        public int Id { get; set; }
        public string? Tip { get; set; }
        public string? OnEk { get; set; }
        public int Numara { get; set; }
    }
}
