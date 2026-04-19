using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("odeme_listesi")]
public class OdemeListesi
{
    [Column("ol_Guid")]
    public Guid? OlGuid { get; set; }

    [Column("ol_DBCno")]
    public short? OlDBCno { get; set; }

    [Column("ol_SpecRECno")]
    public int? OlSpecRECno { get; set; }

    [Column("ol_iptal")]
    public bool? OlIptal { get; set; }

    [Column("ol_fileid")]
    public short? OlFileid { get; set; }

    [Column("ol_hidden")]
    public bool? OlHidden { get; set; }

    [Column("ol_kilitli")]
    public bool? OlKilitli { get; set; }

    [Column("ol_degisti")]
    public bool? OlDegisti { get; set; }

    [Column("ol_checksum")]
    public int? OlChecksum { get; set; }

    [Column("ol_create_user")]
    public short? OlCreateUser { get; set; }

    [Column("ol_create_date")]
    public DateTime? OlCreateDate { get; set; }

    [Column("ol_lastup_user")]
    public short? OlLastupUser { get; set; }

    [Column("ol_lastup_date")]
    public DateTime? OlLastupDate { get; set; }

    [Column("ol_special1")]
    [StringLength(4)]
    public string? OlSpecial1 { get; set; }

    [Column("ol_special2")]
    [StringLength(4)]
    public string? OlSpecial2 { get; set; }

    [Column("ol_special3")]
    [StringLength(4)]
    public string? OlSpecial3 { get; set; }

    [Column("ol_Carikodu")]
    [StringLength(25)]
    public string? OlCarikodu { get; set; }

    [Column("ol_Tutari")]
    public double? OlTutari { get; set; }

    [Column("ol_OrtVadeTarih")]
    public DateTime? OlOrtVadeTarih { get; set; }

    [Column("ol_CekList1")]
    [StringLength(25)]
    public string? OlCekList1 { get; set; }

    [Column("ol_CekList2")]
    [StringLength(25)]
    public string? OlCekList2 { get; set; }

    [Column("ol_CekList3")]
    [StringLength(25)]
    public string? OlCekList3 { get; set; }

    [Column("ol_CekList4")]
    [StringLength(25)]
    public string? OlCekList4 { get; set; }

    [Column("ol_CekList5")]
    [StringLength(25)]
    public string? OlCekList5 { get; set; }

    [Column("ol_CekList6")]
    [StringLength(25)]
    public string? OlCekList6 { get; set; }

    [Column("ol_CekList7")]
    [StringLength(25)]
    public string? OlCekList7 { get; set; }

    [Column("ol_CekList8")]
    [StringLength(25)]
    public string? OlCekList8 { get; set; }

    [Column("ol_CekList9")]
    [StringLength(25)]
    public string? OlCekList9 { get; set; }

    [Column("ol_CekList10")]
    [StringLength(25)]
    public string? OlCekList10 { get; set; }

    [Column("ol_OdenenTutar")]
    public double? OlOdenenTutar { get; set; }

    [Column("ol_OdenenVade")]
    public DateTime? OlOdenenVade { get; set; }

    [Column("ol_OdemeCinsi")]
    public byte? OlOdemeCinsi { get; set; }

    [Column("ol_KasBankKd1")]
    [StringLength(25)]
    public string? OlKasBankKd1 { get; set; }

    [Column("ol_KasBankKd2")]
    [StringLength(25)]
    public string? OlKasBankKd2 { get; set; }

    [Column("ol_KasBankKd3")]
    [StringLength(25)]
    public string? OlKasBankKd3 { get; set; }

    [Column("ol_KasBankKd4")]
    [StringLength(25)]
    public string? OlKasBankKd4 { get; set; }

    [Column("ol_KasBankKd5")]
    [StringLength(25)]
    public string? OlKasBankKd5 { get; set; }

    [Column("ol_KasBankKd6")]
    [StringLength(25)]
    public string? OlKasBankKd6 { get; set; }

    [Column("ol_KasBankKd7")]
    [StringLength(25)]
    public string? OlKasBankKd7 { get; set; }

    [Column("ol_KasBankKd8")]
    [StringLength(25)]
    public string? OlKasBankKd8 { get; set; }

    [Column("ol_KasBankKd9")]
    [StringLength(25)]
    public string? OlKasBankKd9 { get; set; }

    [Column("ol_KasBankKd10")]
    [StringLength(25)]
    public string? OlKasBankKd10 { get; set; }

    [Column("ol_KesideYeri")]
    [StringLength(14)]
    public string? OlKesideYeri { get; set; }

    [Column("ol_opsiyongun")]
    public int? OlOpsiyongun { get; set; }

    [Column("ol_carigrup")]
    public byte? OlCarigrup { get; set; }

    [Column("ol_caridovizcins")]
    public byte? OlCaridovizcins { get; set; }

    [Column("ol_srmmrkkodu")]
    [StringLength(25)]
    public string? OlSrmmrkkodu { get; set; }

    [Column("ol_karsisrmmrkkodu")]
    [StringLength(25)]
    public string? OlKarsisrmmrkkodu { get; set; }

    [Column("ol_aciklama")]
    [StringLength(40)]
    public string? OlAciklama { get; set; }

    [Column("ol_onaylayankulno")]
    public short? OlOnaylayankulno { get; set; }

    [Column("ol_onayli_fl")]
    public bool? OlOnayliFl { get; set; }

    [Column("ol_bakiye_sekli")]
    public byte? OlBakiyeSekli { get; set; }

    [Column("ol_odeme_sekli")]
    public byte? OlOdemeSekli { get; set; }

    [Column("ol_alacakfatevrtip")]
    public byte? OlAlacakfatevrtip { get; set; }

    [Column("ol_alacakfatevrno_seri")]
    [StringLength(50)]
    public string? OlAlacakfatevrnoSeri { get; set; }

    [Column("ol_alacakfatevrno_sira")]
    public int? OlAlacakfatevrnoSira { get; set; }

    [Column("ol_alacakfat_uid")]
    public Guid? OlAlacakfatUid { get; set; }

    [Column("ol_alacakfatvadetarihi")]
    public DateTime? OlAlacakfatvadetarihi { get; set; }

    [Column("ol_odemeevragi_uid")]
    public Guid? OlOdemeevragiUid { get; set; }
}
