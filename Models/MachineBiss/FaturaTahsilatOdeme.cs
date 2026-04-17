using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class FaturaTahsilatOdeme
    {
        public int Id { get; set; }
        public DateTime? Tarih { get; set; }
        public int? FisId { get; set; }
        public int? FaturaId { get; set; }
        public int? IslemId { get; set; }
        public double FaturaTutari { get; set; }
        public double IslemTutari { get; set; }
        public string? Personel { get; set; }
        public bool? Iptal { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string? OlusturanKullanici { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenKullanici { get; set; }
    }

    public class FaturaTahsilatOdemeGecmisi
    {
        public int Id { get; set; }
        public DateTime? Tarih { get; set; }
        public string? Personel { get; set; }
        [Column("FisNo")]
        public string? FaturaNo { get; set; }
        public int? FaturaId { get; set; }
        public int? IslemId { get; set; }
        [Column("Islem")]
        public string Islem { get; set; }
        [Column("FaturaTutari")]
        public double? FaturaTutari { get; set; }
        [Column("IslemTutari")]
        public double? IslemTutari { get; set; }
        public bool? Iptal { get; set; }
    }

    public class OzetFaturaHareketleri
    {
        public int ID { get; set; }
        public DateTime? Tarih { get; set; }
        [DisplayName("Doviz")]
        public string? Doviz { get; set; }
        public int? AlisFaturaAdedi { get; set; }
        public double? AlisFaturaToplami { get; set; }
        public double? OdenmisFaturalar { get; set; }
        public double? OdenmemisFaturalar { get; set; }

        public int? SatisFaturaAdedi { get; set; }
        public double? SatisFaturaToplami { get; set; }
        public double? TahsilEdilmisFaturalar { get; set; }
        public double? TahsilEdilmemisFaturalar { get; set; }


    }
}
