using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kira_tanimlari")]
public class KiraTanimlari
{
    [Column("kr_Guid")]
    public Guid? KrGuid { get; set; }

    [Column("kr_DBCno")]
    public short? KrDBCno { get; set; }

    [Column("kr_SpecRECno")]
    public int? KrSpecRECno { get; set; }

    [Column("kr_iptal")]
    public bool? KrIptal { get; set; }

    [Column("kr_fileid")]
    public short? KrFileid { get; set; }

    [Column("kr_hidden")]
    public bool? KrHidden { get; set; }

    [Column("kr_kilitli")]
    public bool? KrKilitli { get; set; }

    [Column("kr_degisti")]
    public bool? KrDegisti { get; set; }

    [Column("kr_checksum")]
    public int? KrChecksum { get; set; }

    [Column("kr_create_user")]
    public short? KrCreateUser { get; set; }

    [Column("kr_create_date")]
    public DateTime? KrCreateDate { get; set; }

    [Column("kr_lastup_user")]
    public short? KrLastupUser { get; set; }

    [Column("kr_lastup_date")]
    public DateTime? KrLastupDate { get; set; }

    [Column("kr_special1")]
    [StringLength(4)]
    public string? KrSpecial1 { get; set; }

    [Column("kr_special2")]
    [StringLength(4)]
    public string? KrSpecial2 { get; set; }

    [Column("kr_special3")]
    [StringLength(4)]
    public string? KrSpecial3 { get; set; }

    [Column("kr_firma_no")]
    public int? KrFirmaNo { get; set; }

    [Column("kr_sube_no")]
    public int? KrSubeNo { get; set; }

    [Column("kr_kira_no")]
    public int? KrKiraNo { get; set; }

    [Column("kr_muhtasar_grup_kodu")]
    [StringLength(25)]
    public string? KrMuhtasarGrupKodu { get; set; }

    [Column("kr_unvan")]
    [StringLength(50)]
    public string? KrUnvan { get; set; }

    [Column("kr_hesap_kodu")]
    [StringLength(25)]
    public string? KrHesapKodu { get; set; }

    [Column("kr_tutar")]
    public double? KrTutar { get; set; }

    [Column("kr_isltip")]
    public byte? KrIsltip { get; set; }

    [Column("kr_ozel_mah_kodu")]
    [StringLength(25)]
    public string? KrOzelMahKodu { get; set; }

    [Column("kr_vergi_kimlik_no")]
    [StringLength(25)]
    public string? KrVergiKimlikNo { get; set; }

    [Column("kr_cadde")]
    [StringLength(50)]
    public string? KrCadde { get; set; }

    [Column("kr_mahalle")]
    [StringLength(50)]
    public string? KrMahalle { get; set; }

    [Column("kr_sokak")]
    [StringLength(50)]
    public string? KrSokak { get; set; }

    [Column("kr_Semt")]
    [StringLength(25)]
    public string? KrSemt { get; set; }

    [Column("kr_Apt_No")]
    [StringLength(10)]
    public string? KrAptNo { get; set; }

    [Column("kr_Daire_No")]
    [StringLength(10)]
    public string? KrDaireNo { get; set; }

    [Column("kr_posta_kodu")]
    [StringLength(8)]
    public string? KrPostaKodu { get; set; }

    [Column("kr_ilce")]
    [StringLength(50)]
    public string? KrIlce { get; set; }

    [Column("kr_il")]
    [StringLength(50)]
    public string? KrIl { get; set; }

    [Column("kr_ulke")]
    [StringLength(50)]
    public string? KrUlke { get; set; }

    [Column("kr_adres_no")]
    [StringLength(10)]
    public string? KrAdresNo { get; set; }

    [Column("kr_vergi_dairesi_kodu")]
    [StringLength(10)]
    public string? KrVergiDairesiKodu { get; set; }

    [Column("kr_vergi_orani")]
    public double? KrVergiOrani { get; set; }

    [Column("kr_tckimlik_no")]
    [StringLength(11)]
    public string? KrTckimlikNo { get; set; }

    [Column("kr_baslangictarihi")]
    public DateTime? KrBaslangictarihi { get; set; }

    [Column("kr_bitistarihi")]
    public DateTime? KrBitistarihi { get; set; }
}
