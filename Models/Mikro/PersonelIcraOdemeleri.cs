using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_icra_odemeleri")]
public class PersonelIcraOdemeleri
{
    [Column("pio_Guid")]
    public Guid? PioGuid { get; set; }

    [Column("pio_DBCno")]
    public short? PioDBCno { get; set; }

    [Column("pio_SpecRECno")]
    public int? PioSpecRECno { get; set; }

    [Column("pio_iptal")]
    public bool? PioIptal { get; set; }

    [Column("pio_fileid")]
    public short? PioFileid { get; set; }

    [Column("pio_hidden")]
    public bool? PioHidden { get; set; }

    [Column("pio_kilitli")]
    public bool? PioKilitli { get; set; }

    [Column("pio_degisti")]
    public bool? PioDegisti { get; set; }

    [Column("pio_checksum")]
    public int? PioChecksum { get; set; }

    [Column("pio_create_user")]
    public short? PioCreateUser { get; set; }

    [Column("pio_create_date")]
    public DateTime? PioCreateDate { get; set; }

    [Column("pio_lastup_user")]
    public short? PioLastupUser { get; set; }

    [Column("pio_lastup_date")]
    public DateTime? PioLastupDate { get; set; }

    [Column("pio_special1")]
    [StringLength(4)]
    public string? PioSpecial1 { get; set; }

    [Column("pio_special2")]
    [StringLength(4)]
    public string? PioSpecial2 { get; set; }

    [Column("pio_special3")]
    [StringLength(4)]
    public string? PioSpecial3 { get; set; }

    [Column("pio_perkodu")]
    [StringLength(25)]
    public string? PioPerkodu { get; set; }

    [Column("pio_icrasira")]
    public int? PioIcrasira { get; set; }

    [Column("pio_taksitno")]
    public int? PioTaksitno { get; set; }

    [Column("pio_maliyil")]
    public int? PioMaliyil { get; set; }

    [Column("pio_tah_ay")]
    public short? PioTahAy { get; set; }

    [Column("pio_tahno")]
    public short? PioTahno { get; set; }

    [Column("pio_ucretten_odenen")]
    public double? PioUcrettenOdenen { get; set; }

    [Column("pio_izin_ucretten_odenen")]
    public double? PioIzinUcrettenOdenen { get; set; }

    [Column("pio_ekkazanctan_odenen")]
    public double? PioEkkazanctanOdenen { get; set; }

    [Column("pio_sosyarddan_odenen")]
    public double? PioSosyarddanOdenen { get; set; }

    [Column("pio_tazminattan_odenen")]
    public double? PioTazminattanOdenen { get; set; }

    [Column("pio_agiden_odenen")]
    public double? PioAgidenOdenen { get; set; }

    [Column("pio_virman_uid")]
    public Guid? PioVirmanUid { get; set; }

    [Column("pio_odeme_uid")]
    public Guid? PioOdemeUid { get; set; }
}
