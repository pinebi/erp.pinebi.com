using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Sistem;

[Table("pine_lisanslar")]
public class PineLisanslar : BaseEntity
{
    [Column("lis_firma_id")]
    public int LisFirmaId { get; set; }

    [Column("lis_lisans_kodu")]
    public Guid LisLisansKodu { get; set; }

    [Column("lis_plan_tipi")]
    [StringLength(50)]
    public string? LisPlanTipi { get; set; }

    [Column("lis_baslangic")]
    public DateTime? LisBaslangic { get; set; }

    [Column("lis_bitis")]
    public DateTime? LisBitis { get; set; }

    [Column("lis_max_kullanici")]
    public int LisMaxKullanici { get; set; }

    [Column("lis_max_fatura")]
    public int LisMaxFatura { get; set; }

    [Column("lis_max_stok")]
    public int LisMaxStok { get; set; }

    [Column("lis_max_cari")]
    public int LisMaxCari { get; set; }

    [Column("lis_efatura_aktif")]
    public bool LisEfaturaAktif { get; set; }

    [Column("lis_eirsaliye_aktif")]
    public bool LisEirsaliyeAktif { get; set; }

    [Column("lis_earsiv_aktif")]
    public bool LisEarsivAktif { get; set; }

    [Column("lis_tutar")]
    public decimal LisTutar { get; set; }

    [Column("lis_para_birimi")]
    [StringLength(10)]
    public string? LisParaBirimi { get; set; }

    [Column("lis_odeme_durumu")]
    [StringLength(50)]
    public string? LisOdemeDurumu { get; set; }

    [Column("lis_otomatik_yenileme")]
    public bool LisOtomatikYenileme { get; set; }

    [Column("lis_yenileme_periyodu")]
    [StringLength(20)]
    public string? LisYenilemePeriyodu { get; set; }

    [Column("lis_aktif")]
    public bool LisAktif { get; set; } = true;
}
