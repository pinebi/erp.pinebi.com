using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("satinalma_talepleri")]
public class SatinalmaTalepleri
{
    [Column("stl_Guid")]
    public Guid? StlGuid { get; set; }

    [Column("stl_DBCno")]
    public short? StlDBCno { get; set; }

    [Column("stl_SpecRECno")]
    public int? StlSpecRECno { get; set; }

    [Column("stl_iptal")]
    public bool? StlIptal { get; set; }

    [Column("stl_fileid")]
    public short? StlFileid { get; set; }

    [Column("stl_hidden")]
    public bool? StlHidden { get; set; }

    [Column("stl_kilitli")]
    public bool? StlKilitli { get; set; }

    [Column("stl_degisti")]
    public bool? StlDegisti { get; set; }

    [Column("stl_checksum")]
    public int? StlChecksum { get; set; }

    [Column("stl_create_user")]
    public short? StlCreateUser { get; set; }

    [Column("stl_create_date")]
    public DateTime? StlCreateDate { get; set; }

    [Column("stl_lastup_user")]
    public short? StlLastupUser { get; set; }

    [Column("stl_lastup_date")]
    public DateTime? StlLastupDate { get; set; }

    [Column("stl_special1")]
    [StringLength(4)]
    public string? StlSpecial1 { get; set; }

    [Column("stl_special2")]
    [StringLength(4)]
    public string? StlSpecial2 { get; set; }

    [Column("stl_special3")]
    [StringLength(4)]
    public string? StlSpecial3 { get; set; }

    [Column("stl_firmano")]
    public int? StlFirmano { get; set; }

    [Column("stl_subeno")]
    public int? StlSubeno { get; set; }

    [Column("stl_tarihi")]
    public DateTime? StlTarihi { get; set; }

    [Column("stl_teslim_tarihi")]
    public DateTime? StlTeslimTarihi { get; set; }

    [Column("stl_evrak_seri")]
    [StringLength(50)]
    public string? StlEvrakSeri { get; set; }

    [Column("stl_evrak_sira")]
    public int? StlEvrakSira { get; set; }

    [Column("stl_satir_no")]
    public int? StlSatirNo { get; set; }

    [Column("stl_belge_no")]
    [StringLength(50)]
    public string? StlBelgeNo { get; set; }

    [Column("stl_belge_tarihi")]
    public DateTime? StlBelgeTarihi { get; set; }

    [Column("stl_Sor_Merk")]
    [StringLength(25)]
    public string? StlSorMerk { get; set; }

    [Column("stl_Stok_kodu")]
    [StringLength(25)]
    public string? StlStokKodu { get; set; }

    [Column("stl_Satici_Kodu")]
    [StringLength(25)]
    public string? StlSaticiKodu { get; set; }

    [Column("stl_miktari")]
    public double? StlMiktari { get; set; }

    [Column("stl_teslim_miktari")]
    public double? StlTeslimMiktari { get; set; }

    [Column("stl_aciklama")]
    [StringLength(50)]
    public string? StlAciklama { get; set; }

    [Column("stl_aciklama2")]
    [StringLength(50)]
    public string? StlAciklama2 { get; set; }

    [Column("stl_depo_no")]
    public int? StlDepoNo { get; set; }

    [Column("stl_kapat_fl")]
    public bool? StlKapatFl { get; set; }

    [Column("stl_projekodu")]
    [StringLength(25)]
    public string? StlProjekodu { get; set; }

    [Column("stl_parti_kodu")]
    [StringLength(25)]
    public string? StlPartiKodu { get; set; }

    [Column("stl_lot_no")]
    public int? StlLotNo { get; set; }

    [Column("stl_OnaylayanKulNo")]
    public short? StlOnaylayanKulNo { get; set; }

    [Column("stl_cagrilabilir_fl")]
    public bool? StlCagrilabilirFl { get; set; }

    [Column("stl_harekettipi")]
    public byte? StlHarekettipi { get; set; }

    [Column("stl_talep_eden")]
    [StringLength(25)]
    public string? StlTalepEden { get; set; }

    [Column("stl_kapatmanedenkod")]
    [StringLength(25)]
    public string? StlKapatmanedenkod { get; set; }

    [Column("stl_KaynakSip_uid")]
    public Guid? StlKaynakSipUid { get; set; }
}
