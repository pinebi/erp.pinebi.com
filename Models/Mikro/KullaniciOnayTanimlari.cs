using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kullanici_onay_tanimlari")]
public class KullaniciOnayTanimlari
{
    [Column("ko_Guid")]
    public Guid? KoGuid { get; set; }

    [Column("ko_DBCno")]
    public short? KoDBCno { get; set; }

    [Column("ko_SpecRECno")]
    public int? KoSpecRECno { get; set; }

    [Column("ko_iptal")]
    public bool? KoIptal { get; set; }

    [Column("ko_fileid")]
    public short? KoFileid { get; set; }

    [Column("ko_hidden")]
    public bool? KoHidden { get; set; }

    [Column("ko_kilitli")]
    public bool? KoKilitli { get; set; }

    [Column("ko_degisti")]
    public bool? KoDegisti { get; set; }

    [Column("ko_checksum")]
    public int? KoChecksum { get; set; }

    [Column("ko_create_user")]
    public short? KoCreateUser { get; set; }

    [Column("ko_create_date")]
    public DateTime? KoCreateDate { get; set; }

    [Column("ko_lastup_user")]
    public short? KoLastupUser { get; set; }

    [Column("ko_lastup_date")]
    public DateTime? KoLastupDate { get; set; }

    [Column("ko_special1")]
    [StringLength(4)]
    public string? KoSpecial1 { get; set; }

    [Column("ko_special2")]
    [StringLength(4)]
    public string? KoSpecial2 { get; set; }

    [Column("ko_special3")]
    [StringLength(4)]
    public string? KoSpecial3 { get; set; }

    [Column("ko_kullanici_no")]
    public int? KoKullaniciNo { get; set; }

    [Column("ko_firma_no")]
    public int? KoFirmaNo { get; set; }

    [Column("ko_evrak_tip")]
    public byte? KoEvrakTip { get; set; }

    [Column("ko_evrak_onaylayabilir")]
    public bool? KoEvrakOnaylayabilir { get; set; }

    [Column("ko_evrak_limiti")]
    public double? KoEvrakLimiti { get; set; }

    [Column("ko_evrak_yetki_tipi")]
    public byte? KoEvrakYetkiTipi { get; set; }

    [Column("ko_evrak_min_onay_sayisi")]
    public byte? KoEvrakMinOnaySayisi { get; set; }
}
