using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("verilen_teklifler")]
public class VerilenTeklifler
{
    [Column("tkl_Guid")]
    public Guid? TklGuid { get; set; }

    [Column("tkl_DBCno")]
    public short? TklDBCno { get; set; }

    [Column("tkl_SpecRECno")]
    public int? TklSpecRECno { get; set; }

    [Column("tkl_iptal")]
    public bool? TklIptal { get; set; }

    [Column("tkl_fileid")]
    public short? TklFileid { get; set; }

    [Column("tkl_hidden")]
    public bool? TklHidden { get; set; }

    [Column("tkl_kilitli")]
    public bool? TklKilitli { get; set; }

    [Column("tkl_degisti")]
    public bool? TklDegisti { get; set; }

    [Column("tkl_checksum")]
    public int? TklChecksum { get; set; }

    [Column("tkl_create_user")]
    public short? TklCreateUser { get; set; }

    [Column("tkl_create_date")]
    public DateTime? TklCreateDate { get; set; }

    [Column("tkl_lastup_user")]
    public short? TklLastupUser { get; set; }

    [Column("tkl_lastup_date")]
    public DateTime? TklLastupDate { get; set; }

    [Column("tkl_special1")]
    [StringLength(4)]
    public string? TklSpecial1 { get; set; }

    [Column("tkl_special2")]
    [StringLength(4)]
    public string? TklSpecial2 { get; set; }

    [Column("tkl_special3")]
    [StringLength(4)]
    public string? TklSpecial3 { get; set; }

    [Column("tkl_firmano")]
    public int? TklFirmano { get; set; }

    [Column("tkl_subeno")]
    public int? TklSubeno { get; set; }

    [Column("tkl_stok_kod")]
    [StringLength(25)]
    public string? TklStokKod { get; set; }

    [Column("tkl_cari_kod")]
    [StringLength(25)]
    public string? TklCariKod { get; set; }

    [Column("tkl_evrakno_seri")]
    [StringLength(50)]
    public string? TklEvraknoSeri { get; set; }

    [Column("tkl_evrakno_sira")]
    public int? TklEvraknoSira { get; set; }

    [Column("tkl_evrak_tarihi")]
    public DateTime? TklEvrakTarihi { get; set; }

    [Column("tkl_satirno")]
    public int? TklSatirno { get; set; }

    [Column("tkl_belge_no")]
    [StringLength(50)]
    public string? TklBelgeNo { get; set; }

    [Column("tkl_belge_tarih")]
    public DateTime? TklBelgeTarih { get; set; }

    [Column("tkl_asgari_miktar")]
    public double? TklAsgariMiktar { get; set; }

    [Column("tkl_teslimat_suresi")]
    public short? TklTeslimatSuresi { get; set; }

    [Column("tkl_baslangic_tarihi")]
    public DateTime? TklBaslangicTarihi { get; set; }

    [Column("tkl_Gecerlilik_Sures")]
    public DateTime? TklGecerlilikSures { get; set; }

    [Column("tkl_Brut_fiyat")]
    public double? TklBrutFiyat { get; set; }

    [Column("tkl_Odeme_Plani")]
    public int? TklOdemePlani { get; set; }

    [Column("tkl_Alisfiyati")]
    public double? TklAlisfiyati { get; set; }

    [Column("tkl_karorani")]
    public double? TklKarorani { get; set; }

    [Column("tkl_miktar")]
    public double? TklMiktar { get; set; }

    [Column("tkl_Aciklama")]
    [StringLength(40)]
    public string? TklAciklama { get; set; }

    [Column("tkl_doviz_cins")]
    public byte? TklDovizCins { get; set; }

    [Column("tkl_doviz_kur")]
    public double? TklDovizKur { get; set; }

    [Column("tkl_alt_doviz_kur")]
    public double? TklAltDovizKur { get; set; }

    [Column("tkl_iskonto1")]
    public double? TklIskonto1 { get; set; }

    [Column("tkl_iskonto2")]
    public double? TklIskonto2 { get; set; }

    [Column("tkl_iskonto3")]
    public double? TklIskonto3 { get; set; }

    [Column("tkl_iskonto4")]
    public double? TklIskonto4 { get; set; }

    [Column("tkl_iskonto5")]
    public double? TklIskonto5 { get; set; }

    [Column("tkl_iskonto6")]
    public double? TklIskonto6 { get; set; }

    [Column("tkl_masraf1")]
    public double? TklMasraf1 { get; set; }

    [Column("tkl_masraf2")]
    public double? TklMasraf2 { get; set; }

    [Column("tkl_masraf3")]
    public double? TklMasraf3 { get; set; }

    [Column("tkl_masraf4")]
    public double? TklMasraf4 { get; set; }

    [Column("tkl_vergi_pntr")]
    public byte? TklVergiPntr { get; set; }

    [Column("tkl_vergi")]
    public double? TklVergi { get; set; }

