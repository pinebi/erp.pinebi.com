using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class StokKart
    {
        public int Id { get; set; }
        public string? Barkod { get; set; }
        public string? StokKodu { get; set; }
        public string? StokCinsi { get; set; }
        [Column("Aciklama")]
        public string? Aciklama { get; set; }
        public string? Birim { get; set; }
        public decimal Kdv { get; set; }
        public string? DovizKodu { get; set; }
        public decimal KdvHaricSatisFiyati { get; set; }
        public string? UrunGrubu { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? OzelKod3 { get; set; }
        public string? OzelKod4 { get; set; }
        public string? OzelKod5 { get; set; }
        public Int16? TevkifatId { get; set; }
        public string? TevkifatKodu { get; set; }
        public decimal? TevkifatCarpan { get; set; }
        public decimal? TevkifatBolen { get; set; }
        public decimal? MinimumSeviye { get; set; }
        [Column("KullanimDisi")]
        public bool KullanimDisi { get; set; }
    }

    public class StokKartlariView
    {
        public int Id { get; set; }
        public string? Barkod { get; set; }
        public string? StokKodu { get; set; }
        public string? StokCinsi { get; set; }
        [Column("Aciklama")]
        public string? Aciklama { get; set; }
        public string? Birim { get; set; }
        public decimal Kdv { get; set; }
        public string? DovizKodu { get; set; }
        public string? DovizCinsi { get; set; }
        public decimal KdvHaricSatisFiyati { get; set; }
        public string? UrunGrubu { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? OzelKod3 { get; set; }
        public string? OzelKod4 { get; set; }
        public string? OzelKod5 { get; set; }
        public Int16? TevkifatId { get; set; }
        public string? TevkifatKodu { get; set; }
        public decimal? TevkifatCarpan { get; set; }
        public decimal? TevkifatBolen { get; set; }
        public decimal? MinimumSeviye { get; set; }
        [Column("KullanimDisi")]
        public bool KullanimDisi { get; set; }
    }

    public class UrunGruplari
    {
        public int Id { get; set; }
        public string? UrunGrubu { get; set; }
    }
}
