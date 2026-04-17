using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class SirketYetkili
    {
        public int Id { get; set; }
        public int SirketId { get; set; }
        public string? AdiSoyadi { get; set; }
        public string? Gsm { get; set; }
        public string? EMail { get; set; } 
    }
}
