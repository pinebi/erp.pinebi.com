using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("etiketbas")]
public class Etiketbas
{
    [Column("Etkb_Guid")]
    public Guid? EtkbGuid { get; set; }

    [Column("Etkb_DBCno")]
    public short? EtkbDBCno { get; set; }

    [Column("Etkb_SpecRECno")]
    public int? EtkbSpecRECno { get; set; }

    [Column("Etkb_iptal")]
    public bool? EtkbIptal { get; set; }

    [Column("Etkb_fileid")]
    public short? EtkbFileid { get; set; }

    [Column("Etkb_hidden")]
    public bool? EtkbHidden { get; set; }

    [Column("Etkb_kilitli")]
    public bool? EtkbKilitli { get; set; }

    [Column("Etkb_degisti")]
    public bool? EtkbDegisti { get; set; }

    [Column("Etkb_checksum")]
    public int? EtkbChecksum { get; set; }

    [Column("Etkb_create_user")]
    public short? EtkbCreateUser { get; set; }

    [Column("Etkb_create_date")]
    public DateTime? EtkbCreateDate { get; set; }

    [Column("Etkb_lastup_user")]
    public short? EtkbLastupUser { get; set; }

    [Column("Etkb_lastup_date")]
    public DateTime? EtkbLastupDate { get; set; }

    [Column("Etkb_special1")]
    [StringLength(4)]
    public string? EtkbSpecial1 { get; set; }

    [Column("Etkb_special2")]
    [StringLength(4)]
    public string? EtkbSpecial2 { get; set; }

    [Column("Etkb_special3")]
    [StringLength(4)]
    public string? EtkbSpecial3 { get; set; }

    [Column("Etkb_evrakno_seri")]
    [StringLength(50)]
    public string? EtkbEvraknoSeri { get; set; }

    [Column("Etkb_evrakno_sira")]
    public int? EtkbEvraknoSira { get; set; }

    [Column("Etkb_evrak_tarihi")]
    public DateTime? EtkbEvrakTarihi { get; set; }

    [Column("Etkb_aciklama")]
    [StringLength(40)]
    public string? EtkbAciklama { get; set; }

    [Column("Etkb_satirno")]
    public int? EtkbSatirno { get; set; }

    [Column("Etkb_belge_no")]
    [StringLength(50)]
    public string? EtkbBelgeNo { get; set; }

    [Column("Etkb_belge_tarih")]
    public DateTime? EtkbBelgeTarih { get; set; }

    [Column("Etkb_EtiketTip")]
    public byte? EtkbEtiketTip { get; set; }

    [Column("Etkb_BasimTipi")]
    public byte? EtkbBasimTipi { get; set; }

    [Column("Etkb_BasimAdet")]
    public short? EtkbBasimAdet { get; set; }

    [Column("Etkb_DepoNo")]
    public int? EtkbDepoNo { get; set; }

    [Column("Etkb_StokKodu")]
    [StringLength(25)]
    public string? EtkbStokKodu { get; set; }

    [Column("Etkb_RenkNo")]
    public int? EtkbRenkNo { get; set; }

    [Column("Etkb_BedenNo")]
    public int? EtkbBedenNo { get; set; }

    [Column("Etkb_Barkodu")]
    [StringLength(50)]
    public string? EtkbBarkodu { get; set; }

    [Column("Etkb_BasilacakMiktar")]
    public short? EtkbBasilacakMiktar { get; set; }
}
