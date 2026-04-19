using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("uretim_talepleri")]
public class UretimTalepleri
{
    [Column("utl_Guid")]
    public Guid? UtlGuid { get; set; }

    [Column("utl_DBCno")]
    public short? UtlDBCno { get; set; }

    [Column("utl_SpecRECno")]
    public int? UtlSpecRECno { get; set; }

    [Column("utl_iptal")]
    public bool? UtlIptal { get; set; }

    [Column("utl_fileid")]
    public short? UtlFileid { get; set; }

    [Column("utl_hidden")]
    public bool? UtlHidden { get; set; }

    [Column("utl_kilitli")]
    public bool? UtlKilitli { get; set; }

    [Column("utl_degisti")]
    public bool? UtlDegisti { get; set; }

    [Column("utl_checksum")]
    public int? UtlChecksum { get; set; }

    [Column("utl_create_user")]
    public short? UtlCreateUser { get; set; }

    [Column("utl_create_date")]
    public DateTime? UtlCreateDate { get; set; }

    [Column("utl_lastup_user")]
    public short? UtlLastupUser { get; set; }

    [Column("utl_lastup_date")]
    public DateTime? UtlLastupDate { get; set; }

    [Column("utl_special1")]
    [StringLength(4)]
    public string? UtlSpecial1 { get; set; }

    [Column("utl_special2")]
    [StringLength(4)]
    public string? UtlSpecial2 { get; set; }

    [Column("utl_firmano")]
    public int? UtlFirmano { get; set; }

    [Column("utl_subeno")]
    public int? UtlSubeno { get; set; }

    [Column("utl_tarihi")]
    public DateTime? UtlTarihi { get; set; }

    [Column("utl_teslim_tarihi")]
    public DateTime? UtlTeslimTarihi { get; set; }

    [Column("utl_evrak_seri")]
    [StringLength(50)]
    public string? UtlEvrakSeri { get; set; }

    [Column("utl_evrak_sira")]
    public int? UtlEvrakSira { get; set; }

    [Column("utl_satir_no")]
    public int? UtlSatirNo { get; set; }

    [Column("utl_belge_no")]
    [StringLength(50)]
    public string? UtlBelgeNo { get; set; }

    [Column("utl_belge_tarihi")]
    public DateTime? UtlBelgeTarihi { get; set; }

    [Column("utl_Sor_Merk")]
    [StringLength(25)]
    public string? UtlSorMerk { get; set; }

    [Column("utl_Stok_kodu")]
    [StringLength(25)]
    public string? UtlStokKodu { get; set; }

    [Column("utl_Satici_Kodu")]
    [StringLength(25)]
    public string? UtlSaticiKodu { get; set; }

    [Column("utl_miktari")]
    public double? UtlMiktari { get; set; }

    [Column("utl_planlanan_miktar")]
    public double? UtlPlanlananMiktar { get; set; }

    [Column("utl_aciklama")]
    [StringLength(40)]
    public string? UtlAciklama { get; set; }

    [Column("utl_depo_no")]
    public int? UtlDepoNo { get; set; }

    [Column("utl_kapat_fl")]
    public bool? UtlKapatFl { get; set; }

    [Column("utl_projekodu")]
    [StringLength(25)]
    public string? UtlProjekodu { get; set; }

    [Column("utl_parti_kodu")]
    [StringLength(25)]
    public string? UtlPartiKodu { get; set; }

    [Column("utl_lot_no")]
    public int? UtlLotNo { get; set; }

    [Column("utl_sip_uid")]
    public Guid? UtlSipUid { get; set; }

    [Column("utl_kapatmanedenkod")]
    [StringLength(25)]
    public string? UtlKapatmanedenkod { get; set; }
}
