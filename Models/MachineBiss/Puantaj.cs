using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class Puantaj
    {
        public int Id { get; set; }
        public int? PersId { get; set; }
        public string? Personel { get; set; }
        public int? Yil { get; set; }
        public int? Ay { get; set; }
        [Column("AyAdi")]
        public string? AyAdi { get; set; }
        public int? AyGun { get; set; }

        public string _1_ { get; set; }
        public string _2_ { get; set; }
        public string _3_ { get; set; }
        public string _4_ { get; set; }
        public string _5_ { get; set; }
        public string _6_ { get; set; }
        public string _7_ { get; set; }
        public string _8_ { get; set; }
        public string _9_ { get; set; }
        public string _10_ { get; set; }
        public string _11_ { get; set; }
        public string _12_ { get; set; }
        public string _13_ { get; set; }
        public string _14_ { get; set; }
        public string _15_ { get; set; }
        public string _16_ { get; set; }
        public string _17_ { get; set; }
        public string _18_ { get; set; }
        public string _19_ { get; set; }
        public string _20_ { get; set; }
        public string _21_ { get; set; }
        public string _22_ { get; set; }
        public string _23_ { get; set; }
        public string _24_ { get; set; }
        public string _25_ { get; set; }
        public string _26_ { get; set; }
        public string _27_ { get; set; }
        public string _28_ { get; set; }
        public string _29_ { get; set; }
        public string _30_ { get; set; }
        public string _31_ { get; set; }
    }
}
