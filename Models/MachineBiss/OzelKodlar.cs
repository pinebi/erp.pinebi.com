using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class OzelKodlar
    {
        public int Id { get; set; }
        public int Kod { get; set; }
        public string? OzelKod { get; set; }
    }
}
