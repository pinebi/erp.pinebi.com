using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.BlockBiss
{
    public class KdvOranlari
    {
        public int Id { get; set; }
        public double? KdvOrani { get; set; }
    }

    public class KdvMuafiyetSebepleri
    {
        public int Id { get; set; }
        public string? MuafiyetKodu { get; set; }
        public string? MuafiyetSebebi { get; set; }
    }
}
