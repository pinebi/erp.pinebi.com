using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("is_merkezleri")]
public class IsMerkezleri
{
    [Column("IsM_Guid")]
    public Guid? IsMGuid { get; set; }

    [Column("IsM_DBCno")]
    public short? IsMDBCno { get; set; }

    [Column("IsM_SpecRECNo")]
    public int? IsMSpecRECNo { get; set; }

    [Column("IsM_iptal")]
    public bool? IsMIptal { get; set; }

    [Column("IsM_fileid")]
    public short? IsMFileid { get; set; }

    [Column("IsM_hidden")]
    public bool? IsMHidden { get; set; }

    [Column("IsM_kilitli")]
    public bool? IsMKilitli { get; set; }

    [Column("IsM_degisti")]
    public bool? IsMDegisti { get; set; }

    [Column("IsM_CheckSum")]
    public int? IsMCheckSum { get; set; }

    [Column("IsM_create_user")]
    public short? IsMCreateUser { get; set; }

    [Column("IsM_create_date")]
    public DateTime? IsMCreateDate { get; set; }

    [Column("IsM_lastup_user")]
    public short? IsMLastupUser { get; set; }

    [Column("IsM_lastup_date")]
    public DateTime? IsMLastupDate { get; set; }

    [Column("IsM_special1")]
    [StringLength(4)]
    public string? IsMSpecial1 { get; set; }

    [Column("IsM_special2")]
    [StringLength(4)]
    public string? IsMSpecial2 { get; set; }

    [Column("IsM_special3")]
    [StringLength(4)]
    public string? IsMSpecial3 { get; set; }

    [Column("IsM_Kodu")]
    [StringLength(25)]
    public string? IsMKodu { get; set; }

    [Column("IsM_Aciklama")]
    [StringLength(40)]
    public string? IsMAciklama { get; set; }

    [Column("IsM_GrupKodu1")]
    [StringLength(4)]
    public string? IsMGrupKodu1 { get; set; }

    [Column("IsM_GrupKodu2")]
    [StringLength(4)]
    public string? IsMGrupKodu2 { get; set; }

    [Column("IsM_GrupKodu3")]
    [StringLength(4)]
    public string? IsMGrupKodu3 { get; set; }

    [Column("IsM_GrupKodu4")]
    [StringLength(4)]
    public string? IsMGrupKodu4 { get; set; }

    [Column("IsM_GrupKodu5")]
    [StringLength(4)]
    public string? IsMGrupKodu5 { get; set; }

    [Column("IsM_CalisanSayisi")]
    public byte? IsMCalisanSayisi { get; set; }

    [Column("IsM_MakinaKodu")]
    [StringLength(25)]
    public string? IsMMakinaKodu { get; set; }

    [Column("IsM_SmKodu")]
    [StringLength(25)]
    public string? IsMSmKodu { get; set; }

    [Column("IsM_TakvimKodu")]
    [StringLength(4)]
    public string? IsMTakvimKodu { get; set; }

    [Column("IsM_CokluIsEmri_fl")]
    public bool? IsMCokluIsEmriFl { get; set; }

    [Column("IsM_Kapasitesi")]
    public double? IsMKapasitesi { get; set; }

    [Column("IsM_KapasiteBirimi")]
    [StringLength(10)]
    public string? IsMKapasiteBirimi { get; set; }

    [Column("IsM_Hizi")]
    public double? IsMHizi { get; set; }

    [Column("IsM_HizBirimi")]
    [StringLength(10)]
    public string? IsMHizBirimi { get; set; }

    [Column("IsM_HizZamanBirimi")]
    [StringLength(10)]
    public string? IsMHizZamanBirimi { get; set; }

    [Column("IsM_ZamanPlanlamasiYapilacak")]
    public byte? IsMZamanPlanlamasiYapilacak { get; set; }

    [Column("IsM_Renk")]
    public int? IsMRenk { get; set; }
}
