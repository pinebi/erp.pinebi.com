using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.BlockBiss
{
    public class Doviz
    {
        public int Id { get; set; }
        public string? DovizKodu { get; set; }
        public string? DovizCinsi { get; set; }
        public string? Aciklama { get; set; }
        public string? Simge { get; set; }
    }
}
