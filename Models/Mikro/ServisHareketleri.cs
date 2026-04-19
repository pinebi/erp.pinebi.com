using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("servis_hareketleri")]
public class ServisHareketleri
{
    [Column("srvh_Guid")]
    public Guid? SrvhGuid { get; set; }

    [Column("srvh_DBCno")]
    public short? SrvhDBCno { get; set; }

    [Column("srvh_SpecRECNo")]
    public int? SrvhSpecRECNo { get; set; }

    [Column("srvh_iptal")]
    public bool? SrvhIptal { get; set; }

    [Column("srvh_fileid")]
    public short? SrvhFileid { get; set; }

    [Column("srvh_hidden")]
    public bool? SrvhHidden { get; set; }

    [Column("srvh_kilitli")]
    public bool? SrvhKilitli { get; set; }

    [Column("srvh_degisti")]
    public bool? SrvhDegisti { get; set; }

    [Column("srvh_checksum")]
    public int? SrvhChecksum { get; set; }

    [Column("srvh_create_user")]
    public short? SrvhCreateUser { get; set; }

    [Column("srvh_create_date")]
    public DateTime? SrvhCreateDate { get; set; }

    [Column("srvh_lastup_user")]
    public short? SrvhLastupUser { get; set; }

    [Column("srvh_lastup_date")]
    public DateTime? SrvhLastupDate { get; set; }

    [Column("srvh_special1")]
    [StringLength(4)]
    public string? SrvhSpecial1 { get; set; }

    [Column("srvh_special2")]
    [StringLength(4)]
    public string? SrvhSpecial2 { get; set; }

    [Column("srvh_special3")]
    [StringLength(4)]
    public string? SrvhSpecial3 { get; set; }

    [Column("srvh_firmano")]
    public int? SrvhFirmano { get; set; }

    [Column("srvh_subeno")]
    public int? SrvhSubeno { get; set; }

    [Column("srvh_evrakno_seri")]
    [StringLength(50)]
    public string? SrvhEvraknoSeri { get; set; }

    [Column("srvh_evrakno_sira")]
    public int? SrvhEvraknoSira { get; set; }

    [Column("srvh_belgeno")]
    [StringLength(50)]
    public string? SrvhBelgeno { get; set; }

    [Column("srvh_belge_tarih")]
    public DateTime? SrvhBelgeTarih { get; set; }

    [Column("srvh_isemri_uid")]
    public Guid? SrvhIsemriUid { get; set; }

    [Column("srvh_referans_no")]
    [StringLength(25)]
    public string? SrvhReferansNo { get; set; }

    [Column("srvh_tarih")]
    public DateTime? SrvhTarih { get; set; }

    [Column("srvh_yetkili_uid")]
    public Guid? SrvhYetkiliUid { get; set; }

    [Column("srvh_calisma_saati")]
    public int? SrvhCalismaSaati { get; set; }

    [Column("srvh_yapilan_islemler1")]
    [StringLength(120)]
    public string? SrvhYapilanIslemler1 { get; set; }

    [Column("srvh_yapilan_islemler2")]
    [StringLength(120)]
    public string? SrvhYapilanIslemler2 { get; set; }

    [Column("srvh_yapilan_islemler3")]
    [StringLength(120)]
    public string? SrvhYapilanIslemler3 { get; set; }

    [Column("srvh_baslama_saati")]
    public DateTime? SrvhBaslamaSaati { get; set; }

    [Column("srvh_bitis_saati")]
    public DateTime? SrvhBitisSaati { get; set; }

    [Column("srvh_arac_plaka")]
    [StringLength(25)]
    public string? SrvhAracPlaka { get; set; }

    [Column("srvh_toplam_yol")]
    public double? SrvhToplamYol { get; set; }

    [Column("srvh_satirno")]
    public int? SrvhSatirno { get; set; }

    [Column("srvh_hareket_tipi")]
    public byte? SrvhHareketTipi { get; set; }

    [Column("srvh_stok_hizmet_kodu")]
    [StringLength(25)]
    public string? SrvhStokHizmetKodu { get; set; }

    [Column("srvh_aciklama")]
    [StringLength(40)]
    public string? SrvhAciklama { get; set; }

    [Column("srvh_miktari")]
    public double? SrvhMiktari { get; set; }

    [Column("srvh_fatura_garanti_tipi")]
    public byte? SrvhFaturaGarantiTipi { get; set; }

    [Column("srvh_durumu")]
    public byte? SrvhDurumu { get; set; }

    [Column("srvh_depo_no")]
    public int? SrvhDepoNo { get; set; }

    [Column("srvh_sormerk")]
    [StringLength(25)]
    public string? SrvhSormerk { get; set; }

    [Column("srvh_projekodu")]
    [StringLength(25)]
    public string? SrvhProjekodu { get; set; }

    [Column("srvh_doviz_cinsi")]
    public byte? SrvhDovizCinsi { get; set; }

    [Column("srvh_sip_tip")]
    public byte? SrvhSipTip { get; set; }

    [Column("srvh_sip_uid")]
    public Guid? SrvhSipUid { get; set; }

    [Column("srvh_chz_mak_tipi")]
    public byte? SrvhChzMakTipi { get; set; }

    [Column("srvh_ariza_tespiti_yapan_tipi")]
    public byte? SrvhArizaTespitiYapanTipi { get; set; }

    [Column("srvh_ariza_tespiti_yapan_ekip")]
    [StringLength(25)]
    public string? SrvhArizaTespitiYapanEkip { get; set; }

    [Column("srvh_ise_atanan_tipi")]
    public byte? SrvhIseAtananTipi { get; set; }

    [Column("srvh_ise_atanan_ekip")]
    [StringLength(25)]
    public string? SrvhIseAtananEkip { get; set; }

    [Column("srvh_isi_yapan_tipi")]
    public byte? SrvhIsiYapanTipi { get; set; }

    [Column("srvh_isi_yapan_ekip")]
    [StringLength(25)]
    public string? SrvhIsiYapanEkip { get; set; }
}
