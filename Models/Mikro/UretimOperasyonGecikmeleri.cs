using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("uretim_operasyon_gecikmeleri")]
public class UretimOperasyonGecikmeleri
{
    [Column("opg_Guid")]
    public Guid? OpgGuid { get; set; }

    [Column("opg_DBCno")]
    public short? OpgDBCno { get; set; }

    [Column("opg_SpecRECNo")]
    public int? OpgSpecRECNo { get; set; }

    [Column("opg_iptal")]
    public bool? OpgIptal { get; set; }

    [Column("opg_fileid")]
    public short? OpgFileid { get; set; }

    [Column("opg_hidden")]
    public bool? OpgHidden { get; set; }

    [Column("opg_kilitli")]
    public bool? OpgKilitli { get; set; }

    [Column("opg_degisti")]
    public bool? OpgDegisti { get; set; }

    [Column("opg_checksum")]
    public int? OpgChecksum { get; set; }

    [Column("opg_create_user")]
    public short? OpgCreateUser { get; set; }

    [Column("opg_create_date")]
    public DateTime? OpgCreateDate { get; set; }

    [Column("opg_lastup_user")]
    public short? OpgLastupUser { get; set; }

    [Column("opg_lastup_date")]
    public DateTime? OpgLastupDate { get; set; }

    [Column("opg_special1")]
    [StringLength(4)]
    public string? OpgSpecial1 { get; set; }

    [Column("opg_special2")]
    [StringLength(4)]
    public string? OpgSpecial2 { get; set; }

    [Column("opg_special3")]
    [StringLength(4)]
    public string? OpgSpecial3 { get; set; }

    [Column("opg_OpTamam_uid")]
    public Guid? OpgOpTamamUid { get; set; }

    [Column("opg_GecikmeKodu")]
    [StringLength(25)]
    public string? OpgGecikmeKodu { get; set; }

    [Column("opg_GecikmeBoslukBaslangici")]
    public DateTime? OpgGecikmeBoslukBaslangici { get; set; }

    [Column("opg_GecikmeBoslukSonu")]
    public DateTime? OpgGecikmeBoslukSonu { get; set; }

    [Column("opg_GecikmeSuresi")]
    public int? OpgGecikmeSuresi { get; set; }

    [Column("opg_Aciklama")]
    [StringLength(127)]
    public string? OpgAciklama { get; set; }
}
