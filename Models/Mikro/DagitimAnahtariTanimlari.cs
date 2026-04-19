using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("dagitim_anahtari_tanimlari")]
public class DagitimAnahtariTanimlari
{
    [Column("dan_Guid")]
    public Guid? DanGuid { get; set; }

    [Column("dan_DBCno")]
    public short? DanDBCno { get; set; }

    [Column("dan_SpecRECno")]
    public int? DanSpecRECno { get; set; }

    [Column("dan_iptal")]
    public bool? DanIptal { get; set; }

    [Column("dan_fileid")]
    public short? DanFileid { get; set; }

    [Column("dan_hidden")]
    public bool? DanHidden { get; set; }

    [Column("dan_kilitli")]
    public bool? DanKilitli { get; set; }

    [Column("dan_degisti")]
    public bool? DanDegisti { get; set; }

    [Column("dan_checksum")]
    public int? DanChecksum { get; set; }

    [Column("dan_create_user")]
    public short? DanCreateUser { get; set; }

    [Column("dan_create_date")]
    public DateTime? DanCreateDate { get; set; }

    [Column("dan_lastup_user")]
    public short? DanLastupUser { get; set; }

    [Column("dan_lastup_date")]
    public DateTime? DanLastupDate { get; set; }

    [Column("dan_special1")]
    [StringLength(4)]
    public string? DanSpecial1 { get; set; }

    [Column("dan_special2")]
    [StringLength(4)]
    public string? DanSpecial2 { get; set; }

    [Column("dan_special3")]
    [StringLength(4)]
    public string? DanSpecial3 { get; set; }

    [Column("dan_kod")]
    [StringLength(25)]
    public string? DanKod { get; set; }

    [Column("dan_gecerliliktarihi")]
    public DateTime? DanGecerliliktarihi { get; set; }

    [Column("dan_satirno")]
    public int? DanSatirno { get; set; }

    [Column("dan_ismi")]
    [StringLength(50)]
    public string? DanIsmi { get; set; }

    [Column("dan_tipi")]
    public byte? DanTipi { get; set; }

    [Column("dan_hesap_kodu")]
    [StringLength(25)]
    public string? DanHesapKodu { get; set; }

    [Column("dan_srmmrk_kodu")]
    [StringLength(25)]
    public string? DanSrmmrkKodu { get; set; }

    [Column("dan_proje_kodu")]
    [StringLength(25)]
    public string? DanProjeKodu { get; set; }

    [Column("dan_puan")]
    public double? DanPuan { get; set; }

    [Column("dan_puantipi")]
    public byte? DanPuantipi { get; set; }
}
