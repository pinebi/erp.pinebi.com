using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ik_formu")]
public class IkFormu
{
    [Column("ikf_Guid")]
    public Guid? IkfGuid { get; set; }

    [Column("ikf_DBCno")]
    public short? IkfDBCno { get; set; }

    [Column("ikf_SpecRECno")]
    public int? IkfSpecRECno { get; set; }

    [Column("ikf_iptal")]
    public bool? IkfIptal { get; set; }

    [Column("ikf_fileid")]
    public short? IkfFileid { get; set; }

    [Column("ikf_hidden")]
    public bool? IkfHidden { get; set; }

    [Column("ikf_kilitli")]
    public bool? IkfKilitli { get; set; }

    [Column("ikf_degisti")]
    public bool? IkfDegisti { get; set; }

    [Column("ikf_checksum")]
    public int? IkfChecksum { get; set; }

    [Column("ikf_create_user")]
    public short? IkfCreateUser { get; set; }

    [Column("ikf_create_date")]
    public DateTime? IkfCreateDate { get; set; }

    [Column("ikf_lastup_user")]
    public short? IkfLastupUser { get; set; }

    [Column("ikf_lastup_date")]
    public DateTime? IkfLastupDate { get; set; }

    [Column("ikf_special1")]
    [StringLength(4)]
    public string? IkfSpecial1 { get; set; }

    [Column("ikf_special2")]
    [StringLength(4)]
    public string? IkfSpecial2 { get; set; }

    [Column("ikf_special3")]
    [StringLength(4)]
    public string? IkfSpecial3 { get; set; }

    [Column("ikf_firmano")]
    public int? IkfFirmano { get; set; }

    [Column("ikf_subeno")]
    public int? IkfSubeno { get; set; }

    [Column("ikf_tarih")]
    public DateTime? IkfTarih { get; set; }

    [Column("ikf_tipi")]
    public byte? IkfTipi { get; set; }

    [Column("ikf_belgeno")]
    [StringLength(50)]
    public string? IkfBelgeno { get; set; }

    [Column("ikf_belge_tarih")]
    [StringLength(50)]
    public string? IkfBelgeTarih { get; set; }

    [Column("ikf_kod")]
    [StringLength(25)]
    public string? IkfKod { get; set; }

    [Column("ikf_adi")]
    [StringLength(40)]
    public string? IkfAdi { get; set; }

    [Column("ikf_dept")]
    [StringLength(25)]
    public string? IkfDept { get; set; }

    [Column("ikf_gorev")]
    [StringLength(25)]
    public string? IkfGorev { get; set; }

    [Column("ikf_veren_pers")]
    [StringLength(25)]
    public string? IkfVerenPers { get; set; }

    [Column("ikf_per_kodu")]
    [StringLength(25)]
    public string? IkfPerKodu { get; set; }

    [Column("ikf_satirno")]
    public int? IkfSatirno { get; set; }

    [Column("ikf_kriter")]
    [StringLength(25)]
    public string? IkfKriter { get; set; }

    [Column("ikf_satirpuan")]
    public double? IkfSatirpuan { get; set; }

    [Column("ikf_degerlendir_fl")]
    public bool? IkfDegerlendirFl { get; set; }

    [Column("ikf_kadro")]
    [StringLength(25)]
    public string? IkfKadro { get; set; }

    [Column("ikf_aciklama1")]
    [StringLength(120)]
    public string? IkfAciklama1 { get; set; }

    [Column("ikf_aciklama2")]
    [StringLength(120)]
    public string? IkfAciklama2 { get; set; }

    [Column("ikf_aciklama3")]
    [StringLength(120)]
    public string? IkfAciklama3 { get; set; }
}
