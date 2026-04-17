using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class MasrafKalemleri
    {
        public int Id { get; set; }
        public int TrCode { get; set; }
        public int FaturaTipi { get; set; }
        public string? OzelKod3 { get; set; }
        public double Tutar { get; set; }
    }
}
