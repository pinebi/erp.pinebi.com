using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.Test
{
    public class Randevu
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string? Tc { get; set; }
        public string? Ad { get; set; }
        public string? Tel { get; set; }
        public string? Doktor { get; set; }
    }
}
