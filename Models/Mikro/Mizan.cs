using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("mizan")]
public class Mizan
{
    [Column("Mizan_Guid")]
    public Guid? MizanGuid { get; set; }

    [Column("Mizan_DBCno")]
    public short? MizanDBCno { get; set; }

    [Column("Mizan_SpecRECNo")]
    public int? MizanSpecRECNo { get; set; }

    [Column("Mizan_iptal")]
    public bool? MizanIptal { get; set; }

    [Column("Mizan_fileid")]
    public short? MizanFileid { get; set; }

    [Column("Mizan_hidden")]
    public bool? MizanHidden { get; set; }

    [Column("Mizan_kilitli")]
    public bool? MizanKilitli { get; set; }

    [Column("Mizan_degisti")]
    public bool? MizanDegisti { get; set; }

    [Column("Mizan_CheckSum")]
    public int? MizanCheckSum { get; set; }

    [Column("Mizan_create_user")]
    public short? MizanCreateUser { get; set; }

    [Column("Mizan_create_date")]
    public DateTime? MizanCreateDate { get; set; }

    [Column("Mizan_lastup_user")]
    public short? MizanLastupUser { get; set; }

    [Column("Mizan_lastup_date")]
    public DateTime? MizanLastupDate { get; set; }

    [Column("Mizan_special1")]
    [StringLength(4)]
    public string? MizanSpecial1 { get; set; }

    [Column("Mizan_special2")]
    [StringLength(4)]
    public string? MizanSpecial2 { get; set; }

    [Column("Mizan_special3")]
    [StringLength(4)]
    public string? MizanSpecial3 { get; set; }

    [Column("Mizan_hesap_kodu")]
    [StringLength(25)]
    public string? MizanHesapKodu { get; set; }

    [Column("Mizan_sor_merk_kodu")]
    [StringLength(25)]
    public string? MizanSorMerkKodu { get; set; }

    [Column("Mizan_Borc0")]
    public double? MizanBorc0 { get; set; }

    [Column("Mizan_Borc1")]
    public double? MizanBorc1 { get; set; }

    [Column("Mizan_Borc2")]
    public double? MizanBorc2 { get; set; }

    [Column("Mizan_Borc3")]
    public double? MizanBorc3 { get; set; }

    [Column("Mizan_Borc4")]
    public double? MizanBorc4 { get; set; }

    [Column("Mizan_Borc5")]
    public double? MizanBorc5 { get; set; }

    [Column("Mizan_Borc6")]
    public double? MizanBorc6 { get; set; }

    [Column("Mizan_Alacak0")]
    public double? MizanAlacak0 { get; set; }

    [Column("Mizan_Alacak1")]
    public double? MizanAlacak1 { get; set; }

    [Column("Mizan_Alacak2")]
    public double? MizanAlacak2 { get; set; }

    [Column("Mizan_Alacak3")]
    public double? MizanAlacak3 { get; set; }

    [Column("Mizan_Alacak4")]
    public double? MizanAlacak4 { get; set; }

    [Column("Mizan_Alacak5")]
    public double? MizanAlacak5 { get; set; }

    [Column("Mizan_Alacak6")]
    public double? MizanAlacak6 { get; set; }

    [Column("Mizan_Borcbakiye0")]
    public double? MizanBorcbakiye0 { get; set; }

    [Column("Mizan_Borcbakiye1")]
    public double? MizanBorcbakiye1 { get; set; }

    [Column("Mizan_Borcbakiye2")]
    public double? MizanBorcbakiye2 { get; set; }

    [Column("Mizan_Borcbakiye3")]
    public double? MizanBorcbakiye3 { get; set; }

    [Column("Mizan_Borcbakiye4")]
    public double? MizanBorcbakiye4 { get; set; }

    [Column("Mizan_Borcbakiye5")]
    public double? MizanBorcbakiye5 { get; set; }

    [Column("Mizan_Borcbakiye6")]
    public double? MizanBorcbakiye6 { get; set; }

    [Column("Mizan_AlacakBakiye0")]
    public double? MizanAlacakBakiye0 { get; set; }

    [Column("Mizan_AlacakBakiye1")]
    public double? MizanAlacakBakiye1 { get; set; }

    [Column("Mizan_AlacakBakiye2")]
    public double? MizanAlacakBakiye2 { get; set; }

    [Column("Mizan_AlacakBakiye3")]
    public double? MizanAlacakBakiye3 { get; set; }

    [Column("Mizan_AlacakBakiye4")]
    public double? MizanAlacakBakiye4 { get; set; }

    [Column("Mizan_AlacakBakiye5")]
    public double? MizanAlacakBakiye5 { get; set; }

    [Column("Mizan_AlacakBakiye6")]
    public double? MizanAlacakBakiye6 { get; set; }
}
