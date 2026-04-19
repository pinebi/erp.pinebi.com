using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("avm_sayac_hareketleri")]
public class AvmSayacHareketleri
{
    [Column("Avmsh_Guid")]
    public Guid? AvmshGuid { get; set; }

    [Column("Avmsh_DBCno")]
    public short? AvmshDBCno { get; set; }

    [Column("Avmsh_SpecRECno")]
    public int? AvmshSpecRECno { get; set; }

    [Column("Avmsh_iptal")]
    public bool? AvmshIptal { get; set; }

    [Column("Avmsh_fileid")]
    public short? AvmshFileid { get; set; }

    [Column("Avmsh_hidden")]
    public bool? AvmshHidden { get; set; }

    [Column("Avmsh_kilitli")]
    public bool? AvmshKilitli { get; set; }

    [Column("Avmsh_degisti")]
    public bool? AvmshDegisti { get; set; }

    [Column("Avmsh_checksum")]
    public int? AvmshChecksum { get; set; }

    [Column("Avmsh_create_user")]
    public short? AvmshCreateUser { get; set; }

    [Column("Avmsh_create_date")]
    public DateTime? AvmshCreateDate { get; set; }

    [Column("Avmsh_lastup_user")]
    public short? AvmshLastupUser { get; set; }

    [Column("Avmsh_lastup_date")]
    public DateTime? AvmshLastupDate { get; set; }

    [Column("Avmsh_special1")]
    [StringLength(4)]
    public string? AvmshSpecial1 { get; set; }

    [Column("Avmsh_special2")]
    [StringLength(4)]
    public string? AvmshSpecial2 { get; set; }

    [Column("Avmsh_special3")]
    [StringLength(4)]
    public string? AvmshSpecial3 { get; set; }

    [Column("Avmsh_turu")]
    public byte? AvmshTuru { get; set; }

    [Column("Avmsh_firma_no")]
    public int? AvmshFirmaNo { get; set; }

    [Column("Avmsh_sube_no")]
    public int? AvmshSubeNo { get; set; }

    [Column("Avmsh_tarihi")]
    public DateTime? AvmshTarihi { get; set; }

    [Column("Avmsh_evrakno_seri")]
    [StringLength(50)]
    public string? AvmshEvraknoSeri { get; set; }

    [Column("Avmsh_evrakno_sira")]
    public int? AvmshEvraknoSira { get; set; }

    [Column("Avmsh_satirno")]
    public int? AvmshSatirno { get; set; }

    [Column("Avmsh_belge_no")]
    [StringLength(50)]
    public string? AvmshBelgeNo { get; set; }

    [Column("Avmsh_belge_tarih")]
    public DateTime? AvmshBelgeTarih { get; set; }

    [Column("Avmsh_sayackodu")]
    [StringLength(25)]
    public string? AvmshSayackodu { get; set; }

    [Column("Avmsh_sonokuma")]
    public double? AvmshSonokuma { get; set; }

    [Column("Avmsh_fat_uid")]
    public Guid? AvmshFatUid { get; set; }

    [Column("Avmsh_aciklama")]
    [StringLength(40)]
    public string? AvmshAciklama { get; set; }

    [Column("Avmsh_kaltut_fat_uid")]
    public Guid? AvmshKaltutFatUid { get; set; }

    [Column("Avmsh_merkez_sayac_uid")]
    public Guid? AvmshMerkezSayacUid { get; set; }

    [Column("Avmsh_yansitma_dekont_uid")]
    public Guid? AvmshYansitmaDekontUid { get; set; }

    [Column("Avmsh_kayipyuzdesi")]
    public double? AvmshKayipyuzdesi { get; set; }
}
