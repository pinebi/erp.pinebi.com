using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.EFatura
{
    public class EFaturaHataKodlari
    {
        public int Id { get; set; }
        public string? HataKodu { get; set; }
        [Column("Aciklama")]
        public string? Aciklama { get; set; }
    }
}
