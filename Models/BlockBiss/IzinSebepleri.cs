using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.BlockBiss
{
    public class IzinSebepleri
    {
        public int Id { get; set; }
        public string? IzinKodu { get; set; }
        public string? IzinSebebi { get; set; }
        public int Gun { get; set; }
    }
}
