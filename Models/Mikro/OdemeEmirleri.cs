using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("odeme_emirleri")]
public class OdemeEmirleri
{
    [Column("sck_Guid")]
    public Guid? SckGuid { get; set; }

    [Column("sck_DBCno")]
    public short? SckDBCno { get; set; }

    [Column("sck_SpecRECno")]
    public int? SckSpecRECno { get; set; }

    [Column("sck_iptal")]
    public bool? SckIptal { get; set; }

    [Column("sck_fileid")]
    public short? SckFileid { get; set; }

    [Column("sck_hidden")]
    public bool? SckHidden { get; set; }

    [Column("sck_kilitli")]
    public bool? SckKilitli { get; set; }

    [Column("sck_degisti")]
    public bool? SckDegisti { get; set; }

    [Column("sck_checksum")]
    public int? SckChecksum { get; set; }

    [Column("sck_create_user")]
    public short? SckCreateUser { get; set; }

    [Column("sck_create_date")]
    public DateTime? SckCreateDate { get; set; }

    [Column("sck_lastup_user")]
    public short? SckLastupUser { get; set; }

    [Column("sck_lastup_date")]
    public DateTime? SckLastupDate { get; set; }

    [Column("sck_special1")]
    [StringLength(4)]
    public string? SckSpecial1 { get; set; }

    [Column("sck_special2")]
    [StringLength(4)]
    public string? SckSpecial2 { get; set; }

    [Column("sck_special3")]
    [StringLength(4)]
    public string? SckSpecial3 { get; set; }

    [Column("sck_firmano")]
    public int? SckFirmano { get; set; }

    [Column("sck_subeno")]
    public int? SckSubeno { get; set; }

    [Column("sck_tip")]
    public byte? SckTip { get; set; }

    [Column("sck_refno")]
    [StringLength(25)]
    public string? SckRefno { get; set; }

    [Column("sck_bankano")]
    [StringLength(25)]
    public string? SckBankano { get; set; }

    [Column("sck_borclu")]
    [StringLength(50)]
    public string? SckBorclu { get; set; }

    [Column("sck_vdaire_no")]
    [StringLength(40)]
    public string? SckVdaireNo { get; set; }

    [Column("sck_vade")]
    public DateTime? SckVade { get; set; }

    [Column("sck_tutar")]
    public double? SckTutar { get; set; }

    [Column("sck_doviz")]
    public byte? SckDoviz { get; set; }

    [Column("sck_odenen")]
    public double? SckOdenen { get; set; }

    [Column("sck_degerleme_islendi")]
    public byte? SckDegerlemeIslendi { get; set; }

    [Column("sck_banka_adres1")]
    [StringLength(50)]
    public string? SckBankaAdres1 { get; set; }

    [Column("sck_sube_adres2")]
    [StringLength(50)]
    public string? SckSubeAdres2 { get; set; }

    [Column("sck_borclu_tel")]
    [StringLength(15)]
    public string? SckBorcluTel { get; set; }

    [Column("sck_hesapno_sehir")]
    [StringLength(30)]
    public string? SckHesapnoSehir { get; set; }

    [Column("sck_no")]
    [StringLength(25)]
    public string? SckNo { get; set; }

    [Column("sck_duzen_tarih")]
    public DateTime? SckDuzenTarih { get; set; }

    [Column("sck_sahip_cari_cins")]
    public byte? SckSahipCariCins { get; set; }

    [Column("sck_sahip_cari_kodu")]
    [StringLength(25)]
    public string? SckSahipCariKodu { get; set; }

    [Column("sck_sahip_cari_grupno")]
    public byte? SckSahipCariGrupno { get; set; }

    [Column("sck_nerede_cari_cins")]
    public byte? SckNeredeCariCins { get; set; }

    [Column("sck_nerede_cari_kodu")]
    [StringLength(25)]
    public string? SckNeredeCariKodu { get; set; }

    [Column("sck_nerede_cari_grupno")]
    public byte? SckNeredeCariGrupno { get; set; }

    [Column("sck_ilk_hareket_tarihi")]
    public DateTime? SckIlkHareketTarihi { get; set; }

    [Column("sck_ilk_evrak_seri")]
    [StringLength(50)]
    public string? SckIlkEvrakSeri { get; set; }

    [Column("sck_ilk_evrak_sira_no")]
    public int? SckIlkEvrakSiraNo { get; set; }

    [Column("sck_ilk_evrak_satir_no")]
    public int? SckIlkEvrakSatirNo { get; set; }

    [Column("sck_son_hareket_tarihi")]
    public DateTime? SckSonHareketTarihi { get; set; }

    [Column("sck_doviz_kur")]
    public double? SckDovizKur { get; set; }

    [Column("sck_sonpoz")]
    public byte? SckSonpoz { get; set; }

    [Column("sck_imza")]
    public byte? SckImza { get; set; }

    [Column("sck_srmmrk")]
    [StringLength(25)]
    public string? SckSrmmrk { get; set; }

    [Column("sck_kesideyeri")]
    [StringLength(14)]
    public string? SckKesideyeri { get; set; }

    [Column("Sck_TCMB_Banka_kodu")]
    [StringLength(4)]
    public string? SckTCMBBankaKodu { get; set; }

    [Column("Sck_TCMB_Sube_kodu")]
    [StringLength(8)]
    public string? SckTCMBSubeKodu { get; set; }

    [Column("Sck_TCMB_İL_kodu")]
    [StringLength(3)]
    public string? SckTCMBILKodu { get; set; }

    [Column("SckTasra_fl")]
    public bool? SckTasraFl { get; set; }

    [Column("sck_projekodu")]
    [StringLength(25)]
    public string? SckProjekodu { get; set; }

    [Column("sck_masraf1")]
    public double? SckMasraf1 { get; set; }

    [Column("sck_masraf1_isleme")]
    public byte? SckMasraf1Isleme { get; set; }

    [Column("sck_masraf2")]
    public double? SckMasraf2 { get; set; }

    [Column("sck_masraf2_isleme")]
    public byte? SckMasraf2Isleme { get; set; }

    [Column("sck_odul_katkisi_tutari")]
    public double? SckOdulKatkisiTutari { get; set; }

    [Column("sck_servis_komisyon_tutari")]
    public double? SckServisKomisyonTutari { get; set; }

    [Column("sck_erken_odeme_faiz_tutari")]
    public double? SckErkenOdemeFaizTutari { get; set; }

    [Column("sck_odul_katkisi_tutari_islendi_fl")]
    public bool? SckOdulKatkisiTutariIslendiFl { get; set; }

    [Column("sck_servis_komisyon_tutari_islendi_fl")]
    public bool? SckServisKomisyonTutariIslendiFl { get; set; }

    [Column("sck_erken_odeme_faiz_tutari_islendi_fl")]
    public bool? SckErkenOdemeFaizTutariIslendiFl { get; set; }

    [Column("sck_kredi_karti_tipi")]
    public byte? SckKrediKartiTipi { get; set; }

    [Column("sck_taksit_sayisi")]
    public short? SckTaksitSayisi { get; set; }

    [Column("sck_kacinci_taksit")]
    public short? SckKacinciTaksit { get; set; }

    [Column("sck_uye_isyeri_no")]
    [StringLength(25)]
    public string? SckUyeIsyeriNo { get; set; }

    [Column("sck_kredi_karti_no")]
    [StringLength(16)]
    public string? SckKrediKartiNo { get; set; }

    [Column("sck_provizyon_kodu")]
    [StringLength(10)]
    public string? SckProvizyonKodu { get; set; }
}
