using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ebelge_evrak_hareketleri")]
public class EbelgeEvrakHareketleri
{
    [Column("ebh_Guid")]
    public Guid? EbhGuid { get; set; }

    [Column("ebh_DBCno")]
    public short? EbhDBCno { get; set; }

    [Column("ebh_SpecRecNo")]
    public int? EbhSpecRecNo { get; set; }

    [Column("ebh_iptal")]
    public bool? EbhIptal { get; set; }

    [Column("ebh_fileid")]
    public short? EbhFileid { get; set; }

    [Column("ebh_hidden")]
    public bool? EbhHidden { get; set; }

    [Column("ebh_kilitli")]
    public bool? EbhKilitli { get; set; }

    [Column("ebh_degisti")]
    public bool? EbhDegisti { get; set; }

    [Column("ebh_checksum")]
    public int? EbhChecksum { get; set; }

    [Column("ebh_create_user")]
    public short? EbhCreateUser { get; set; }

    [Column("ebh_create_date")]
    public DateTime? EbhCreateDate { get; set; }

    [Column("ebh_lastup_user")]
    public short? EbhLastupUser { get; set; }

    [Column("ebh_lastup_date")]
    public DateTime? EbhLastupDate { get; set; }

    [Column("ebh_special1")]
    [StringLength(4)]
    public string? EbhSpecial1 { get; set; }

    [Column("ebh_special2")]
    [StringLength(4)]
    public string? EbhSpecial2 { get; set; }

    [Column("ebh_special3")]
    [StringLength(4)]
    public string? EbhSpecial3 { get; set; }

    [Column("ebh_hareket_tipi")]
    public byte? EbhHareketTipi { get; set; }

    [Column("ebh_related_uid")]
    public Guid? EbhRelatedUid { get; set; }

    [Column("ebh_odeme_sekli")]
    public byte? EbhOdemeSekli { get; set; }

    [Column("ebh_odeme_aciklama")]
    [StringLength(50)]
    public string? EbhOdemeAciklama { get; set; }

    [Column("ebh_odeme_aracisi")]
    [StringLength(50)]
    public string? EbhOdemeAracisi { get; set; }

    [Column("ebh_satisin_webadresi")]
    [StringLength(50)]
    public string? EbhSatisinWebadresi { get; set; }

    [Column("ebh_gonderi_tarihi")]
    public DateTime? EbhGonderiTarihi { get; set; }

    [Column("ebh_gonderi_tasiyan")]
    [StringLength(25)]
    public string? EbhGonderiTasiyan { get; set; }

    [Column("ebh_gonderi_no")]
    [StringLength(25)]
    public string? EbhGonderiNo { get; set; }

    [Column("ebh_iade_fat_no1")]
    [StringLength(25)]
    public string? EbhIadeFatNo1 { get; set; }

    [Column("ebh_iade_fat_tarihi1")]
    public DateTime? EbhIadeFatTarihi1 { get; set; }

    [Column("ebh_ekli_dosya")]
    [StringLength(120)]
    public string? EbhEkliDosya { get; set; }

    [Column("ebh_mukellefiyetdosyano")]
    [StringLength(30)]
    public string? EbhMukellefiyetdosyano { get; set; }

    [Column("ebh_mukellefiyetdonembasi")]
    public DateTime? EbhMukellefiyetdonembasi { get; set; }

    [Column("ebh_mukellefiyetdonemsonu")]
    public DateTime? EbhMukellefiyetdonemsonu { get; set; }
}
