using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.BlockBiss
{
    public class Ulkeler
    {
        public int Id { get; set; }
        public string? Simge { get; set; }
        public string? Ulke { get; set; }
        public string? AlanKodu { get; set; }
    }

    public class Sehirler
    {
        public int Id { get; set; }
        public int? UlkeId { get; set; }
        public string? SehirAdi { get; set; }
        public string? Duzenle { get; set; }
    }

    public class Ilceler
    {
        public int Id { get; set; }
        public string? IlceAdi { get; set; }
        public int SehirId { get; set; }
        public string? Duzenle { get; set; }
    }
}
