using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.BlockBiss.Envanter
{
    public class Envanterler
    {
        public int Id { get; set; }
        public string? EnvanterAdi { get; set; }
        public bool? Aktif { get; set; }
    }

    public class EnvanterTanimlari
    {
        public int Id { get; set; }
        public int EnvanterId { get; set; }
        [Column("Tanim")]
        public string? Tanimi { get; set; }
        public bool? Aktif { get; set; }
    }

    public class EnvanterTanimlariIcerik
    {
        public int Id { get; set; }
        public int TanimId { get; set; }
        public string? Aciklama { get; set; }
        public bool? Aktif { get; set; }
    }

    public class EnvanterTanimlariIcerikOzellikler
    {
        public int Id { get; set; }
        [NotMapped]
        public int? SirketNo { get; set; }
        public int? TanimIcerikId { get; set; }
        [NotMapped]
        public int? EnvanterId { get; set; }
        public string? Aciklama { get; set; }
        public string? Deger { get; set; }
        public bool? Aktif { get; set; }
    }

    public class FirmaEnvanterListesi
    {
        public int Id { get; set; }
        public int SirketNo { get; set; }
        public int EnvanterId { get; set; }
        public int TanimId { get; set; }
        public int AciklamaId { get; set; }
        public string? OzelKod { get; set; }
        [Column("Degeri")]
        public decimal? Degeri { get; set; }
        public bool? Network { get; set; }
        public bool? Aktif { get; set; }
    }

    public class FirmaEnvanterListesiView
    {
        public int Id { get; set; }
        public int? SirketNo { get; set; }
        public int? EnvanterId { get; set; }
        [Column("EnvanterAdi")]
        public string? EnvanterAdi { get; set; }
        public int? TanimId { get; set; }
        [Column("Tanim")]
        public string? Tanimi { get; set; }
        public int? AciklamaId { get; set; }
        [Column("Aciklama")]
        public string? Aciklama { get; set; }
        [Column("OzelKod")]
        public string OzelKod { get; set; }
        [Column("Degeri")]
        public decimal? Degeri { get; set; }
        public bool? Network { get; set; }
        public bool? Aktif { get; set; }
    }

    public class FirmaEnvanterIcerik
    {
        public int Id { get; set; }
        public int? SirketNo { get; set; }
        public int? EnvanterId { get; set; }
        public string? Aciklama { get; set; }
        public string? Deger { get; set; }
        public bool? Aktif { get; set; }
    }


    public class AracSigortaMuayeneTakibi
    {
        public int Id { get; set; }
        public int? EnvanterId { get; set; }
        public DateTime? Tarih { get; set; }
        public string? IslemTuru { get; set; }
        public string? PlakaNo { get; set; }
        public string? Aciklama { get; set; }

        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public double Tutar { get; set; }
        public bool? Iptal { get; set; }
    }

    public class AracSigortaMuayeneTakibiView
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int EnvanterId { get; set; }
        public string? IslemTuru { get; set; }
        public string? Aciklama { get; set; }
        public string? PlakaNo { get; set; }

        public DateTime TrafikSigortaBaslangic { get; set; }
        public DateTime TrafikSigortaBitis { get; set; }
        public double SigortaTutari { get; set; }

        public DateTime KaskoBaslangic { get; set; }
        public DateTime KaskoBitis { get; set; }
        public double KaskoTutari { get; set; }

        public DateTime MuayeneBaslangic { get; set; }
        public DateTime MuayeneBitis { get; set; }
        public double MuayeneTutari { get; set; }
        public bool? Iptal { get; set; }
    }

    public class AracBakimTakibi
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int? EnvanterId { get; set; }
        [Column("FisNo")]
        public string? ReferansNo { get; set; }
        public string? PlakaNo { get; set; }
        public string? Aciklama { get; set; }
        public double Tutar { get; set; }
        public bool? Iptal { get; set; }
    }

    public class AracBakimTakibiListe
    {
        public int Id { get; set; }
        public int FisId { get; set; }
        public string? Aciklama { get; set; }
        public double Adet { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public bool? Iptal { get; set; }
    }

}
