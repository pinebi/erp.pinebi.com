using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("bakim_sozlesme_hareketleri")]
public class BakimSozlesmeHareketleri
{
    [Column("bsoz_Guid")]
    public Guid? BsozGuid { get; set; }

    [Column("bsoz_DBCno")]
    public short? BsozDBCno { get; set; }

    [Column("bsoz_Spec_Rec_no")]
    public int? BsozSpecRecNo { get; set; }

    [Column("bsoz_iptal")]
    public bool? BsozIptal { get; set; }

    [Column("bsoz_fileid")]
    public short? BsozFileid { get; set; }

    [Column("bsoz_hidden")]
    public bool? BsozHidden { get; set; }

    [Column("bsoz_kilitli")]
    public bool? BsozKilitli { get; set; }

    [Column("bsoz_degisti")]
    public bool? BsozDegisti { get; set; }

    [Column("bsoz_checksum")]
    public int? BsozChecksum { get; set; }

    [Column("bsoz_create_user")]
    public short? BsozCreateUser { get; set; }

    [Column("bsoz_create_date")]
    public DateTime? BsozCreateDate { get; set; }

    [Column("bsoz_lastup_user")]
    public short? BsozLastupUser { get; set; }

    [Column("bsoz_lastup_date")]
    public DateTime? BsozLastupDate { get; set; }

    [Column("bsoz_special1")]
    [StringLength(4)]
    public string? BsozSpecial1 { get; set; }

    [Column("bsoz_special2")]
    [StringLength(4)]
    public string? BsozSpecial2 { get; set; }

    [Column("bsoz_special3")]
    [StringLength(4)]
    public string? BsozSpecial3 { get; set; }

    [Column("bsoz_firmano")]
    public int? BsozFirmano { get; set; }

    [Column("bsoz_subeno")]
    public int? BsozSubeno { get; set; }

    [Column("bsoz_tarihi")]
    public DateTime? BsozTarihi { get; set; }

    [Column("bsoz_evrakno_seri")]
    [StringLength(50)]
    public string? BsozEvraknoSeri { get; set; }

    [Column("bsoz_evrakno_sira")]
    public int? BsozEvraknoSira { get; set; }

    [Column("bsoz_satirno")]
    public int? BsozSatirno { get; set; }

    [Column("bsoz_belgeno")]
    [StringLength(50)]
    public string? BsozBelgeno { get; set; }

    [Column("bsoz_belge_tarihi")]
    public DateTime? BsozBelgeTarihi { get; set; }

    [Column("bsoz_cari_kodu")]
    [StringLength(25)]
    public string? BsozCariKodu { get; set; }

    [Column("bsoz_doviz_cinsi")]
    public byte? BsozDovizCinsi { get; set; }

    [Column("bsoz_baslangic_tarihi")]
    public DateTime? BsozBaslangicTarihi { get; set; }

    [Column("bsoz_bitis_tarihi")]
    public DateTime? BsozBitisTarihi { get; set; }

    [Column("bsoz_iscilik_bedeli")]
    public double? BsozIscilikBedeli { get; set; }

    [Column("bsoz_km_yol_bedeli")]
    public double? BsozKmYolBedeli { get; set; }

    [Column("bsoz_kontrol_bedeli")]
    public double? BsozKontrolBedeli { get; set; }

    [Column("bsoz_aciklama")]
    [StringLength(60)]
    public string? BsozAciklama { get; set; }

    [Column("bsoz_stok_kodu")]
    [StringLength(25)]
    public string? BsozStokKodu { get; set; }

    [Column("bsoz_seri_no")]
    [StringLength(25)]
    public string? BsozSeriNo { get; set; }

    [Column("bsoz_bakim_recete_kodu")]
    [StringLength(25)]
    public string? BsozBakimReceteKodu { get; set; }

    [Column("bsoz_bakim_bedeli")]
    public double? BsozBakimBedeli { get; set; }

    [Column("bsoz_bakim_peryodu")]
    public byte? BsozBakimPeryodu { get; set; }

    [Column("bsoz_bakim_tipi")]
    public byte? BsozBakimTipi { get; set; }
}
