using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Sistem;

[Table("pine_firmalar")]
public class PineFirmalar : BaseEntity
{
    [Column("frm_kod")]
    [StringLength(20)]
    public string? FrmKod { get; set; }

    [Column("frm_unvan")]
    [StringLength(300)]
    public string? FrmUnvan { get; set; }

    [Column("frm_vergi_no")]
    [StringLength(20)]
    public string? FrmVergiNo { get; set; }

    [Column("frm_vergi_dairesi")]
    [StringLength(100)]
    public string? FrmVergiDairesi { get; set; }

    [Column("frm_tel")]
    [StringLength(50)]
    public string? FrmTel { get; set; }

    [Column("frm_email")]
    [StringLength(200)]
    public string? FrmEmail { get; set; }

    [Column("frm_adres")]
    [StringLength(500)]
    public string? FrmAdres { get; set; }

    [Column("frm_sehir")]
    [StringLength(50)]
    public string? FrmSehir { get; set; }

    [Column("frm_ilce")]
    [StringLength(50)]
    public string? FrmIlce { get; set; }

    [Column("frm_posta_kodu")]
    [StringLength(10)]
    public string? FrmPostaKodu { get; set; }

    [Column("frm_web")]
    [StringLength(200)]
    public string? FrmWeb { get; set; }

    [Column("frm_logo_url")]
    [StringLength(500)]
    public string? FrmLogoUrl { get; set; }

    [Column("frm_sirket_tipi")]
    [StringLength(50)]
    public string? FrmSirketTipi { get; set; }

    [Column("frm_para_birimi")]
    [StringLength(5)]
    public string? FrmParaBirimi { get; set; } = "TL";

    [Column("frm_kdv_mukellef")]
    public bool FrmKdvMukellef { get; set; } = true;

    [Column("frm_efatura_mukellef")]
    public bool FrmEfaturaMukellef { get; set; }

    [Column("frm_eirsaliye_mukellef")]
    public bool FrmEirsaliyeMukellef { get; set; }

    [Column("frm_mersis_no")]
    [StringLength(20)]
    public string? FrmMersisNo { get; set; }

    [Column("frm_ticaret_sicil_no")]
    [StringLength(20)]
    public string? FrmTicaretSicilNo { get; set; }

    [Column("frm_aktif")]
    public bool FrmAktif { get; set; } = true;
}
