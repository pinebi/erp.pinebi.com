using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cihaz_sorunlari")]
public class CihazSorunlari
{
    [Column("chs_Guid")]
    public Guid? ChsGuid { get; set; }

    [Column("chs_DBCno")]
    public short? ChsDBCno { get; set; }

    [Column("chs_Spec_Rec_no")]
    public int? ChsSpecRecNo { get; set; }

    [Column("chs_iptal")]
    public bool? ChsIptal { get; set; }

    [Column("chs_fileid")]
    public short? ChsFileid { get; set; }

    [Column("chs_hidden")]
    public bool? ChsHidden { get; set; }

    [Column("chs_kilitli")]
    public bool? ChsKilitli { get; set; }

    [Column("chs_degisti")]
    public bool? ChsDegisti { get; set; }

    [Column("chs_checksum")]
    public int? ChsChecksum { get; set; }

    [Column("chs_create_user")]
    public short? ChsCreateUser { get; set; }

    [Column("chs_create_date")]
    public DateTime? ChsCreateDate { get; set; }

    [Column("chs_lastup_user")]
    public short? ChsLastupUser { get; set; }

    [Column("chs_lastup_date")]
    public DateTime? ChsLastupDate { get; set; }

    [Column("chs_special1")]
    [StringLength(4)]
    public string? ChsSpecial1 { get; set; }

    [Column("chs_special2")]
    [StringLength(4)]
    public string? ChsSpecial2 { get; set; }

    [Column("chs_special3")]
    [StringLength(4)]
    public string? ChsSpecial3 { get; set; }

    [Column("chs_kodu")]
    [StringLength(25)]
    public string? ChsKodu { get; set; }

    [Column("chs_cihaz")]
    [StringLength(25)]
    public string? ChsCihaz { get; set; }

    [Column("chs_sorun")]
    [StringLength(50)]
    public string? ChsSorun { get; set; }

    [Column("chs_stok_ana_grup_kodu")]
    [StringLength(25)]
    public string? ChsStokAnaGrupKodu { get; set; }

    [Column("chs_grup_kodu")]
    [StringLength(25)]
    public string? ChsGrupKodu { get; set; }

    [Column("chs_sinif_kodu")]
    [StringLength(25)]
    public string? ChsSinifKodu { get; set; }

    [Column("chs_sorun_giderme_suresi")]
    public int? ChsSorunGidermeSuresi { get; set; }
}
