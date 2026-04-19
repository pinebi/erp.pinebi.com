using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("hizmet_alis_sozlesmeleri")]
public class HizmetAlisSozlesmeleri
{
    [Column("HAS_Guid")]
    public Guid? HASGuid { get; set; }

    [Column("HAS_DBCno")]
    public short? HASDBCno { get; set; }

    [Column("HAS_Spec_Rec_no")]
    public int? HASSpecRecNo { get; set; }

    [Column("HAS_iptal")]
    public bool? HASIptal { get; set; }

    [Column("HAS_fileid")]
    public short? HASFileid { get; set; }

    [Column("HAS_hidden")]
    public bool? HASHidden { get; set; }

    [Column("HAS_kilitli")]
    public bool? HASKilitli { get; set; }

    [Column("HAS_degisti")]
    public bool? HASDegisti { get; set; }

    [Column("HAS_checksum")]
    public int? HASChecksum { get; set; }

    [Column("HAS_create_user")]
    public short? HASCreateUser { get; set; }

    [Column("HAS_create_date")]
    public DateTime? HASCreateDate { get; set; }

    [Column("HAS_lastup_user")]
    public short? HASLastupUser { get; set; }

    [Column("HAS_lastup_date")]
    public DateTime? HASLastupDate { get; set; }

    [Column("HAS_special1")]
    [StringLength(4)]
    public string? HASSpecial1 { get; set; }

    [Column("HAS_special2")]
    [StringLength(4)]
    public string? HASSpecial2 { get; set; }

    [Column("HAS_special3")]
    [StringLength(4)]
    public string? HASSpecial3 { get; set; }

    [Column("HAS_firmano")]
    public int? HASFirmano { get; set; }

    [Column("HAS_subeno")]
    public int? HASSubeno { get; set; }

    [Column("HAS_evraktarihi")]
    public DateTime? HASEvraktarihi { get; set; }

    [Column("HAS_evrakseri")]
    [StringLength(50)]
    public string? HASEvrakseri { get; set; }

    [Column("HAS_evraksira")]
    public int? HASEvraksira { get; set; }

    [Column("HAS_evraksatir")]
    public int? HASEvraksatir { get; set; }

    [Column("HAS_carikodu")]
    [StringLength(25)]
    public string? HASCarikodu { get; set; }

    [Column("HAS_carisrmmrk")]
    [StringLength(25)]
    public string? HASCarisrmmrk { get; set; }

    [Column("HAS_tarihi")]
    public DateTime? HASTarihi { get; set; }

    [Column("HAS_masrafkodu")]
    [StringLength(25)]
    public string? HASMasrafkodu { get; set; }

    [Column("HAS_aciklama")]
    [StringLength(40)]
    public string? HASAciklama { get; set; }

    [Column("HAS_fiyati")]
    public double? HASFiyati { get; set; }

    [Column("HAS_opno")]
    public int? HASOpno { get; set; }

    [Column("HAS_kesfatseri")]
    [StringLength(50)]
    public string? HASKesfatseri { get; set; }

    [Column("HAS_kesfatsira")]
    public int? HASKesfatsira { get; set; }

    [Column("HAS_srmmrkkodu")]
    [StringLength(25)]
    public string? HASSrmmrkkodu { get; set; }

    [Column("HAS_projekodu")]
    [StringLength(25)]
    public string? HASProjekodu { get; set; }

    [Column("HAS_vergipntr")]
    public byte? HASVergipntr { get; set; }

    [Column("HAS_OnaylayanKulNo")]
    public short? HASOnaylayanKulNo { get; set; }

    [Column("HAS_cagrilabilir_fl")]
    public bool? HASCagrilabilirFl { get; set; }

    [Column("HAS_carisozlesmekodu")]
    [StringLength(25)]
    public string? HASCarisozlesmekodu { get; set; }

    [Column("HAS_carisozlesmeakttipi")]
    public byte? HASCarisozlesmeakttipi { get; set; }

    [Column("HAS_grupno")]
    public byte? HASGrupno { get; set; }

    [Column("HAS_doviz_cins")]
    public byte? HASDovizCins { get; set; }

    [Column("HAS_doviz_kur")]
    public double? HASDovizKur { get; set; }

    [Column("HAS_alt_doviz_kur")]
    public double? HASAltDovizKur { get; set; }

    [Column("HAS_saticikodu")]
    [StringLength(25)]
    public string? HASSaticikodu { get; set; }

    [Column("HAS_belgeno")]
    [StringLength(50)]
    public string? HASBelgeno { get; set; }

    [Column("HAS_belge_tarih")]
    public DateTime? HASBelgeTarih { get; set; }
}
