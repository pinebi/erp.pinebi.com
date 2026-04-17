using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Cari;

/// <summary>
/// Cari hesaba ait ek adresler (sevk adresleri, fatura adresleri vb.)
/// </summary>
[Table("pine_cari_adresler")]
public class PineCariAdresler : BaseEntity
{
    [Column("cad_cari_kod")]
    [StringLength(25)]
    public string CadCariKod { get; set; } = string.Empty;

    /// <summary>1=Merkez, 2=Sevk, 3=Fatura, 4=Diger</summary>
    [Column("cad_adres_tipi")]
    public int CadAdresTipi { get; set; }

    [Column("cad_adres_basligi")]
    [StringLength(100)]
    public string? CadAdresBasligi { get; set; }

    [Column("cad_adres1")]
    [StringLength(500)]
    public string? CadAdres1 { get; set; }

    [Column("cad_adres2")]
    [StringLength(500)]
    public string? CadAdres2 { get; set; }

    [Column("cad_posta_kodu")]
    [StringLength(10)]
    public string? CadPostaKodu { get; set; }

    [Column("cad_ulke_kodu")]
    [StringLength(5)]
    public string? CadUlkeKodu { get; set; }

    [Column("cad_sehir_kodu")]
    public int CadSehirKodu { get; set; }

    [Column("cad_ilce_kodu")]
    public int CadIlceKodu { get; set; }

    [Column("cad_sehir_adi")]
    [StringLength(100)]
    public string? CadSehirAdi { get; set; }

    [Column("cad_ilce_adi")]
    [StringLength(100)]
    public string? CadIlceAdi { get; set; }

    [Column("cad_tel")]
    [StringLength(50)]
    public string? CadTel { get; set; }

    [Column("cad_faks")]
    [StringLength(50)]
    public string? CadFaks { get; set; }

    [Column("cad_yetkili")]
    [StringLength(100)]
    public string? CadYetkili { get; set; }

    [Column("cad_varsayilan_fl")]
    public bool CadVarsayilanFl { get; set; }

    [Column("cad_aciklama")]
    [StringLength(500)]
    public string? CadAciklama { get; set; }
}
