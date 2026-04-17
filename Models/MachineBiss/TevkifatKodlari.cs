using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class TevkifatKodlari
    {
        public int Id { get; set; }
        public string? TevkifatKodu { get; set; }
        public string? TevkifatAciklama { get; set; }
        public double? TevkifatCarpani { get; set; }
        public double? TevkifatBoleni { get; set; }
    }
}
