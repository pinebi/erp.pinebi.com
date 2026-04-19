using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("muhasebe_fis_detaylari")]
public class MuhasebeFisDetaylari
{
    [Column("mfd_Guid")]
    public Guid? MfdGuid { get; set; }

    [Column("mfd_DBCno")]
    public short? MfdDBCno { get; set; }

    [Column("mfd_SpecRECno")]
    public int? MfdSpecRECno { get; set; }

    [Column("mfd_iptal")]
    public bool? MfdIptal { get; set; }

    [Column("mfd_fileid")]
    public short? MfdFileid { get; set; }

    [Column("mfd_hidden")]
    public bool? MfdHidden { get; set; }

    [Column("mfd_kilitli")]
    public bool? MfdKilitli { get; set; }

    [Column("mfd_degisti")]
    public bool? MfdDegisti { get; set; }

    [Column("mfd_checksum")]
    public int? MfdChecksum { get; set; }

    [Column("mfd_create_user")]
    public short? MfdCreateUser { get; set; }

    [Column("mfd_create_date")]
    public DateTime? MfdCreateDate { get; set; }

    [Column("mfd_lastup_user")]
    public short? MfdLastupUser { get; set; }

    [Column("mfd_lastup_date")]
    public DateTime? MfdLastupDate { get; set; }

    [Column("mfd_special1")]
    [StringLength(4)]
    public string? MfdSpecial1 { get; set; }

    [Column("mfd_special2")]
    [StringLength(4)]
    public string? MfdSpecial2 { get; set; }

    [Column("mfd_special3")]
    [StringLength(4)]
    public string? MfdSpecial3 { get; set; }

    [Column("mfd_ticari_tip")]
    public byte? MfdTicariTip { get; set; }

    [Column("mfd_evraktip")]
    public byte? MfdEvraktip { get; set; }

    [Column("mfd_evrak_seri")]
    [StringLength(50)]
    public string? MfdEvrakSeri { get; set; }

    [Column("mfd_evrak_sira")]
    public int? MfdEvrakSira { get; set; }

    [Column("mfd_cariunvan")]
    [StringLength(127)]
    public string? MfdCariunvan { get; set; }

    [Column("mfd_carivergidaireadi")]
    [StringLength(50)]
    public string? MfdCarivergidaireadi { get; set; }

    [Column("mfd_carivergidaireno")]
    [StringLength(15)]
    public string? MfdCarivergidaireno { get; set; }

    [Column("mfd_bsbakonututar")]
    public double? MfdBsbakonututar { get; set; }

    [Column("mfd_bsbatabii")]
    public byte? MfdBsbatabii { get; set; }

    [Column("mfd_cariulkekodno")]
    [StringLength(4)]
    public string? MfdCariulkekodno { get; set; }

    [Column("mfd_belgetarihi")]
    public DateTime? MfdBelgetarihi { get; set; }

    [Column("mfd_tutarnereden")]
    public byte? MfdTutarnereden { get; set; }

    [Column("mfd_caritipi")]
    public byte? MfdCaritipi { get; set; }

    [Column("mfd_carikodu")]
    [StringLength(25)]
    public string? MfdCarikodu { get; set; }

    [Column("mfd_carimuhkodu")]
    [StringLength(25)]
    public string? MfdCarimuhkodu { get; set; }

    [Column("mfd_belgeno")]
    [StringLength(50)]
    public string? MfdBelgeno { get; set; }

    [Column("mfd_kdvid")]
    public byte? MfdKdvid { get; set; }

    [Column("mfd_kdvtutar")]
    public double? MfdKdvtutar { get; set; }

    [Column("mfd_malhizmetkodu")]
    [StringLength(25)]
    public string? MfdMalhizmetkodu { get; set; }

    [Column("mfd_malhizmetcinsi")]
    [StringLength(120)]
    public string? MfdMalhizmetcinsi { get; set; }

    [Column("mfd_malhizmetmiktari")]
    public double? MfdMalhizmetmiktari { get; set; }

    [Column("mfd_malhizmetbirim")]
    [StringLength(10)]
    public string? MfdMalhizmetbirim { get; set; }

    [Column("mfd_ggb_gcb_no")]
    [StringLength(30)]
    public string? MfdGgbGcbNo { get; set; }

    [Column("mfd_aracivergidaireadi")]
    [StringLength(50)]
    public string? MfdAracivergidaireadi { get; set; }

    [Column("mfd_aracivergidaireno")]
    [StringLength(15)]
    public string? MfdAracivergidaireno { get; set; }

    [Column("mfd_eximulkekodu")]
    [StringLength(4)]
    public string? MfdEximulkekodu { get; set; }

    [Column("mfd_bsbakonuufrstutar")]
    public double? MfdBsbakonuufrstutar { get; set; }

    [Column("mfd_aciklama")]
    [StringLength(127)]
    public string? MfdAciklama { get; set; }

    [Column("mfd_caritutar")]
    public double? MfdCaritutar { get; set; }

    [Column("mfd_kisaevraktipi")]
    public byte? MfdKisaevraktipi { get; set; }

    [Column("mfd_satistipi")]
    public byte? MfdSatistipi { get; set; }

    [Column("mfd_alistipi")]
    public byte? MfdAlistipi { get; set; }

    [Column("mfd_tahtedtipi")]
    public byte? MfdTahtedtipi { get; set; }

    [Column("mfd_digerevrakadi")]
    [StringLength(50)]
    public string? MfdDigerevrakadi { get; set; }

    [Column("mfd_evraktur")]
    public byte? MfdEvraktur { get; set; }
}
