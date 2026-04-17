using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.BlockBiss
{
    public class ErpKapaliModuller
    {
        public int Id { get; set; }
        public int? SirketKodu { get; set; }
        public int? KullaniciLimiti { get; set; }
        public bool? EnvanterYonetimi { get; set; }
        public bool? PersonelYonetimi { get; set; }
        public bool? FirmaAnalizi { get; set; }

        public bool? CariTakibi { get; set; }
        public bool? StokTakibi { get; set; }
    }
}
