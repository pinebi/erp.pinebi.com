using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ithalat_dosyalari")]
public class IthalatDosyalari
{
    [Column("ith_Guid")]
    public Guid? IthGuid { get; set; }

    [Column("ith_DBCno")]
    public short? IthDBCno { get; set; }

    [Column("ith_SpecRecNo")]
    public int? IthSpecRecNo { get; set; }

    [Column("ith_iptal")]
    public bool? IthIptal { get; set; }

    [Column("ith_fileid")]
    public short? IthFileid { get; set; }

    [Column("ith_hidden")]
    public bool? IthHidden { get; set; }

    [Column("ith_kilitli")]
    public bool? IthKilitli { get; set; }

    [Column("ith_degisti")]
    public bool? IthDegisti { get; set; }

    [Column("ith_checksum")]
    public int? IthChecksum { get; set; }

    [Column("ith_create_user")]
    public short? IthCreateUser { get; set; }

    [Column("ith_create_date")]
    public DateTime? IthCreateDate { get; set; }

    [Column("ith_lastup_user")]
    public short? IthLastupUser { get; set; }

    [Column("ith_lastup_date")]
    public DateTime? IthLastupDate { get; set; }

    [Column("ith_special1")]
    [StringLength(4)]
    public string? IthSpecial1 { get; set; }

    [Column("ith_special2")]
    [StringLength(4)]
    public string? IthSpecial2 { get; set; }

    [Column("ith_special3")]
    [StringLength(4)]
    public string? IthSpecial3 { get; set; }

    [Column("ith_firmano")]
    public int? IthFirmano { get; set; }

    [Column("ith_subeno")]
    public int? IthSubeno { get; set; }

    [Column("ith_kodu")]
    [StringLength(25)]
    public string? IthKodu { get; set; }

    [Column("ith_ismi")]
    [StringLength(40)]
    public string? IthIsmi { get; set; }

    [Column("ith_satici")]
    [StringLength(25)]
    public string? IthSatici { get; set; }

    [Column("ith_ulketipi")]
    public byte? IthUlketipi { get; set; }

    [Column("ith_ulkekodu")]
    [StringLength(4)]
    public string? IthUlkekodu { get; set; }

    [Column("ith_gumrukkodu")]
    [StringLength(4)]
    public string? IthGumrukkodu { get; set; }

    [Column("ith_teslimsekli")]
    public byte? IthTeslimsekli { get; set; }

    [Column("ith_odemesekli")]
    public byte? IthOdemesekli { get; set; }

    [Column("ith_carigrupno")]
    public byte? IthCarigrupno { get; set; }

    [Column("ith_dovizcinsi")]
    public byte? IthDovizcinsi { get; set; }

    [Column("ith_Araci_Banka")]
    [StringLength(25)]
    public string? IthAraciBanka { get; set; }

    [Column("ith_GGB_tarihi")]
    public DateTime? IthGGBTarihi { get; set; }

    [Column("ith_GGB_no")]
    [StringLength(30)]
    public string? IthGGBNo { get; set; }

    [Column("ith_tasimasekli")]
    public byte? IthTasimasekli { get; set; }

    [Column("ith_vasitano")]
    [StringLength(20)]
    public string? IthVasitano { get; set; }

    [Column("ith_nakliyeci")]
    [StringLength(25)]
    public string? IthNakliyeci { get; set; }

    [Column("ith_gumrukmusaviri")]
    [StringLength(25)]
    public string? IthGumrukmusaviri { get; set; }

    [Column("ith_MuhKodu_1")]
    [StringLength(40)]
    public string? IthMuhKodu1 { get; set; }

    [Column("ith_MuhKodu_2")]
    [StringLength(40)]
    public string? IthMuhKodu2 { get; set; }

    [Column("ith_MuhKodu_3")]
    [StringLength(40)]
    public string? IthMuhKodu3 { get; set; }

    [Column("ith_MuhKodu_4")]
    [StringLength(40)]
    public string? IthMuhKodu4 { get; set; }

    [Column("ith_MuhKodu_5")]
    [StringLength(40)]
    public string? IthMuhKodu5 { get; set; }

    [Column("ith_MuhKodu_6")]
    [StringLength(40)]
    public string? IthMuhKodu6 { get; set; }

    [Column("ith_MuhKodu_7")]
    [StringLength(40)]
    public string? IthMuhKodu7 { get; set; }

    [Column("ith_MuhKodu_8")]
    [StringLength(40)]
    public string? IthMuhKodu8 { get; set; }

    [Column("ith_MuhKodu_9")]
    [StringLength(40)]
    public string? IthMuhKodu9 { get; set; }

    [Column("ith_MuhKodu_10")]
    [StringLength(40)]
    public string? IthMuhKodu10 { get; set; }

    [Column("ith_MalDagitimSekli1")]
    public byte? IthMalDagitimSekli1 { get; set; }

    [Column("ith_MalDagitimSekli2")]
    public byte? IthMalDagitimSekli2 { get; set; }

    [Column("ith_MalDagitimSekli3")]
    public byte? IthMalDagitimSekli3 { get; set; }

    [Column("ith_MalDagitimSekli4")]
    public byte? IthMalDagitimSekli4 { get; set; }

    [Column("ith_MalDagitimSekli5")]
    public byte? IthMalDagitimSekli5 { get; set; }

    [Column("ith_MalDagitimSekli6")]
    public byte? IthMalDagitimSekli6 { get; set; }

    [Column("ith_MalDagitimSekli7")]
    public byte? IthMalDagitimSekli7 { get; set; }

    [Column("ith_MalDagitimSekli8")]
    public byte? IthMalDagitimSekli8 { get; set; }

    [Column("ith_MalDagitimSekli9")]
    public byte? IthMalDagitimSekli9 { get; set; }

    [Column("ith_MalDagitimSek10")]
    public byte? IthMalDagitimSek10 { get; set; }

    [Column("ith_MuhGrupKodu")]
    [StringLength(25)]
    public string? IthMuhGrupKodu { get; set; }

    [Column("ith_MalBedeliMuhKodu")]
    [StringLength(40)]
    public string? IthMalBedeliMuhKodu { get; set; }

    [Column("ith_Mense_ulketipi")]
    public byte? IthMenseUlketipi { get; set; }

    [Column("ith_Mense_ulkekodu")]
    [StringLength(4)]
    public string? IthMenseUlkekodu { get; set; }

    [Column("ith_Araci_CariKodu")]
    [StringLength(25)]
    public string? IthAraciCariKodu { get; set; }

    [Column("ith_Akreditif")]
    [StringLength(25)]
    public string? IthAkreditif { get; set; }

    [Column("ith_kilitli_fl")]
    public bool? IthKilitliFl { get; set; }
}
