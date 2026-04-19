using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("uretim_operasyon_hatalari")]
public class UretimOperasyonHatalari
{
    [Column("oph_Guid")]
    public Guid? OphGuid { get; set; }

    [Column("oph_DBCno")]
    public short? OphDBCno { get; set; }

    [Column("oph_SpecRECNo")]
    public int? OphSpecRECNo { get; set; }

    [Column("oph_iptal")]
    public bool? OphIptal { get; set; }

    [Column("oph_fileid")]
    public short? OphFileid { get; set; }

    [Column("oph_hidden")]
    public bool? OphHidden { get; set; }

    [Column("oph_kilitli")]
    public bool? OphKilitli { get; set; }

    [Column("oph_degisti")]
    public bool? OphDegisti { get; set; }

    [Column("oph_checksum")]
    public int? OphChecksum { get; set; }

    [Column("oph_create_user")]
    public short? OphCreateUser { get; set; }

    [Column("oph_create_date")]
    public DateTime? OphCreateDate { get; set; }

    [Column("oph_lastup_user")]
    public short? OphLastupUser { get; set; }

    [Column("oph_lastup_date")]
    public DateTime? OphLastupDate { get; set; }

    [Column("oph_special1")]
    [StringLength(4)]
    public string? OphSpecial1 { get; set; }

    [Column("oph_special2")]
    [StringLength(4)]
    public string? OphSpecial2 { get; set; }

    [Column("oph_special3")]
    [StringLength(4)]
    public string? OphSpecial3 { get; set; }

    [Column("oph_OpTamam_uid")]
    public Guid? OphOpTamamUid { get; set; }

    [Column("oph_HataKodlari")]
    [StringLength(127)]
    public string? OphHataKodlari { get; set; }

    [Column("oph_Personel")]
    [StringLength(25)]
    public string? OphPersonel { get; set; }

    [Column("oph_Tarih")]
    public DateTime? OphTarih { get; set; }

    [Column("oph_HataliMiktar")]
    public double? OphHataliMiktar { get; set; }
}
