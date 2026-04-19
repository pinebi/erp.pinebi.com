using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("istasyon_sayac_hareketleri")]
public class IstasyonSayacHareketleri
{
    [Column("sh_Guid")]
    public Guid? ShGuid { get; set; }

    [Column("sh_DBCno")]
    public short? ShDBCno { get; set; }

    [Column("sh_SpecRECno")]
    public int? ShSpecRECno { get; set; }

    [Column("sh_iptal")]
    public bool? ShIptal { get; set; }

    [Column("sh_fileid")]
    public short? ShFileid { get; set; }

    [Column("sh_hidden")]
    public bool? ShHidden { get; set; }

    [Column("sh_kilitli")]
    public bool? ShKilitli { get; set; }

    [Column("sh_degisti")]
    public bool? ShDegisti { get; set; }

    [Column("sh_checksum")]
    public int? ShChecksum { get; set; }

    [Column("sh_create_user")]
    public short? ShCreateUser { get; set; }

    [Column("sh_create_date")]
    public DateTime? ShCreateDate { get; set; }

    [Column("sh_lastup_user")]
    public short? ShLastupUser { get; set; }

    [Column("sh_lastup_date")]
    public DateTime? ShLastupDate { get; set; }

    [Column("sh_special1")]
    [StringLength(4)]
    public string? ShSpecial1 { get; set; }

    [Column("sh_special2")]
    [StringLength(4)]
    public string? ShSpecial2 { get; set; }

    [Column("sh_special3")]
    [StringLength(4)]
    public string? ShSpecial3 { get; set; }

    [Column("sh_firma_no")]
    public int? ShFirmaNo { get; set; }

    [Column("sh_sube_no")]
    public int? ShSubeNo { get; set; }

    [Column("sh_kodu")]
    [StringLength(25)]
    public string? ShKodu { get; set; }

    [Column("sh_acilis")]
    public double? ShAcilis { get; set; }

    [Column("sh_kapanis")]
    public double? ShKapanis { get; set; }

    [Column("sh_aktarma")]
    public double? ShAktarma { get; set; }

    [Column("sh_birimfiyati")]
    public double? ShBirimfiyati { get; set; }

    [Column("sh_vardiyatarihi")]
    public DateTime? ShVardiyatarihi { get; set; }

    [Column("sh_vardiyano")]
    public byte? ShVardiyano { get; set; }
}
