using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("makina_hareketleri")]
public class MakinaHareketleri
{
    [Column("mkh_Guid")]
    public Guid? MkhGuid { get; set; }

    [Column("mkh_DBCno")]
    public short? MkhDBCno { get; set; }

    [Column("mkh_SpecRECno")]
    public int? MkhSpecRECno { get; set; }

    [Column("mkh_iptal")]
    public bool? MkhIptal { get; set; }

    [Column("mkh_fileid")]
    public short? MkhFileid { get; set; }

    [Column("mkh_hidden")]
    public bool? MkhHidden { get; set; }

    [Column("mkh_kilitli")]
    public bool? MkhKilitli { get; set; }

    [Column("mkh_degisti")]
    public bool? MkhDegisti { get; set; }

    [Column("mkh_checksum")]
    public int? MkhChecksum { get; set; }

    [Column("mkh_create_user")]
    public short? MkhCreateUser { get; set; }

    [Column("mkh_create_date")]
    public DateTime? MkhCreateDate { get; set; }

    [Column("mkh_lastup_user")]
    public short? MkhLastupUser { get; set; }

    [Column("mkh_lastup_date")]
    public DateTime? MkhLastupDate { get; set; }

    [Column("mkh_special1")]
    [StringLength(4)]
    public string? MkhSpecial1 { get; set; }

    [Column("mkh_special2")]
    [StringLength(4)]
    public string? MkhSpecial2 { get; set; }

    [Column("mkh_special3")]
    [StringLength(4)]
    public string? MkhSpecial3 { get; set; }

    [Column("mkh_Evrno_seri")]
    [StringLength(50)]
    public string? MkhEvrnoSeri { get; set; }

    [Column("mkh_Evrno_Sira")]
    public int? MkhEvrnoSira { get; set; }

    [Column("mkh_Satir_no")]
    public int? MkhSatirNo { get; set; }

    [Column("mkh_mak_kodu")]
    [StringLength(25)]
    public string? MkhMakKodu { get; set; }

    [Column("mkh_Mak_srn_kodu")]
    [StringLength(25)]
    public string? MkhMakSrnKodu { get; set; }

    [Column("mkh_Durma_zaman")]
    public DateTime? MkhDurmaZaman { get; set; }

    [Column("mkh_Kalkma_zaman")]
    public DateTime? MkhKalkmaZaman { get; set; }

    [Column("mkh_Aciklama")]
    [StringLength(80)]
    public string? MkhAciklama { get; set; }

    [Column("mkh_Yetkiliop")]
    [StringLength(25)]
    public string? MkhYetkiliop { get; set; }

    [Column("mkh_Bakimelm")]
    [StringLength(25)]
    public string? MkhBakimelm { get; set; }
}
