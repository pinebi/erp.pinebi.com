using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.BlockBiss
{
    public class EFaturaUluslararasiBirimKodlari
    {
        public int Id { get; set; }
        public string? BirimKodu { get; set; }
        public string? DonusumKodu { get; set; }
        public string? DonusumAciklama { get; set; }
    }
}
