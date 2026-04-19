using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_icra_tanimlari")]
public class PersonelIcraTanimlari
{
    [Column("pit_Guid")]
    public Guid? PitGuid { get; set; }

    [Column("pit_DBCno")]
    public short? PitDBCno { get; set; }

    [Column("pit_SpecRECno")]
    public int? PitSpecRECno { get; set; }

    [Column("pit_iptal")]
    public bool? PitIptal { get; set; }

    [Column("pit_fileid")]
    public short? PitFileid { get; set; }

    [Column("pit_hidden")]
    public bool? PitHidden { get; set; }

    [Column("pit_kilitli")]
    public bool? PitKilitli { get; set; }

    [Column("pit_degisti")]
    public bool? PitDegisti { get; set; }

    [Column("pit_checksum")]
    public int? PitChecksum { get; set; }

    [Column("pit_create_user")]
    public short? PitCreateUser { get; set; }

    [Column("pit_create_date")]
    public DateTime? PitCreateDate { get; set; }

    [Column("pit_lastup_user")]
    public short? PitLastupUser { get; set; }

    [Column("pit_lastup_date")]
    public DateTime? PitLastupDate { get; set; }

    [Column("pit_special1")]
    [StringLength(4)]
    public string? PitSpecial1 { get; set; }

    [Column("pit_special2")]
    [StringLength(4)]
    public string? PitSpecial2 { get; set; }

    [Column("pit_special3")]
    [StringLength(4)]
    public string? PitSpecial3 { get; set; }

    [Column("pit_perkodu")]
    [StringLength(25)]
    public string? PitPerkodu { get; set; }

    [Column("pit_sirano")]
    public int? PitSirano { get; set; }

    [Column("pit_durumu")]
    public byte? PitDurumu { get; set; }

    [Column("pit_tipi")]
    public byte? PitTipi { get; set; }

    [Column("pit_aciklama")]
    [StringLength(127)]
    public string? PitAciklama { get; set; }

    [Column("pit_tebligtarihi")]
    public DateTime? PitTebligtarihi { get; set; }

    [Column("pit_icradairesi")]
    [StringLength(25)]
    public string? PitIcradairesi { get; set; }

    [Column("pit_carikodu")]
    [StringLength(25)]
    public string? PitCarikodu { get; set; }

    [Column("pit_dosyano")]
    [StringLength(40)]
    public string? PitDosyano { get; set; }

    [Column("pit_onceliksirasi")]
    public int? PitOnceliksirasi { get; set; }

    [Column("pit_kesintisekli")]
    public byte? PitKesintisekli { get; set; }

    [Column("pit_kesintiay")]
    public short? PitKesintiay { get; set; }

    [Column("pit_kesintiyil")]
    public int? PitKesintiyil { get; set; }

    [Column("pit_toplamborctutari")]
    public double? PitToplamborctutari { get; set; }

    [Column("pit_pesinodenentutar")]
    public double? PitPesinodenentutar { get; set; }

    [Column("pit_ucrettenkesintiorani")]
    public double? PitUcrettenkesintiorani { get; set; }

    [Column("pit_izinucrettenkesintiorani")]
    public double? PitIzinucrettenkesintiorani { get; set; }

    [Column("pit_ekkazanctankesintiorani")]
    public double? PitEkkazanctankesintiorani { get; set; }

    [Column("pit_sosyalkesintiorani")]
    public double? PitSosyalkesintiorani { get; set; }

    [Column("pit_tazminatkesintiorani")]
    public double? PitTazminatkesintiorani { get; set; }

    [Column("pit_agikesintiorani")]
    public double? PitAgikesintiorani { get; set; }

    [Column("pit_aylikkesintitutari")]
    public double? PitAylikkesintitutari { get; set; }

    [Column("pit_IBAN")]
    [StringLength(40)]
    public string? PitIBAN { get; set; }

    [Column("pit_banka_tcmb_kod")]
    [StringLength(4)]
    public string? PitBankaTcmbKod { get; set; }

    [Column("pit_banka_tcmb_subekod")]
    [StringLength(8)]
    public string? PitBankaTcmbSubekod { get; set; }

    [Column("pit_banka_tcmb_ilkod")]
    [StringLength(3)]
    public string? PitBankaTcmbIlkod { get; set; }

    [Column("pit_banka_hesapno")]
    [StringLength(30)]
    public string? PitBankaHesapno { get; set; }

    [Column("pit_banka_swiftkodu")]
    [StringLength(25)]
    public string? PitBankaSwiftkodu { get; set; }

    [Column("pit_taahhutlu_fl")]
    public bool? PitTaahhutluFl { get; set; }
}
