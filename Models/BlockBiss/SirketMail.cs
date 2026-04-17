using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.BlockBiss
{
    public class SirketMail
    {
        public int Id { get; set; }
        public int SirketNo { get; set; }
        public string? Birim { get; set; }
        public string? EMail { get; set; }
        public string? DahiliTel { get; set; }
        [Column("Paylas")]
        public bool? Paylas { get; set; }
    }
}
