using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("iliskiler")]
public class Iliskiler
{
    [Column("il_Guid")]
    public Guid? IlGuid { get; set; }

    [Column("il_DBCno")]
    public short? IlDBCno { get; set; }

    [Column("il_SpecRECno")]
    public int? IlSpecRECno { get; set; }

    [Column("il_iptal")]
    public bool? IlIptal { get; set; }

    [Column("il_fileid")]
    public short? IlFileid { get; set; }

    [Column("il_hidden")]
    public bool? IlHidden { get; set; }

    [Column("il_kilitli")]
    public bool? IlKilitli { get; set; }

    [Column("il_degisti")]
    public bool? IlDegisti { get; set; }

    [Column("il_checksum")]
    public int? IlChecksum { get; set; }

    [Column("il_create_user")]
    public short? IlCreateUser { get; set; }

    [Column("il_create_date")]
    public DateTime? IlCreateDate { get; set; }

    [Column("il_lastup_user")]
    public short? IlLastupUser { get; set; }

    [Column("il_lastup_date")]
    public DateTime? IlLastupDate { get; set; }

    [Column("il_special1")]
    [StringLength(4)]
    public string? IlSpecial1 { get; set; }

    [Column("il_special2")]
    [StringLength(4)]
    public string? IlSpecial2 { get; set; }

    [Column("il_special3")]
    [StringLength(4)]
    public string? IlSpecial3 { get; set; }

    [Column("il_baszaman")]
    public DateTime? IlBaszaman { get; set; }

    [Column("il_bitzaman")]
    public DateTime? IlBitzaman { get; set; }

    [Column("il_sorumlu_personel")]
    [StringLength(25)]
    public string? IlSorumluPersonel { get; set; }

    [Column("il_iliski_tipi")]
    public byte? IlIliskiTipi { get; set; }

    [Column("il_carikodu")]
    [StringLength(25)]
    public string? IlCarikodu { get; set; }

    [Column("il_adres_no")]
    public int? IlAdresNo { get; set; }

    [Column("il_yetkili_uid")]
    public Guid? IlYetkiliUid { get; set; }

    [Column("il_yetkiliadi")]
    [StringLength(50)]
    public string? IlYetkiliadi { get; set; }

    [Column("il_yer")]
    [StringLength(80)]
    public string? IlYer { get; set; }

    [Column("il_konu")]
    [StringLength(80)]
    public string? IlKonu { get; set; }

    [Column("il_refno")]
    [StringLength(25)]
    public string? IlRefno { get; set; }

    [Column("il_projekodu")]
    [StringLength(25)]
    public string? IlProjekodu { get; set; }

    [Column("il_oncelik")]
    public byte? IlOncelik { get; set; }

    [Column("il_cari_tipi")]
    public byte? IlCariTipi { get; set; }
}
