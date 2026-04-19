using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("dagitim_kontrol")]
public class DagitimKontrol
{
    [Column("dkn_Guid")]
    public Guid? DknGuid { get; set; }

    [Column("dkn_DBCno")]
    public short? DknDBCno { get; set; }

    [Column("dkn_SpecRECno")]
    public int? DknSpecRECno { get; set; }

    [Column("dkn_iptal")]
    public bool? DknIptal { get; set; }

    [Column("dkn_fileid")]
    public short? DknFileid { get; set; }

    [Column("dkn_hidden")]
    public bool? DknHidden { get; set; }

    [Column("dkn_kilitli")]
    public bool? DknKilitli { get; set; }

    [Column("dkn_degisti")]
    public bool? DknDegisti { get; set; }

    [Column("dkn_checksum")]
    public int? DknChecksum { get; set; }

    [Column("dkn_create_user")]
    public short? DknCreateUser { get; set; }

    [Column("dkn_create_date")]
    public DateTime? DknCreateDate { get; set; }

    [Column("dkn_lastup_user")]
    public short? DknLastupUser { get; set; }

    [Column("dkn_lastup_date")]
    public DateTime? DknLastupDate { get; set; }

    [Column("dkn_special1")]
    [StringLength(4)]
    public string? DknSpecial1 { get; set; }

    [Column("dkn_special2")]
    [StringLength(4)]
    public string? DknSpecial2 { get; set; }

    [Column("dkn_special3")]
    [StringLength(4)]
    public string? DknSpecial3 { get; set; }

    [Column("dkn_borclu_hesap_kodu")]
    [StringLength(25)]
    public string? DknBorcluHesapKodu { get; set; }

    [Column("dkn_borclu_srm_merkezi")]
    [StringLength(25)]
    public string? DknBorcluSrmMerkezi { get; set; }

    [Column("dkn_borclu_proje")]
    [StringLength(25)]
    public string? DknBorcluProje { get; set; }

    [Column("dkn_alacakli_hesap_kodu")]
    [StringLength(25)]
    public string? DknAlacakliHesapKodu { get; set; }

    [Column("dkn_alacakli_srm_merkezi")]
    [StringLength(25)]
    public string? DknAlacakliSrmMerkezi { get; set; }

    [Column("dkn_alacakli_proje")]
    [StringLength(25)]
    public string? DknAlacakliProje { get; set; }

    [Column("dkn_dagitim_anahtar_kodu")]
    [StringLength(25)]
    public string? DknDagitimAnahtarKodu { get; set; }

    [Column("dkn_toplam_anahtar")]
    public double? DknToplamAnahtar { get; set; }

    [Column("dkn_anahtar")]
    public double? DknAnahtar { get; set; }

    [Column("dkn_dagitilan_tutar_ana")]
    public double? DknDagitilanTutarAna { get; set; }

    [Column("dkn_dagitilan_tutar_alt")]
    public double? DknDagitilanTutarAlt { get; set; }

    [Column("dkn_dagitilan_tutar_orj")]
    public double? DknDagitilanTutarOrj { get; set; }
}
