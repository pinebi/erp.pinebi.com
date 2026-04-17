using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class FaturaBankaBilgileri
    {
        public int Id { get; set; }
        public bool Sec { get; set; }
        public int FaturaId { get; set; }
        public string? Banka { get; set; }
        public string? ParaBirimi { get; set; }
        public string? Sube { get; set; }
        public string? Iban { get; set; }
        public string? SwiftKodu { get; set; }
    }
}
