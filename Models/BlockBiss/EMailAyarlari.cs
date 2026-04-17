using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.BlockBiss
{
    public class EMailAyarlari
    {
        public int Id { get; set; }
        public string? EMailServer { get; set; }
        public string? EMailUserName { get; set; }
        public string? EMailPassword { get; set; }
        public int? EMailPort { get; set; }
        public bool? SSL { get; set; }
    }
}
