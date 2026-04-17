using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class TasiyiciBilgileri
    {
        public int Id { get; set; }

        public string? Kod { get; set; }

        public string? Unvan { get; set; }

        public string? Vd { get; set; }

        public string? Vn { get; set; }

        public bool? Iptal { get; set; }
    }
}
