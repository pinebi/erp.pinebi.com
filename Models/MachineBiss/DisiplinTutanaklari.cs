using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class DisiplinTutanaklari
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        [Column("PersonelAdi")]
        public string? PersonelAdi { get; set; }
        [Column("PersonelGorevi")]
        public string? PersonelGorevi { get; set; }
        public string? TCKimlikNo { get; set; }
        public string? SGKSicilNo { get; set; }
        public DateTime Tarih { get; set; }
        public string? Konu { get; set; }
        [Column("Duzenleyen")]
        public string? Duzenleyen { get; set; }
        [Column("DuzenleyenGorevi")]
        public string? DuzenleyenGorevi { get; set; }
        [Column("Tanik")]
        public string? Tanik { get; set; }
        public string? DosyaEki { get; set; }
        public bool? Iptal { get; set; }
    }

    public class GenelTutanaklar
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string? Konu { get; set; }
        [Column("Duzenleyen")]
        public string? Duzenleyen { get; set; }
        [Column("DuzenleyenGorevi")]
        public string? DuzenleyenGorevi { get; set; }
        public string? DosyaEki { get; set; }
        public bool? Iptal { get; set; }
    }

    public class GorusVeOneriler
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string? Konu { get; set; }
        [Column("Duzenleyen")]
        public string? Duzenleyen { get; set; }
        [Column("DuzenleyenGorevi")]
        public string? DuzenleyenGorevi { get; set; }
        public string? DosyaEki { get; set; }
        public bool? Iptal { get; set; }
    }
}
