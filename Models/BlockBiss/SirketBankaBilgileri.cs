using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.BlockBiss
{
    public class SirketBankaBilgileri
    {
        public int Id { get; set; }
        public bool Sec { get; set; }
        public int SirketNo { get; set; }
        public string? Banka { get; set; }
        public string? ParaBirimi { get; set; }
        public string? Sube { get; set; }
        public string? Iban { get; set; }
        public string? SwiftKodu { get; set; }
    }

    public class ParaBirimleri
    {
        public int Id { get; set; }
        public string? ParaBirimi { get; set; }
        public string? Simge { get; set; }
    }
}
