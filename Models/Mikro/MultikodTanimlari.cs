using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("multikod_tanimlari")]
public class MultikodTanimlari
{
    [Column("mcod_Guid")]
    public Guid? McodGuid { get; set; }

    [Column("mcod_DBCno")]
    public short? McodDBCno { get; set; }

    [Column("mcod_SpecRecNo")]
    public int? McodSpecRecNo { get; set; }

    [Column("mcod_Iptal")]
    public bool? McodIptal { get; set; }

    [Column("mcod_fileid")]
    public short? McodFileid { get; set; }

    [Column("mcod_hidden")]
    public bool? McodHidden { get; set; }

    [Column("mcod_kilitli")]
    public bool? McodKilitli { get; set; }

    [Column("mcod_degisti")]
    public bool? McodDegisti { get; set; }

    [Column("mcod_CheckSum")]
    public int? McodCheckSum { get; set; }

    [Column("mcod_create_user")]
    public short? McodCreateUser { get; set; }

    [Column("mcod_create_date")]
    public DateTime? McodCreateDate { get; set; }

    [Column("mcod_lastup_user")]
    public short? McodLastupUser { get; set; }

    [Column("mcod_lastup_date")]
    public DateTime? McodLastupDate { get; set; }

    [Column("mcod_special1")]
    [StringLength(4)]
    public string? McodSpecial1 { get; set; }

    [Column("mcod_special2")]
    [StringLength(4)]
    public string? McodSpecial2 { get; set; }

    [Column("mcod_special3")]
    [StringLength(4)]
    public string? McodSpecial3 { get; set; }

    [Column("mcod_carikod")]
    [StringLength(25)]
    public string? McodCarikod { get; set; }

    [Column("mcod_stokkod")]
    [StringLength(25)]
    public string? McodStokkod { get; set; }

    [Column("mcod_caristok_kod")]
    [StringLength(25)]
    public string? McodCaristokKod { get; set; }

    [Column("mcod_caristok_ismi")]
    [StringLength(50)]
    public string? McodCaristokIsmi { get; set; }

    [Column("mcod_tipi")]
    public byte? McodTipi { get; set; }

    [Column("mcod_herseferindeeslestir_fl")]
    public bool? McodHerseferindeeslestirFl { get; set; }
}