    [Column("tkl_masraf_vergi_pnt")]
    public byte? TklMasrafVergiPnt { get; set; }

    [Column("tkl_masraf_vergi")]
    public double? TklMasrafVergi { get; set; }

    [Column("tkl_isk_mas1")]
    public byte? TklIskMas1 { get; set; }

    [Column("TKL_ISK_MAS2")]
    public byte? TKLISKMAS2 { get; set; }

    [Column("TKL_ISK_MAS3")]
    public byte? TKLISKMAS3 { get; set; }

    [Column("TKL_ISK_MAS4")]
    public byte? TKLISKMAS4 { get; set; }

    [Column("TKL_ISK_MAS5")]
    public byte? TKLISKMAS5 { get; set; }

    [Column("TKL_ISK_MAS6")]
    public byte? TKLISKMAS6 { get; set; }

    [Column("TKL_ISK_MAS7")]
    public byte? TKLISKMAS7 { get; set; }

    [Column("TKL_ISK_MAS8")]
    public byte? TKLISKMAS8 { get; set; }

    [Column("TKL_ISK_MAS9")]
    public byte? TKLISKMAS9 { get; set; }

    [Column("TKL_ISK_MAS10")]
    public byte? TKLISKMAS10 { get; set; }

    [Column("TKL_SAT_ISKMAS1")]
    public bool? TKLSATISKMAS1 { get; set; }

    [Column("TKL_SAT_ISKMAS2")]
    public bool? TKLSATISKMAS2 { get; set; }

    [Column("TKL_SAT_ISKMAS3")]
    public bool? TKLSATISKMAS3 { get; set; }

    [Column("TKL_SAT_ISKMAS4")]
    public bool? TKLSATISKMAS4 { get; set; }

    [Column("TKL_SAT_ISKMAS5")]
    public bool? TKLSATISKMAS5 { get; set; }

    [Column("TKL_SAT_ISKMAS6")]
    public bool? TKLSATISKMAS6 { get; set; }

    [Column("TKL_SAT_ISKMAS7")]
    public bool? TKLSATISKMAS7 { get; set; }

    [Column("TKL_SAT_ISKMAS8")]
    public bool? TKLSATISKMAS8 { get; set; }

    [Column("TKL_SAT_ISKMAS9")]
    public bool? TKLSATISKMAS9 { get; set; }

    [Column("TKL_SAT_ISKMAS10")]
    public bool? TKLSATISKMAS10 { get; set; }

    [Column("TKL_VERGISIZ_FL")]
    public bool? TKLVERGISIZFL { get; set; }

    [Column("TKL_KAPAT_FL")]
    public bool? TKLKAPATFL { get; set; }

    [Column("TKL_TESLIMTURU")]
    [StringLength(4)]
    public string? TKLTESLIMTURU { get; set; }

    [Column("tkl_ProjeKodu")]
    [StringLength(25)]
    public string? TklProjeKodu { get; set; }

    [Column("tkl_Sorumlu_Kod")]
    [StringLength(25)]
    public string? TklSorumluKod { get; set; }

    [Column("tkl_adres_no")]
    public int? TklAdresNo { get; set; }

    [Column("tkl_yetkili_uid")]
    public Guid? TklYetkiliUid { get; set; }

    [Column("tkl_durumu")]
    public byte? TklDurumu { get; set; }

    [Column("tkl_TedarikEdilecekCari")]
    [StringLength(25)]
    public string? TklTedarikEdilecekCari { get; set; }

    [Column("tkl_fiyat_liste_no")]
    public int? TklFiyatListeNo { get; set; }

    [Column("tkl_Birimfiyati")]
    public double? TklBirimfiyati { get; set; }

    [Column("tkl_paket_kod")]
    [StringLength(25)]
    public string? TklPaketKod { get; set; }

    [Column("tkl_teslim_miktar")]
    public double? TklTeslimMiktar { get; set; }

    [Column("tkl_OnaylayanKulNo")]
    public short? TklOnaylayanKulNo { get; set; }

    [Column("tkl_cagrilabilir_fl")]
    public bool? TklCagrilabilirFl { get; set; }

    [Column("tkl_harekettipi")]
    public byte? TklHarekettipi { get; set; }

    [Column("tkl_cari_sormerk")]
    [StringLength(25)]
    public string? TklCariSormerk { get; set; }

    [Column("tkl_stok_sormerk")]
    [StringLength(25)]
    public string? TklStokSormerk { get; set; }

    [Column("tkl_kapatmanedenkod")]
    [StringLength(25)]
    public string? TklKapatmanedenkod { get; set; }

    [Column("tkl_servisisemrikodu")]
    [StringLength(25)]
    public string? TklServisisemrikodu { get; set; }

    [Column("tkl_birim_pntr")]
    public byte? TklBirimPntr { get; set; }

    [Column("tkl_cari_tipi")]
    public byte? TklCariTipi { get; set; }
}
