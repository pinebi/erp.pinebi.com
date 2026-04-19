using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("promopuan_tanimlari")]
public class PromopuanTanimlari
{
    [Column("Puan_Guid")]
    public Guid? PuanGuid { get; set; }

    [Column("Puan_DBCno")]
    public short? PuanDBCno { get; set; }

    [Column("Puan_SpecRECNo")]
    public int? PuanSpecRECNo { get; set; }

    [Column("Puan_iptal")]
    public bool? PuanIptal { get; set; }

    [Column("Puan_fileid")]
    public short? PuanFileid { get; set; }

    [Column("Puan_hidden")]
    public bool? PuanHidden { get; set; }

    [Column("Puan_kilitli")]
    public bool? PuanKilitli { get; set; }

    [Column("Puan_degisti")]
    public bool? PuanDegisti { get; set; }

    [Column("Puan_CheckSum")]
    public int? PuanCheckSum { get; set; }

    [Column("Puan_create_user")]
    public short? PuanCreateUser { get; set; }

    [Column("Puan_create_date")]
    public DateTime? PuanCreateDate { get; set; }

    [Column("Puan_lastup_user")]
    public short? PuanLastupUser { get; set; }

    [Column("Puan_lastup_date")]
    public DateTime? PuanLastupDate { get; set; }

    [Column("Puan_special1")]
    [StringLength(4)]
    public string? PuanSpecial1 { get; set; }

    [Column("Puan_special2")]
    [StringLength(4)]
    public string? PuanSpecial2 { get; set; }

    [Column("Puan_special3")]
    [StringLength(4)]
    public string? PuanSpecial3 { get; set; }

    [Column("Puan_tipi")]
    public byte? PuanTipi { get; set; }

    [Column("Puan_kodu")]
    [StringLength(25)]
    public string? PuanKodu { get; set; }

    [Column("Puan_ismi")]
    [StringLength(50)]
    public string? PuanIsmi { get; set; }

    [Column("Puan_BagliPosOdemeTipi")]
    public byte? PuanBagliPosOdemeTipi { get; set; }

    [Column("Puan_bazpuan_kodu")]
    [StringLength(25)]
    public string? PuanBazpuanKodu { get; set; }

    [Column("Puan_kampanya_kodu")]
    [StringLength(25)]
    public string? PuanKampanyaKodu { get; set; }

    [Column("Puan_satis_hizmet_kodu")]
    [StringLength(25)]
    public string? PuanSatisHizmetKodu { get; set; }

    [Column("Puan_ilk_kullanim_tarihi")]
    public DateTime? PuanIlkKullanimTarihi { get; set; }

    [Column("Puan_kullanim_baslangici")]
    public int? PuanKullanimBaslangici { get; set; }

    [Column("Puan_son_kullanma_tarihi")]
    public DateTime? PuanSonKullanmaTarihi { get; set; }

    [Column("Puan_gecerlilik_suresi")]
    public int? PuanGecerlilikSuresi { get; set; }

    [Column("Puan_seri_no_yapisi")]
    [StringLength(50)]
    public string? PuanSeriNoYapisi { get; set; }

    [Column("Puan_harcama_stok_kod_yapisi")]
    [StringLength(25)]
    public string? PuanHarcamaStokKodYapisi { get; set; }

    [Column("Puan_harcama_stok_sorgu_cumlesi")]
    [StringLength(127)]
    public string? PuanHarcamaStokSorguCumlesi { get; set; }

    [Column("Puan_deger")]
    public double? PuanDeger { get; set; }

    [Column("Puan_evrakta_max_kullanim")]
    public double? PuanEvraktaMaxKullanim { get; set; }

    [Column("Puan_harcama_min_evrak_tutari")]
    public double? PuanHarcamaMinEvrakTutari { get; set; }

    [Column("Puan_Yansitma_Iskonto_index")]
    public byte? PuanYansitmaIskontoIndex { get; set; }

    [Column("Puan_YetersizIadedeYapilacak")]
    public byte? PuanYetersizIadedeYapilacak { get; set; }

    [Column("Puan_PromosyonlariDurdurur")]
    public bool? PuanPromosyonlariDurdurur { get; set; }

    [Column("Puan_GuvenlikKontrolu")]
    public byte? PuanGuvenlikKontrolu { get; set; }
}
