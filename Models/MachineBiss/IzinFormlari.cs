using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class IzinFormlari
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public string? AdiSoyadi { get; set; }
        public string? Gorevi { get; set; }
        public string? IzinTuru { get; set; }
        public DateTime? IzinTalepTarihi { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public int? IzinGunu { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public DateTime? IseBaslamaTarihi { get; set; }
        public string? PersonelAciklama { get; set; }
        public string? YoneticiAciklama { get; set; }
        public string? OnayDurumu { get; set; }
        public string? OnayAciklama { get; set; }
        public bool? Iptal { get; set; }
    }

    public class SaglikRaporlari
    {
        public int Id { get; set; }
        public DateTime? IslemTarihi { get; set; }
        public int? PersonelId { get; set; }
        public string? AdiSoyadi { get; set; }
        public string? Gorevi { get; set; }
        [Column("HastalikTanisi")]
        public string? HastalikTanisi { get; set; }
        [Column("BaslangicTarihi")]
        public DateTime? BaslangicTarihi { get; set; }
        public int? RaporGunu { get; set; }
        public DateTime? BitisTarihi { get; set; }
        [Column("IseBaslamaTarihi")]
        public DateTime? IseBaslamaTarihi { get; set; }
        public string? YoneticiAciklama { get; set; }
        public bool? Iptal { get; set; }
    }
}
