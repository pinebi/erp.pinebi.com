using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class Hatirlatmalar
    {
        public int Id { get; set; }
        public int? PersId { get; set; }
        public string? Personel { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime HatirlatmaTarihi { get; set; }
        public string? Aciklama { get; set; }
        public bool? SmsBilgi { get; set; }
        public bool? Okundu { get; set; }
        public bool? Iptal { get; set; }
    }
}
