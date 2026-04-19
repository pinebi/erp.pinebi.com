using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("uretim_malzeme_planlama")]
public class UretimMalzemePlanlama
{
    [Column("upl_Guid")]
    public Guid? UplGuid { get; set; }

    [Column("upl_DBCno")]
    public short? UplDBCno { get; set; }

    [Column("upl_SpecRECno")]
    public int? UplSpecRECno { get; set; }

    [Column("upl_iptal")]
    public bool? UplIptal { get; set; }

    [Column("upl_fileid")]
    public short? UplFileid { get; set; }

    [Column("upl_hidden")]
    public bool? UplHidden { get; set; }

    [Column("upl_kilitli")]
    public bool? UplKilitli { get; set; }

    [Column("upl_degisti")]
    public bool? UplDegisti { get; set; }

    [Column("upl_checksum")]
    public int? UplChecksum { get; set; }

    [Column("upl_create_user")]
    public short? UplCreateUser { get; set; }

    [Column("upl_create_date")]
    public DateTime? UplCreateDate { get; set; }

    [Column("upl_lastup_user")]
    public short? UplLastupUser { get; set; }

    [Column("upl_lastup_date")]
    public DateTime? UplLastupDate { get; set; }

    [Column("upl_special1")]
    [StringLength(4)]
    public string? UplSpecial1 { get; set; }

    [Column("upl_special2")]
    [StringLength(4)]
    public string? UplSpecial2 { get; set; }

    [Column("upl_special3")]
    [StringLength(4)]
    public string? UplSpecial3 { get; set; }

    [Column("upl_isemri")]
    [StringLength(25)]
    public string? UplIsemri { get; set; }

    [Column("upl_satirno")]
    public int? UplSatirno { get; set; }

    [Column("upl_uretim_tuket")]
    public byte? UplUretimTuket { get; set; }

    [Column("upl_kodu")]
    [StringLength(25)]
    public string? UplKodu { get; set; }

    [Column("upl_fasoncukod")]
    [StringLength(25)]
    public string? UplFasoncukod { get; set; }

    [Column("upl_har_tarih")]
    public DateTime? UplHarTarih { get; set; }

    [Column("upl_miktar")]
    public double? UplMiktar { get; set; }

    [Column("upl_aciklama")]
    [StringLength(40)]
    public string? UplAciklama { get; set; }

    [Column("upl_depno")]
    public int? UplDepno { get; set; }

    [Column("upl_urstokkod")]
    [StringLength(25)]
    public string? UplUrstokkod { get; set; }

    [Column("upl_uret_miktar")]
    public double? UplUretMiktar { get; set; }

    [Column("upl_parti_kod")]
    [StringLength(25)]
    public string? UplPartiKod { get; set; }

    [Column("upl_lotno")]
    public int? UplLotno { get; set; }

    [Column("upl_sarfturu")]
    public byte? UplSarfturu { get; set; }

    [Column("upl_sarfmiktari")]
    public double? UplSarfmiktari { get; set; }

    [Column("upl_safhano")]
    public short? UplSafhano { get; set; }

    [Column("upl_PlanlamaTipi")]
    public byte? UplPlanlamaTipi { get; set; }

    [Column("upl_nereden")]
    public byte? UplNereden { get; set; }

    [Column("upl_hesap_tipi")]
    public byte? UplHesapTipi { get; set; }

    [Column("upl_gecerlilik_tarihi")]
    public DateTime? UplGecerlilikTarihi { get; set; }

    [Column("upl_rezervasyon_miktari")]
    public double? UplRezervasyonMiktari { get; set; }

    [Column("upl_rezerveden_teslim_edilen")]
    public double? UplRezervedenTeslimEdilen { get; set; }

    [Column("upl_recete_tanim_kodu")]
    [StringLength(25)]
    public string? UplReceteTanimKodu { get; set; }

    [Column("upl_recete_cinsi")]
    public byte? UplReceteCinsi { get; set; }
}
