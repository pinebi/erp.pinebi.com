using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_cari_kampanya_tanimlari")]
public class StokCariKampanyaTanimlari
{
    [Column("kampanya_Guid")]
    public Guid? KampanyaGuid { get; set; }

    [Column("kampanya_DBCno")]
    public short? KampanyaDBCno { get; set; }

    [Column("kampanya_SpecRECno")]
    public int? KampanyaSpecRECno { get; set; }

    [Column("kampanya_iptal")]
    public bool? KampanyaIptal { get; set; }

    [Column("kampanya_fileid")]
    public short? KampanyaFileid { get; set; }

    [Column("kampanya_hidden")]
    public bool? KampanyaHidden { get; set; }

    [Column("kampanya_kilitli")]
    public bool? KampanyaKilitli { get; set; }

    [Column("kampanya_degisti")]
    public bool? KampanyaDegisti { get; set; }

    [Column("kampanya_checksum")]
    public int? KampanyaChecksum { get; set; }

    [Column("kampanya_create_user")]
    public short? KampanyaCreateUser { get; set; }

    [Column("kampanya_create_date")]
    public DateTime? KampanyaCreateDate { get; set; }

    [Column("kampanya_lastup_user")]
    public short? KampanyaLastupUser { get; set; }

    [Column("kampanya_lastup_date")]
    public DateTime? KampanyaLastupDate { get; set; }

    [Column("kampanya_special1")]
    [StringLength(4)]
    public string? KampanyaSpecial1 { get; set; }

    [Column("kampanya_special2")]
    [StringLength(4)]
    public string? KampanyaSpecial2 { get; set; }

    [Column("kampanya_special3")]
    [StringLength(4)]
    public string? KampanyaSpecial3 { get; set; }

    [Column("kampanya_stok_kod")]
    [StringLength(4)]
    public string? KampanyaStokKod { get; set; }

    [Column("kampanya_cari_kod")]
    [StringLength(4)]
    public string? KampanyaCariKod { get; set; }

    [Column("kampanya_aciklama")]
    [StringLength(50)]
    public string? KampanyaAciklama { get; set; }

    [Column("kampanya_ilave_vade")]
    public int? KampanyaIlaveVade { get; set; }

    [Column("kampanya_ilave_iskonto")]
    public double? KampanyaIlaveIskonto { get; set; }

    [Column("kampanya_iskonto_no")]
    public byte? KampanyaIskontoNo { get; set; }
}
