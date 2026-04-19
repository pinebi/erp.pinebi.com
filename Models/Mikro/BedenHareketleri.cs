using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("beden_hareketleri")]
public class BedenHareketleri
{
    [Column("BdnHar_Guid")]
    public Guid? BdnHarGuid { get; set; }

    [Column("BdnHar_DBCno")]
    public short? BdnHarDBCno { get; set; }

    [Column("BdnHar_Spec_Rec_no")]
    public int? BdnHarSpecRecNo { get; set; }

    [Column("BdnHar_iptal")]
    public bool? BdnHarIptal { get; set; }

    [Column("BdnHar_fileid")]
    public short? BdnHarFileid { get; set; }

    [Column("BdnHar_hidden")]
    public bool? BdnHarHidden { get; set; }

    [Column("BdnHar_kilitli")]
    public bool? BdnHarKilitli { get; set; }

    [Column("BdnHar_degisti")]
    public bool? BdnHarDegisti { get; set; }

    [Column("BdnHar_checksum")]
    public int? BdnHarChecksum { get; set; }

    [Column("BdnHar_create_user")]
    public short? BdnHarCreateUser { get; set; }

    [Column("BdnHar_create_date")]
    public DateTime? BdnHarCreateDate { get; set; }

    [Column("BdnHar_lastup_user")]
    public short? BdnHarLastupUser { get; set; }

    [Column("BdnHar_lastup_date")]
    public DateTime? BdnHarLastupDate { get; set; }

    [Column("BdnHar_special1")]
    [StringLength(4)]
    public string? BdnHarSpecial1 { get; set; }

    [Column("BdnHar_special2")]
    [StringLength(4)]
    public string? BdnHarSpecial2 { get; set; }

    [Column("BdnHar_special3")]
    [StringLength(4)]
    public string? BdnHarSpecial3 { get; set; }

    [Column("BdnHar_Tipi")]
    public byte? BdnHarTipi { get; set; }

    [Column("BdnHar_Har_uid")]
    public Guid? BdnHarHarUid { get; set; }

    [Column("BdnHar_BedenNo")]
    public short? BdnHarBedenNo { get; set; }

    [Column("BdnHar_HarGor")]
    public double? BdnHarHarGor { get; set; }

    [Column("BdnHar_KnsIsGor")]
    public double? BdnHarKnsIsGor { get; set; }

    [Column("BdnHar_KnsFat")]
    public double? BdnHarKnsFat { get; set; }

    [Column("BdnHar_TesMik")]
    public double? BdnHarTesMik { get; set; }

    [Column("BdnHar_rezervasyon_miktari")]
    public double? BdnHarRezervasyonMiktari { get; set; }

    [Column("BdnHar_rezerveden_teslim_edilen")]
    public double? BdnHarRezervedenTeslimEdilen { get; set; }
}
