using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.EFatura.GidenEFaturaLogin
{
    public class Rootobject
    {
        public Logininfo LoginInfo { get; set; }
        public string? session_id { get; set; }
        public int BranchID { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
    }

    public class Logininfo
    {
        public string? InstitutionId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
