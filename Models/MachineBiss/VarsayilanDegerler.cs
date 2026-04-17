using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class VarsayilanDegerler
    {
        public int Id { get; set; }
        public int Ulke { get; set; }
        public int Sehir { get; set; }
        public string? ParaBirimi { get; set; }
        public bool CariTakibi { get; set; }
        public bool StokTakibi { get; set; }
    }
}
