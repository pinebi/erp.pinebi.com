using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("uretim_operasyonlari")]
public class UretimOperasyonlari
{
    [Column("Op_Guid")]
    public Guid? OpGuid { get; set; }

    [Column("Op_DBCno")]
    public short? OpDBCno { get; set; }

    [Column("Op_SpecRECNo")]
    public int? OpSpecRECNo { get; set; }

    [Column("Op_iptal")]
    public bool? OpIptal { get; set; }

    [Column("Op_fileid")]
    public short? OpFileid { get; set; }

    [Column("Op_hidden")]
    public bool? OpHidden { get; set; }

    [Column("Op_kilitli")]
    public bool? OpKilitli { get; set; }

    [Column("Op_degisti")]
    public bool? OpDegisti { get; set; }

    [Column("Op_CheckSum")]
    public int? OpCheckSum { get; set; }

    [Column("Op_create_user")]
    public short? OpCreateUser { get; set; }

    [Column("Op_create_date")]
    public DateTime? OpCreateDate { get; set; }

    [Column("Op_lastup_user")]
    public short? OpLastupUser { get; set; }

    [Column("Op_lastup_date")]
    public DateTime? OpLastupDate { get; set; }

    [Column("Op_special1")]
    [StringLength(4)]
    public string? OpSpecial1 { get; set; }

    [Column("Op_special2")]
    [StringLength(4)]
    public string? OpSpecial2 { get; set; }

    [Column("Op_special3")]
    [StringLength(4)]
    public string? OpSpecial3 { get; set; }

    [Column("Op_Kodu")]
    [StringLength(25)]
    public string? OpKodu { get; set; }

    [Column("Op_Aciklama")]
    [StringLength(50)]
    public string? OpAciklama { get; set; }

    [Column("Op_Birimi")]
    public byte? OpBirimi { get; set; }

    [Column("Op_UrunGirisOlustur")]
    public bool? OpUrunGirisOlustur { get; set; }

    [Column("Op_UretimeSevkOlustur")]
    public bool? OpUretimeSevkOlustur { get; set; }

    [Column("Op_SabitMaliyet")]
    public double? OpSabitMaliyet { get; set; }

    [Column("Op_DegiskenMaliyet")]
    public double? OpDegiskenMaliyet { get; set; }

    [Column("Op_SorumlulukMerkezi")]
    [StringLength(25)]
    public string? OpSorumlulukMerkezi { get; set; }

    [Column("Op_AraOperasyon")]
    public bool? OpAraOperasyon { get; set; }

    [Column("Op_PlanlamaTarihiniEtkilemez")]
    public bool? OpPlanlamaTarihiniEtkilemez { get; set; }

    [Column("Op_IscilikMaliyet")]
    public double? OpIscilikMaliyet { get; set; }

    [Column("Op_GenelUretimMaliyet")]
    public double? OpGenelUretimMaliyet { get; set; }

    [Column("Op_ZamanPlanlamasiYapilacak")]
    public byte? OpZamanPlanlamasiYapilacak { get; set; }

    [Column("Op_MiktarSureyiEtkilemez")]
    public bool? OpMiktarSureyiEtkilemez { get; set; }
}
