using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("veri_tabanlari")]
public class VeriTabanlari
{
    [Column("DB_Guid")]
    public Guid? DBGuid { get; set; }

    [Column("DB_DBCno")]
    public short? DBDBCno { get; set; }

    [Column("DB_SpecRECno")]
    public int? DBSpecRECno { get; set; }

    [Column("DB_iptal")]
    public bool? DBIptal { get; set; }

    [Column("DB_fileid")]
    public short? DBFileid { get; set; }

    [Column("DB_hidden")]
    public bool? DBHidden { get; set; }

    [Column("DB_kilitli")]
    public bool? DBKilitli { get; set; }

    [Column("DB_degisti")]
    public bool? DBDegisti { get; set; }

    [Column("DB_checksum")]
    public int? DBChecksum { get; set; }

    [Column("DB_create_user")]
    public short? DBCreateUser { get; set; }

    [Column("DB_create_date")]
    public DateTime? DBCreateDate { get; set; }

    [Column("DB_lastup_user")]
    public short? DBLastupUser { get; set; }

    [Column("DB_lastup_date")]
    public DateTime? DBLastupDate { get; set; }

    [Column("DB_special1")]
    [StringLength(4)]
    public string? DBSpecial1 { get; set; }

    [Column("DB_special2")]
    [StringLength(4)]
    public string? DBSpecial2 { get; set; }

    [Column("DB_special3")]
    [StringLength(4)]
    public string? DBSpecial3 { get; set; }

    [Column("DB_kod")]
    [StringLength(25)]
    public string? DBKod { get; set; }

    [Column("DB_isim")]
    [StringLength(50)]
    public string? DBIsim { get; set; }

    [Column("DB_merkez_server_name")]
    [StringLength(80)]
    public string? DBMerkezServerName { get; set; }

    [Column("DB_merkez_db_kodu")]
    [StringLength(25)]
    public string? DBMerkezDbKodu { get; set; }

    [Column("DB_yerli_doviz_cins")]
    public byte? DBYerliDovizCins { get; set; }

    [Column("DB_alternatif_doviz")]
    public byte? DBAlternatifDoviz { get; set; }

    [Column("DB_online_fl")]
    public bool? DBOnlineFl { get; set; }

    [Column("DB_sube_fl")]
    public bool? DBSubeFl { get; set; }

    [Column("DB_gizli_fl")]
    public bool? DBGizliFl { get; set; }

    [Column("DB_maliyil_baslangic_ayi")]
    public byte? DBMaliyilBaslangicAyi { get; set; }

    [Column("DB_MCeki_seri")]
    [StringLength(2)]
    public string? DBMCekiSeri { get; set; }

    [Column("DB_MSen_seri")]
    [StringLength(2)]
    public string? DBMSenSeri { get; set; }

    [Column("DB_KnCek_seri")]
    [StringLength(2)]
    public string? DBKnCekSeri { get; set; }

    [Column("DB_KnSen_seri")]
    [StringLength(2)]
    public string? DBKnSenSeri { get; set; }

    [Column("DB_MHavSoz_seri")]
    [StringLength(2)]
    public string? DBMHavSozSeri { get; set; }

    [Column("DB_MOdSoz_seri")]
    [StringLength(2)]
    public string? DBMOdSozSeri { get; set; }

    [Column("DB_MKrKrt_seri")]
    [StringLength(2)]
    public string? DBMKrKrtSeri { get; set; }

    [Column("DB_KnHavEmr_seri")]
    [StringLength(2)]
    public string? DBKnHavEmrSeri { get; set; }

    [Column("DB_KnOdEmr_seri")]
    [StringLength(2)]
    public string? DBKnOdEmrSeri { get; set; }

    [Column("DB_KnKrKrt_seri")]
    [StringLength(2)]
    public string? DBKnKrKrtSeri { get; set; }

    [Column("DB_MusTemMek_seri")]
    [StringLength(2)]
    public string? DBMusTemMekSeri { get; set; }

    [Column("DB_FirmTemMek_seri")]
    [StringLength(2)]
    public string? DBFirmTemMekSeri { get; set; }

    [Column("DB_DpztCek_seri")]
    [StringLength(2)]
    public string? DBDpztCekSeri { get; set; }

    [Column("DB_DpztSen_seri")]
    [StringLength(2)]
    public string? DBDpztSenSeri { get; set; }

    [Column("DB_maliyil_takvim_bitisyili")]
    public bool? DBMaliyilTakvimBitisyili { get; set; }

    [Column("DB_VeriAmbarinaBilgiAktar_fl")]
    public bool? DBVeriAmbarinaBilgiAktarFl { get; set; }

    [Column("DB_maliyil_baslangic_gunu")]
    public byte? DBMaliyilBaslangicGunu { get; set; }
}
