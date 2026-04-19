using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ziyaret_hareketleri")]
public class ZiyaretHareketleri
{
    [Column("zyrt_Guid")]
    public Guid? ZyrtGuid { get; set; }

    [Column("zyrt_DBCno")]
    public short? ZyrtDBCno { get; set; }

    [Column("zyrt_Spec_Rec_no")]
    public int? ZyrtSpecRecNo { get; set; }

    [Column("zyrt_iptal")]
    public bool? ZyrtIptal { get; set; }

    [Column("zyrt_fileid")]
    public short? ZyrtFileid { get; set; }

    [Column("zyrt_hidden")]
    public bool? ZyrtHidden { get; set; }

    [Column("zyrt_kilitli")]
    public bool? ZyrtKilitli { get; set; }

    [Column("zyrt_degisti")]
    public bool? ZyrtDegisti { get; set; }

    [Column("zyrt_checksum")]
    public int? ZyrtChecksum { get; set; }

    [Column("zyrt_create_user")]
    public short? ZyrtCreateUser { get; set; }

    [Column("zyrt_create_date")]
    public DateTime? ZyrtCreateDate { get; set; }

    [Column("zyrt_lastup_user")]
    public short? ZyrtLastupUser { get; set; }

    [Column("zyrt_lastup_date")]
    public DateTime? ZyrtLastupDate { get; set; }

    [Column("zyrt_special1")]
    [StringLength(4)]
    public string? ZyrtSpecial1 { get; set; }

    [Column("zyrt_special2")]
    [StringLength(4)]
    public string? ZyrtSpecial2 { get; set; }

    [Column("zyrt_special3")]
    [StringLength(4)]
    public string? ZyrtSpecial3 { get; set; }

    [Column("zyrt_firmano")]
    public int? ZyrtFirmano { get; set; }

    [Column("zyrt_subeno")]
    public int? ZyrtSubeno { get; set; }

    [Column("zyrt_bas_zamani")]
    public DateTime? ZyrtBasZamani { get; set; }

    [Column("zyrt_bit_zamani")]
    public DateTime? ZyrtBitZamani { get; set; }

    [Column("zyrt_CariKodu")]
    [StringLength(25)]
    public string? ZyrtCariKodu { get; set; }

    [Column("zyrt_PersonelKodu")]
    [StringLength(25)]
    public string? ZyrtPersonelKodu { get; set; }

    [Column("zyrt_tamamlandi_fl")]
    public bool? ZyrtTamamlandiFl { get; set; }

    [Column("zyrt_AdresNo")]
    public short? ZyrtAdresNo { get; set; }

    [Column("zyrt_Yetkili_ismi")]
    [StringLength(30)]
    public string? ZyrtYetkiliIsmi { get; set; }

    [Column("zyrt_Aciklama")]
    [StringLength(50)]
    public string? ZyrtAciklama { get; set; }

    [Column("zyrt_kodu")]
    [StringLength(25)]
    public string? ZyrtKodu { get; set; }

    [Column("zyrt_Sor_MrkKodu")]
    [StringLength(25)]
    public string? ZyrtSorMrkKodu { get; set; }

    [Column("zyrt_ProjeKodu")]
    [StringLength(25)]
    public string? ZyrtProjeKodu { get; set; }

    [Column("zyrt_bkm_evrak_seri")]
    [StringLength(50)]
    public string? ZyrtBkmEvrakSeri { get; set; }

    [Column("zyrt_bkm_evrak_sira")]
    public int? ZyrtBkmEvrakSira { get; set; }
}
