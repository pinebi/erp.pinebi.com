using System.ComponentModel.DataAnnotations;

namespace MACHINEBISS_Web.Models.Sistem
{
    public class LisansGecmisi
    {
        [Key]
        public int Id { get; set; }
        public int? LisansId { get; set; }
        public string? IslemTipi { get; set; }
        public string? EskiPlan { get; set; }
        public string? YeniPlan { get; set; }
        public DateTime? EskiBitisTarihi { get; set; }
        public DateTime? YeniBitisTarihi { get; set; }
        public decimal? Tutar { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? IslemTarihi { get; set; }
    }
}
