using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class OzetKdvRaporu
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public Int16 Ay { get; set; }
        [Column("Yil")]
        public int Yil { get; set; }
        [Column("Alis")]
        public double? Alis { get; set; }
        [Column("Satis")]
        public double? Satis { get; set; }
    }
}
