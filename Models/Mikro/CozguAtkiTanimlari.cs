using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cozgu_atki_tanimlari")]
public class CozguAtkiTanimlari
{
    [Column("ca_Guid")]
    public Guid? CaGuid { get; set; }

    [Column("ca_DBCno")]
    public short? CaDBCno { get; set; }

    [Column("ca_SpecRECno")]
    public int? CaSpecRECno { get; set; }

    [Column("ca_iptal")]
    public bool? CaIptal { get; set; }

    [Column("ca_fileid")]
    public short? CaFileid { get; set; }

    [Column("ca_hidden")]
    public bool? CaHidden { get; set; }

    [Column("ca_kilitli")]
    public bool? CaKilitli { get; set; }

    [Column("ca_degisti")]
    public bool? CaDegisti { get; set; }

    [Column("ca_checksum")]
    public int? CaChecksum { get; set; }

    [Column("ca_create_user")]
    public short? CaCreateUser { get; set; }

    [Column("ca_create_date")]
    public DateTime? CaCreateDate { get; set; }

    [Column("ca_lastup_user")]
    public short? CaLastupUser { get; set; }

    [Column("ca_lastup_date")]
    public DateTime? CaLastupDate { get; set; }

    [Column("ca_special1")]
    [StringLength(4)]
    public string? CaSpecial1 { get; set; }

    [Column("ca_special2")]
    [StringLength(4)]
    public string? CaSpecial2 { get; set; }

    [Column("ca_special3")]
    [StringLength(4)]
    public string? CaSpecial3 { get; set; }

    [Column("ca_cozgu_atki")]
    public byte? CaCozguAtki { get; set; }

    [Column("ca_stok_kodu")]
    [StringLength(25)]
    public string? CaStokKodu { get; set; }

    [Column("ca_rapor_iplik")]
    public byte? CaRaporIplik { get; set; }

    [Column("ca_id")]
    public int? CaId { get; set; }

    [Column("ca_parent_id")]
    public int? CaParentId { get; set; }

    [Column("ca_adi")]
    [StringLength(25)]
    public string? CaAdi { get; set; }

    [Column("ca_tekrar_tel_sayisi")]
    public int? CaTekrarTelSayisi { get; set; }

    [Column("ca_rapor_tipi")]
    public byte? CaRaporTipi { get; set; }

    [Column("ca_rapor_boyu")]
    public double? CaRaporBoyu { get; set; }
}
