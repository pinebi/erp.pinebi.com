using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("hesap_merkez_anahtar_tanimlari")]
public class HesapMerkezAnahtarTanimlari
{
    [Column("hma_Guid")]
    public Guid? HmaGuid { get; set; }

    [Column("hma_DBCno")]
    public short? HmaDBCno { get; set; }

    [Column("hma_SpecRECNo")]
    public int? HmaSpecRECNo { get; set; }

    [Column("hma_iptal")]
    public bool? HmaIptal { get; set; }

    [Column("hma_fileid")]
    public short? HmaFileid { get; set; }

    [Column("hma_hidden")]
    public bool? HmaHidden { get; set; }

    [Column("hma_kilitli")]
    public bool? HmaKilitli { get; set; }

    [Column("hma_degisti")]
    public bool? HmaDegisti { get; set; }

    [Column("hma_checksum")]
    public int? HmaChecksum { get; set; }

    [Column("hma_create_user")]
    public short? HmaCreateUser { get; set; }

    [Column("hma_create_date")]
    public DateTime? HmaCreateDate { get; set; }

    [Column("hma_lastup_user")]
    public short? HmaLastupUser { get; set; }

    [Column("hma_lastup_date")]
    public DateTime? HmaLastupDate { get; set; }

    [Column("hma_special1")]
    [StringLength(4)]
    public string? HmaSpecial1 { get; set; }

    [Column("hma_special2")]
    [StringLength(4)]
    public string? HmaSpecial2 { get; set; }

    [Column("hma_special3")]
    [StringLength(4)]
    public string? HmaSpecial3 { get; set; }

    [Column("hma_hesap_kodu")]
    [StringLength(25)]
    public string? HmaHesapKodu { get; set; }

    [Column("hma_sor_merk_kodu")]
    [StringLength(25)]
    public string? HmaSorMerkKodu { get; set; }

    [Column("hma_dag_anah_kodu")]
    [StringLength(25)]
    public string? HmaDagAnahKodu { get; set; }

    [Column("hma_maliyet_dagitim_sekli")]
    public byte? HmaMaliyetDagitimSekli { get; set; }
}
