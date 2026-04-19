using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ufrs_sozlesmeleri")]
public class UfrsSozlesmeleri
{
    [Column("usoz_Guid")]
    public Guid? UsozGuid { get; set; }

    [Column("usoz_DBCno")]
    public short? UsozDBCno { get; set; }

    [Column("usoz_SpecRECno")]
    public int? UsozSpecRECno { get; set; }

    [Column("usoz_iptal")]
    public bool? UsozIptal { get; set; }

    [Column("usoz_fileid")]
    public short? UsozFileid { get; set; }

    [Column("usoz_hidden")]
    public bool? UsozHidden { get; set; }

    [Column("usoz_kilitli")]
    public bool? UsozKilitli { get; set; }

    [Column("usoz_degisti")]
    public bool? UsozDegisti { get; set; }

    [Column("usoz_checksum")]
    public int? UsozChecksum { get; set; }

    [Column("usoz_create_user")]
    public short? UsozCreateUser { get; set; }

    [Column("usoz_create_date")]
    public DateTime? UsozCreateDate { get; set; }

    [Column("usoz_lastup_user")]
    public short? UsozLastupUser { get; set; }

    [Column("usoz_lastup_date")]
    public DateTime? UsozLastupDate { get; set; }

    [Column("usoz_special1")]
    [StringLength(4)]
    public string? UsozSpecial1 { get; set; }

    [Column("usoz_special2")]
    [StringLength(4)]
    public string? UsozSpecial2 { get; set; }

    [Column("usoz_special3")]
    [StringLength(4)]
    public string? UsozSpecial3 { get; set; }

    [Column("usoz_siptip")]
    public byte? UsozSiptip { get; set; }

    [Column("usoz_sipcins")]
    public byte? UsozSipcins { get; set; }

    [Column("usoz_sipevrakseri")]
    [StringLength(50)]
    public string? UsozSipevrakseri { get; set; }

    [Column("usoz_sipevraksira")]
    public int? UsozSipevraksira { get; set; }

    [Column("usoz_aciklama")]
    [StringLength(127)]
    public string? UsozAciklama { get; set; }

    [Column("usoz_siptarih")]
    public DateTime? UsozSiptarih { get; set; }

    [Column("usoz_sipcarikodu")]
    [StringLength(25)]
    public string? UsozSipcarikodu { get; set; }

    [Column("usoz_sipcarigrupno")]
    public byte? UsozSipcarigrupno { get; set; }

    [Column("usoz_faizorani")]
    public double? UsozFaizorani { get; set; }

    [Column("usoz_odemeplani")]
    public int? UsozOdemeplani { get; set; }

    [Column("usoz_toplamtutar")]
    public double? UsozToplamtutar { get; set; }

    [Column("usoz_dovizcinsi")]
    public byte? UsozDovizcinsi { get; set; }

    [Column("usoz_sozlesmetipi")]
    public byte? UsozSozlesmetipi { get; set; }

    [Column("usoz_mulkiyetnereden")]
    public byte? UsozMulkiyetnereden { get; set; }

    [Column("usoz_vadenereden")]
    public byte? UsozVadenereden { get; set; }

    [Column("usoz_mulkiyettarihi")]
    public DateTime? UsozMulkiyettarihi { get; set; }
}
