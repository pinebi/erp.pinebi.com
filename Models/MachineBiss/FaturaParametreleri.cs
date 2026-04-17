using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class FaturaParametreleri
    {
        public int Id { get; set; }
        public bool Aciklama { get; set; }
        public bool Birim { get; set; }
        public bool Indirim { get; set; }
        public bool Kdv { get; set; }
    }
}
