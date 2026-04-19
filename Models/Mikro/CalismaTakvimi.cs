using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("calisma_takvimi")]
public class CalismaTakvimi
{
    [Column("cal_Guid")]
    public Guid? CalGuid { get; set; }

    [Column("cal_DBCno")]
    public short? CalDBCno { get; set; }

    [Column("cal_SpecRecNo")]
    public int? CalSpecRecNo { get; set; }

    [Column("cal_iptal")]
    public bool? CalIptal { get; set; }

    [Column("cal_fileid")]
    public short? CalFileid { get; set; }

    [Column("cal_hidden")]
    public bool? CalHidden { get; set; }

    [Column("cal_kilitli")]
    public bool? CalKilitli { get; set; }

    [Column("cal_degisti")]
    public bool? CalDegisti { get; set; }

    [Column("cal_checksum")]
    public int? CalChecksum { get; set; }

    [Column("cal_create_user")]
    public short? CalCreateUser { get; set; }

    [Column("cal_create_date")]
    public DateTime? CalCreateDate { get; set; }

    [Column("cal_lastup_user")]
    public short? CalLastupUser { get; set; }

    [Column("cal_lastup_date")]
    public DateTime? CalLastupDate { get; set; }

    [Column("cal_special1")]
    [StringLength(4)]
    public string? CalSpecial1 { get; set; }

    [Column("cal_special2")]
    [StringLength(4)]
    public string? CalSpecial2 { get; set; }

    [Column("cal_special3")]
    [StringLength(4)]
    public string? CalSpecial3 { get; set; }

    [Column("cal_tipi")]
    public byte? CalTipi { get; set; }

    [Column("cal_baslangictarihi")]
    public DateTime? CalBaslangictarihi { get; set; }

    [Column("cal_bitistarihi")]
    public DateTime? CalBitistarihi { get; set; }

    [Column("cal_aciklama")]
    [StringLength(80)]
    public string? CalAciklama { get; set; }
}
