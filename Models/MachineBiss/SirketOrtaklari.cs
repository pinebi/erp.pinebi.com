using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class SirketOrtaklari
    {
        public int Id { get; set; }
        public string? AdSoyad { get; set; }
        public string? Gorevi { get; set; }
        public string? Telefon { get; set; }
        public string? DahiliTel { get; set; } 
        public string? EPosta { get; set; }
        public string? Adres { get; set; }
        public string? Sehir { get; set; }
        public string? Ilce { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double OrtaklikPayi { get; set; }
    }
}
