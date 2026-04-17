using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.BlockBiss
{
    public class Sektorler
    {
        public int Id { get; set; }
        public int SirketNo { get; set; }
        public string? SektorKodu { get; set; }
        public string? SektorAdi { get; set; }
        public bool Aktif { get; set; }
    }

    public class Hizmetler
    {
        public int Id { get; set; }
        public int SirketNo { get; set; }
        public string? HizmetKodu { get; set; }
        public string? HizmetAdi { get; set; }
        public bool Aktif { get; set; }
    }
}
