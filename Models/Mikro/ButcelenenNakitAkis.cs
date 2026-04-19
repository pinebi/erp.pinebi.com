using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("butcelenen_nakit_akis")]
public class ButcelenenNakitAkis
{
    [Column("bna_Guid")]
    public Guid? BnaGuid { get; set; }

    [Column("bna_DBCno")]
    public short? BnaDBCno { get; set; }

    [Column("bna_SpecRECno")]
    public int? BnaSpecRECno { get; set; }

    [Column("bna_iptal")]
    public bool? BnaIptal { get; set; }

    [Column("bna_fileid")]
    public short? BnaFileid { get; set; }

    [Column("bna_hidden")]
    public bool? BnaHidden { get; set; }

    [Column("bna_kilitli")]
    public bool? BnaKilitli { get; set; }

    [Column("bna_degisti")]
    public bool? BnaDegisti { get; set; }

    [Column("bna_checksum")]
    public int? BnaChecksum { get; set; }

    [Column("bna_create_user")]
    public short? BnaCreateUser { get; set; }

    [Column("bna_create_date")]
    public DateTime? BnaCreateDate { get; set; }

    [Column("bna_lastup_user")]
    public short? BnaLastupUser { get; set; }

    [Column("bna_lastup_date")]
    public DateTime? BnaLastupDate { get; set; }

    [Column("bna_special1")]
    [StringLength(4)]
    public string? BnaSpecial1 { get; set; }

    [Column("bna_special2")]
    [StringLength(4)]
    public string? BnaSpecial2 { get; set; }

    [Column("bna_special3")]
    [StringLength(4)]
    public string? BnaSpecial3 { get; set; }

    [Column("bna_firmano")]
    public int? BnaFirmano { get; set; }

    [Column("bna_giris_cikis")]
    public byte? BnaGirisCikis { get; set; }

    [Column("bna_vade")]
    public DateTime? BnaVade { get; set; }

    [Column("bna_aciklama")]
    [StringLength(50)]
    public string? BnaAciklama { get; set; }

    [Column("bna_proje")]
    [StringLength(25)]
    public string? BnaProje { get; set; }

    [Column("bna_srmmrk")]
    [StringLength(25)]
    public string? BnaSrmmrk { get; set; }
}
