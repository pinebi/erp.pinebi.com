using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.EFatura.GelenEFaturaLogin
{

    public class Rootobject
    {
        public Logininfo LoginInfo { get; set; }
        public bool is_test { get; set; }
        public int BranchID { get; set; }
        public long RequestNumber { get; set; }
    }

    public class Logininfo
    {
        public string? InstitutionId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }

}
