using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("makina_bakim_isemirleri")]
public class MakinaBakimIsemirleri
{
    [Column("makisem_Guid")]
    public Guid? MakisemGuid { get; set; }

    [Column("makisem_DBCno")]
    public short? MakisemDBCno { get; set; }

    [Column("makisem_SpecRECno")]
    public int? MakisemSpecRECno { get; set; }

    [Column("makisem_iptal")]
    public bool? MakisemIptal { get; set; }

    [Column("makisem_fileid")]
    public short? MakisemFileid { get; set; }

    [Column("makisem_hidden")]
    public bool? MakisemHidden { get; set; }

    [Column("makisem_kilitli")]
    public bool? MakisemKilitli { get; set; }

    [Column("makisem_degisti")]
    public bool? MakisemDegisti { get; set; }

    [Column("makisem_checksum")]
    public int? MakisemChecksum { get; set; }

    [Column("makisem_create_user")]
    public short? MakisemCreateUser { get; set; }

    [Column("makisem_create_date")]
    public DateTime? MakisemCreateDate { get; set; }

    [Column("makisem_lastup_user")]
    public short? MakisemLastupUser { get; set; }

    [Column("makisem_lastup_date")]
    public DateTime? MakisemLastupDate { get; set; }

    [Column("makisem_special1")]
    [StringLength(4)]
    public string? MakisemSpecial1 { get; set; }

    [Column("makisem_special2")]
    [StringLength(4)]
    public string? MakisemSpecial2 { get; set; }

    [Column("makisem_special3")]
    [StringLength(4)]
    public string? MakisemSpecial3 { get; set; }

    [Column("makisem_kod")]
    [StringLength(25)]
    public string? MakisemKod { get; set; }

    [Column("makisem_isim")]
    [StringLength(40)]
    public string? MakisemIsim { get; set; }

    [Column("makisem_aciklama")]
    [StringLength(70)]
    public string? MakisemAciklama { get; set; }

    [Column("makisem_makina_kod")]
    [StringLength(25)]
    public string? MakisemMakinaKod { get; set; }

    [Column("makisem_sorun_kod")]
    [StringLength(25)]
    public string? MakisemSorunKod { get; set; }

    [Column("makisem_acan_per")]
    [StringLength(25)]
    public string? MakisemAcanPer { get; set; }

    [Column("makisem_bas_zaman")]
    public DateTime? MakisemBasZaman { get; set; }

    [Column("makisem_kapatan_per")]
    [StringLength(25)]
    public string? MakisemKapatanPer { get; set; }

    [Column("makisem_bit_zaman")]
    public DateTime? MakisemBitZaman { get; set; }

    [Column("makisem_durumu")]
    public byte? MakisemDurumu { get; set; }

    [Column("makisem_aciklama1")]
    [StringLength(120)]
    public string? MakisemAciklama1 { get; set; }

    [Column("makisem_aciklama2")]
    [StringLength(120)]
    public string? MakisemAciklama2 { get; set; }

    [Column("makisem_aciklama3")]
    [StringLength(120)]
    public string? MakisemAciklama3 { get; set; }
}
