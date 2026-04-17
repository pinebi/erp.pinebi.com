using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class BorcAlacakRaporu
    {
        public int Id { get; set; }
        public int CariId { get; set; }
        public string? CariKodu { get; set; }
        public string? Unvani { get; set; }
        public decimal Borc { get; set; }
        public decimal Alacak { get; set; }
        public decimal Bakiye { get; set; }
        public string? Doviz { get; set; }
        public bool? Iptal { get; set; }
    }
}
