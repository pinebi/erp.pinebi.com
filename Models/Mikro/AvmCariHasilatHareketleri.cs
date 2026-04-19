using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("avm_cari_hasilat_hareketleri")]
public class AvmCariHasilatHareketleri
{
    [Column("CH_Guid")]
    public Guid? CHGuid { get; set; }

    [Column("CH_DBCno")]
    public short? CHDBCno { get; set; }

    [Column("CH_Spec_Rec_no")]
    public int? CHSpecRecNo { get; set; }

    [Column("CH_iptal")]
    public bool? CHIptal { get; set; }

    [Column("CH_fileid")]
    public short? CHFileid { get; set; }

    [Column("CH_hidden")]
    public bool? CHHidden { get; set; }

    [Column("CH_kilitli")]
    public bool? CHKilitli { get; set; }

    [Column("CH_degisti")]
    public bool? CHDegisti { get; set; }

    [Column("CH_checksum")]
    public int? CHChecksum { get; set; }

    [Column("CH_create_user")]
    public short? CHCreateUser { get; set; }

    [Column("CH_create_date")]
    public DateTime? CHCreateDate { get; set; }

    [Column("CH_lastup_user")]
    public short? CHLastupUser { get; set; }

    [Column("CH_lastup_date")]
    public DateTime? CHLastupDate { get; set; }

    [Column("CH_special1")]
    [StringLength(4)]
    public string? CHSpecial1 { get; set; }

    [Column("CH_special2")]
    [StringLength(4)]
    public string? CHSpecial2 { get; set; }

    [Column("CH_special3")]
    [StringLength(4)]
    public string? CHSpecial3 { get; set; }

    [Column("CH_firmano")]
    public int? CHFirmano { get; set; }

    [Column("CH_subeno")]
    public int? CHSubeno { get; set; }

    [Column("CH_evraktarihi")]
    public DateTime? CHEvraktarihi { get; set; }

    [Column("CH_evrakseri")]
    [StringLength(50)]
    public string? CHEvrakseri { get; set; }

    [Column("CH_evraksira")]
    public int? CHEvraksira { get; set; }

    [Column("CH_evraksatir")]
    public int? CHEvraksatir { get; set; }

    [Column("CH_carikodu")]
    [StringLength(25)]
    public string? CHCarikodu { get; set; }

    [Column("CH_carisrmmrk")]
    [StringLength(25)]
    public string? CHCarisrmmrk { get; set; }

    [Column("CH_tarihi")]
    public DateTime? CHTarihi { get; set; }

    [Column("CH_hizmetkodu")]
    [StringLength(25)]
    public string? CHHizmetkodu { get; set; }

    [Column("CH_aciklama")]
    [StringLength(40)]
    public string? CHAciklama { get; set; }

    [Column("CH_fiyati")]
    public double? CHFiyati { get; set; }

    [Column("CH_grupno")]
    public byte? CHGrupno { get; set; }

    [Column("CH_opno")]
    public int? CHOpno { get; set; }

    [Column("CH_srmmrkkodu")]
    [StringLength(25)]
    public string? CHSrmmrkkodu { get; set; }

    [Column("CH_doviz_cins")]
    public byte? CHDovizCins { get; set; }

    [Column("CH_doviz_kur")]
    public double? CHDovizKur { get; set; }

    [Column("CH_alt_doviz_kur")]
    public double? CHAltDovizKur { get; set; }

    [Column("CH_OnaylayanKulNo")]
    public short? CHOnaylayanKulNo { get; set; }

    [Column("CH_cagrilabilir_fl")]
    public bool? CHCagrilabilirFl { get; set; }

    [Column("CH_CiroKiraOrani")]
    public double? CHCiroKiraOrani { get; set; }

    [Column("CH_CiroKirasi")]
    public double? CHCiroKirasi { get; set; }

    [Column("CH_SozlesmeOlustu_fl")]
    public bool? CHSozlesmeOlustuFl { get; set; }

    [Column("CH_KiraKodu")]
    [StringLength(25)]
    public string? CHKiraKodu { get; set; }

    [Column("CH_FisSayisi")]
    public int? CHFisSayisi { get; set; }

    [Column("CH_AsgariKira")]
    public double? CHAsgariKira { get; set; }

    [Column("CH_KesGerekCiroKirasi")]
    public double? CHKesGerekCiroKirasi { get; set; }

    [Column("CH_KesGerekCiroKuru")]
    public double? CHKesGerekCiroKuru { get; set; }

    [Column("CH_vergi_pntr")]
    public byte? CHVergiPntr { get; set; }

    [Column("CH_vergi")]
    public double? CHVergi { get; set; }

    [Column("CHHesaplandi_fl")]
    public bool? CHHesaplandiFl { get; set; }

    [Column("CH_OrtakGider")]
    public double? CHOrtakGider { get; set; }

    [Column("CH_ProjeKodu")]
    [StringLength(25)]
    public string? CHProjeKodu { get; set; }

    [Column("CH_Dvzfiyati")]
    public double? CHDvzfiyati { get; set; }

    [Column("CH_AnaKesGerekCiroKirasÄ±")]
    public double? CHAnaKesGerekCiroKiras { get; set; }

    [Column("CH_Oran1_fl")]
    public bool? CHOran1Fl { get; set; }

    [Column("CH_Oran2_fl")]
    public bool? CHOran2Fl { get; set; }

    [Column("CH_Oran3_fl")]
    public bool? CHOran3Fl { get; set; }
}
