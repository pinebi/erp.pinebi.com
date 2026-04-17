using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Sistem;

[Table("pine_kullanicilar")]
public class PineKullanicilar : BaseEntity
{
    [Column("kul_firma_id")]
    public int KulFirmaId { get; set; }

    [Column("kul_kullanici_adi")]
    [StringLength(100)]
    public string? KulKullaniciAdi { get; set; }

    [Column("kul_email")]
    [StringLength(200)]
    public string? KulEmail { get; set; }

    [Column("kul_sifre_hash")]
    [StringLength(500)]
    public string? KulSifreHash { get; set; }

    [Column("kul_adsoyad")]
    [StringLength(200)]
    public string? KulAdsoyad { get; set; }

    [Column("kul_tel")]
    [StringLength(50)]
    public string? KulTel { get; set; }

    [Column("kul_rol")]
    [StringLength(50)]
    public string? KulRol { get; set; }

    [Column("kul_profil_resim_url")]
    [StringLength(500)]
    public string? KulProfilResimUrl { get; set; }

    [Column("kul_aktif")]
    public bool KulAktif { get; set; } = true;

    [Column("kul_son_giris_tarihi")]
    public DateTime? KulSonGirisTarihi { get; set; }

    [Column("kul_son_giris_ip")]
    [StringLength(50)]
    public string? KulSonGirisIp { get; set; }

    [Column("kul_giris_deneme")]
    public int KulGirisDeneme { get; set; } = 0;

    [Column("kul_hesap_kilitli")]
    public bool KulHesapKilitli { get; set; } = false;

    [Column("kul_sifre_degisim_tarihi")]
    public DateTime? KulSifreDegisimTarihi { get; set; }

    [Column("kul_iki_asamali")]
    public bool KulIkiAsamali { get; set; } = false;
}
