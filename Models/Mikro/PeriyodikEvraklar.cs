using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("periyodik_evraklar")]
public class PeriyodikEvraklar
{
    [Column("PE_Guid")]
    public Guid? PEGuid { get; set; }

    [Column("PE_DBCno")]
    public short? PEDBCno { get; set; }

    [Column("PE_Spec_Rec_no")]
    public int? PESpecRecNo { get; set; }

    [Column("PE_iptal")]
    public bool? PEIptal { get; set; }

    [Column("PE_fileid")]
    public short? PEFileid { get; set; }

    [Column("PE_hidden")]
    public bool? PEHidden { get; set; }

    [Column("PE_kilitli")]
    public bool? PEKilitli { get; set; }

    [Column("PE_degisti")]
    public bool? PEDegisti { get; set; }

    [Column("PE_checksum")]
    public int? PEChecksum { get; set; }

    [Column("PE_create_user")]
    public short? PECreateUser { get; set; }

    [Column("PE_create_date")]
    public DateTime? PECreateDate { get; set; }

    [Column("PE_lastup_user")]
    public short? PELastupUser { get; set; }

    [Column("PE_lastup_date")]
    public DateTime? PELastupDate { get; set; }

    [Column("PE_special1")]
    [StringLength(4)]
    public string? PESpecial1 { get; set; }

    [Column("PE_special2")]
    [StringLength(4)]
    public string? PESpecial2 { get; set; }

    [Column("PE_special3")]
    [StringLength(4)]
    public string? PESpecial3 { get; set; }

    [Column("PE_firmano")]
    public int? PEFirmano { get; set; }

    [Column("PE_subeno")]
    public int? PESubeno { get; set; }

    [Column("PE_tip")]
    public byte? PETip { get; set; }

    [Column("PE_evraktarihi")]
    public DateTime? PEEvraktarihi { get; set; }

    [Column("PE_evrakseri")]
    [StringLength(50)]
    public string? PEEvrakseri { get; set; }

    [Column("PE_evraksira")]
    public int? PEEvraksira { get; set; }

    [Column("PE_evraksatir")]
    public int? PEEvraksatir { get; set; }

    [Column("PE_belgeno")]
    [StringLength(50)]
    public string? PEBelgeno { get; set; }

    [Column("PE_belge_tarih")]
    public DateTime? PEBelgeTarih { get; set; }

    [Column("PE_carikodu")]
    [StringLength(25)]
    public string? PECarikodu { get; set; }

    [Column("PE_carisrmmrk")]
    [StringLength(25)]
    public string? PECarisrmmrk { get; set; }

    [Column("PE_adresno")]
    public int? PEAdresno { get; set; }

    [Column("PE_sonrakifaturatarihi")]
    public DateTime? PESonrakifaturatarihi { get; set; }

    [Column("PE_periyot")]
    public short? PEPeriyot { get; set; }

    [Column("PE_periyottipi")]
    public byte? PEPeriyottipi { get; set; }

    [Column("PE_adet")]
    public int? PEAdet { get; set; }

    [Column("PE_genelaciklama")]
    [StringLength(40)]
    public string? PEGenelaciklama { get; set; }

    [Column("PE_harekettipi")]
    public byte? PEHarekettipi { get; set; }

    [Column("PE_hareketkodu")]
    [StringLength(25)]
    public string? PEHareketkodu { get; set; }

    [Column("PE_satiraciklama")]
    [StringLength(40)]
    public string? PESatiraciklama { get; set; }

    [Column("PE_miktari")]
    public double? PEMiktari { get; set; }

    [Column("PE_fiyati")]
    public double? PEFiyati { get; set; }

    [Column("PE_iskonto_1")]
    public double? PEIskonto1 { get; set; }

    [Column("PE_iskonto_2")]
    public double? PEIskonto2 { get; set; }

    [Column("PE_iskonto_3")]
    public double? PEIskonto3 { get; set; }

    [Column("PE_iskonto_4")]
    public double? PEIskonto4 { get; set; }

    [Column("PE_iskonto_5")]
    public double? PEIskonto5 { get; set; }

    [Column("PE_iskonto_6")]
    public double? PEIskonto6 { get; set; }

    [Column("PE_masraf_1")]
    public double? PEMasraf1 { get; set; }

    [Column("PE_masraf_2")]
    public double? PEMasraf2 { get; set; }

    [Column("PE_masraf_3")]
    public double? PEMasraf3 { get; set; }

    [Column("PE_masraf_4")]
    public double? PEMasraf4 { get; set; }

    [Column("PE_iskonto1")]
    public byte? PEIskonto1_2 { get; set; }

    [Column("PE_iskonto2")]
    public byte? PEIskonto2_2 { get; set; }

    [Column("PE_iskonto3")]
    public byte? PEIskonto3_2 { get; set; }

    [Column("PE_iskonto4")]
    public byte? PEIskonto4_2 { get; set; }

    [Column("PE_iskonto5")]
    public byte? PEIskonto5_2 { get; set; }

    [Column("PE_iskonto6")]
    public byte? PEIskonto6_2 { get; set; }

    [Column("PE_masraf1")]
    public byte? PEMasraf1_2 { get; set; }

    [Column("PE_masraf2")]
    public byte? PEMasraf2_2 { get; set; }

    [Column("PE_masraf3")]
    public byte? PEMasraf3_2 { get; set; }

    [Column("PE_masraf4")]
    public byte? PEMasraf4_2 { get; set; }

    [Column("PE_isk1")]
    public bool? PEIsk1 { get; set; }

    [Column("PE_isk2")]
    public bool? PEIsk2 { get; set; }

    [Column("PE_isk3")]
    public bool? PEIsk3 { get; set; }

    [Column("PE_isk4")]
    public bool? PEIsk4 { get; set; }

    [Column("PE_isk5")]
    public bool? PEIsk5 { get; set; }

    [Column("PE_isk6")]
    public bool? PEIsk6 { get; set; }

    [Column("PE_mas1")]
    public bool? PEMas1 { get; set; }

    [Column("PE_mas2")]
    public bool? PEMas2 { get; set; }

    [Column("PE_mas3")]
    public bool? PEMas3 { get; set; }

    [Column("PE_mas4")]
    public bool? PEMas4 { get; set; }

    [Column("PE_vergipntr")]
    public byte? PEVergipntr { get; set; }

    [Column("PE_opno")]
    public int? PEOpno { get; set; }

    [Column("PE_grupno")]
    public byte? PEGrupno { get; set; }

    [Column("PE_doviz_cins")]
    public byte? PEDovizCins { get; set; }

    [Column("PE_doviz_kur")]
    public double? PEDovizKur { get; set; }

    [Column("PE_karsidcinsi")]
    public byte? PEKarsidcinsi { get; set; }

    [Column("PE_karsid_kur")]
    public double? PEKarsidKur { get; set; }

    [Column("PE_faturalamakuru")]
    public byte? PEFaturalamakuru { get; set; }

    [Column("PE_srmmrkkodu")]
    [StringLength(25)]
    public string? PESrmmrkkodu { get; set; }

    [Column("PE_projekodu")]
    [StringLength(25)]
    public string? PEProjekodu { get; set; }

    [Column("PE_plasiyerkodu")]
    [StringLength(25)]
    public string? PEPlasiyerkodu { get; set; }

    [Column("PE_pasif")]
    public bool? PEPasif { get; set; }

    [Column("PE_Istisna")]
    [StringLength(5)]
    public string? PEIstisna { get; set; }
}
