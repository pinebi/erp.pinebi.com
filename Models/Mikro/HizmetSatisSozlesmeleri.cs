using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("hizmet_satis_sozlesmeleri")]
public class HizmetSatisSozlesmeleri
{
    [Column("HSS_Guid")]
    public Guid? HSSGuid { get; set; }

    [Column("HSS_DBCno")]
    public short? HSSDBCno { get; set; }

    [Column("HSS_Spec_Rec_no")]
    public int? HSSSpecRecNo { get; set; }

    [Column("HSS_iptal")]
    public bool? HSSIptal { get; set; }

    [Column("HSS_fileid")]
    public short? HSSFileid { get; set; }

    [Column("HSS_hidden")]
    public bool? HSSHidden { get; set; }

    [Column("HSS_kilitli")]
    public bool? HSSKilitli { get; set; }

    [Column("HSS_degisti")]
    public bool? HSSDegisti { get; set; }

    [Column("HSS_checksum")]
    public int? HSSChecksum { get; set; }

    [Column("HSS_create_user")]
    public short? HSSCreateUser { get; set; }

    [Column("HSS_create_date")]
    public DateTime? HSSCreateDate { get; set; }

    [Column("HSS_lastup_user")]
    public short? HSSLastupUser { get; set; }

    [Column("HSS_lastup_date")]
    public DateTime? HSSLastupDate { get; set; }

    [Column("HSS_special1")]
    [StringLength(4)]
    public string? HSSSpecial1 { get; set; }

    [Column("HSS_special2")]
    [StringLength(4)]
    public string? HSSSpecial2 { get; set; }

    [Column("HSS_special3")]
    [StringLength(4)]
    public string? HSSSpecial3 { get; set; }

    [Column("HSS_firmano")]
    public int? HSSFirmano { get; set; }

    [Column("HSS_subeno")]
    public int? HSSSubeno { get; set; }

    [Column("HSS_evraktarihi")]
    public DateTime? HSSEvraktarihi { get; set; }

    [Column("HSS_evrakseri")]
    [StringLength(50)]
    public string? HSSEvrakseri { get; set; }

    [Column("HSS_evraksira")]
    public int? HSSEvraksira { get; set; }

    [Column("HSS_evraksatir")]
    public int? HSSEvraksatir { get; set; }

    [Column("HSS_carikodu")]
    [StringLength(25)]
    public string? HSSCarikodu { get; set; }

    [Column("HSS_carisrmmrk")]
    [StringLength(25)]
    public string? HSSCarisrmmrk { get; set; }

    [Column("HSS_tarihi")]
    public DateTime? HSSTarihi { get; set; }

    [Column("HSS_hizmetkodu")]
    [StringLength(25)]
    public string? HSSHizmetkodu { get; set; }

    [Column("HSS_aciklama")]
    [StringLength(40)]
    public string? HSSAciklama { get; set; }

    [Column("HSS_fiyati")]
    public double? HSSFiyati { get; set; }

    [Column("HSS_opno")]
    public int? HSSOpno { get; set; }

    [Column("HSS_kesfatseri")]
    [StringLength(50)]
    public string? HSSKesfatseri { get; set; }

    [Column("HSS_kesfatsira")]
    public int? HSSKesfatsira { get; set; }

    [Column("HSS_srmmrkkodu")]
    [StringLength(25)]
    public string? HSSSrmmrkkodu { get; set; }

    [Column("HSS_projekodu")]
    [StringLength(25)]
    public string? HSSProjekodu { get; set; }

    [Column("HSS_miktari")]
    public double? HSSMiktari { get; set; }

    [Column("HSS_OnaylayanKulNo")]
    public short? HSSOnaylayanKulNo { get; set; }

    [Column("HSS_cagrilabilir_fl")]
    public bool? HSSCagrilabilirFl { get; set; }

    [Column("HSS_carisozlesmekodu")]
    [StringLength(25)]
    public string? HSSCarisozlesmekodu { get; set; }

    [Column("HSS_carisozlesmeakttipi")]
    public byte? HSSCarisozlesmeakttipi { get; set; }

    [Column("HSS_grupno")]
    public byte? HSSGrupno { get; set; }

    [Column("HSS_doviz_cins")]
    public byte? HSSDovizCins { get; set; }

    [Column("HSS_doviz_kur")]
    public double? HSSDovizKur { get; set; }

    [Column("HSS_alt_doviz_kur")]
    public double? HSSAltDovizKur { get; set; }

    [Column("HSS_chasgir_uid")]
    public Guid? HSSChasgirUid { get; set; }

    [Column("HSS_BagliKiraKodu")]
    [StringLength(25)]
    public string? HSSBagliKiraKodu { get; set; }

    [Column("HSS_BagliKiraTipi")]
    public byte? HSSBagliKiraTipi { get; set; }

    [Column("HSS_BagliKiraBlmNo")]
    public byte? HSSBagliKiraBlmNo { get; set; }

    [Column("HSS_BagliKiraBlmDonemNo")]
    public byte? HSSBagliKiraBlmDonemNo { get; set; }

    [Column("HSS_Guncellendi_fl")]
    public bool? HSSGuncellendiFl { get; set; }

    [Column("HSS_GuncOncekifiyati_fl")]
    public double? HSSGuncOncekifiyatiFl { get; set; }

    [Column("HSS_GuncOncekiEndeks_fl")]
    public double? HSSGuncOncekiEndeksFl { get; set; }

    [Column("HSS_saticikodu")]
    [StringLength(25)]
    public string? HSSSaticikodu { get; set; }

    [Column("HSS_belgeno")]
    [StringLength(50)]
    public string? HSSBelgeno { get; set; }

    [Column("HSS_belge_tarih")]
    public DateTime? HSSBelgeTarih { get; set; }
}
