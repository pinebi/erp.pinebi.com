using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("servis_rota_planlari")]
public class ServisRotaPlanlari
{
    [Column("srpl_Guid")]
    public Guid? SrplGuid { get; set; }

    [Column("srpl_DBCno")]
    public short? SrplDBCno { get; set; }

    [Column("srpl_SpecRECNo")]
    public int? SrplSpecRECNo { get; set; }

    [Column("srpl_iptal")]
    public bool? SrplIptal { get; set; }

    [Column("srpl_fileid")]
    public short? SrplFileid { get; set; }

    [Column("srpl_hidden")]
    public bool? SrplHidden { get; set; }

    [Column("srpl_kilitli")]
    public bool? SrplKilitli { get; set; }

    [Column("srpl_degisti")]
    public bool? SrplDegisti { get; set; }

    [Column("srpl_checksum")]
    public int? SrplChecksum { get; set; }

    [Column("srpl_create_user")]
    public short? SrplCreateUser { get; set; }

    [Column("srpl_create_date")]
    public DateTime? SrplCreateDate { get; set; }

    [Column("srpl_lastup_user")]
    public short? SrplLastupUser { get; set; }

    [Column("srpl_lastup_date")]
    public DateTime? SrplLastupDate { get; set; }

    [Column("srpl_special1")]
    [StringLength(4)]
    public string? SrplSpecial1 { get; set; }

    [Column("srpl_special2")]
    [StringLength(4)]
    public string? SrplSpecial2 { get; set; }

    [Column("srpl_special3")]
    [StringLength(4)]
    public string? SrplSpecial3 { get; set; }

    [Column("srpl_isemri_kodu")]
    [StringLength(25)]
    public string? SrplIsemriKodu { get; set; }

    [Column("srpl_satirno")]
    public int? SrplSatirno { get; set; }

    [Column("srpl_operasyon_kodu")]
    [StringLength(25)]
    public string? SrplOperasyonKodu { get; set; }

    [Column("srpl_atanan_ekip")]
    [StringLength(25)]
    public string? SrplAtananEkip { get; set; }

    [Column("srpl_planlanan_sure")]
    public int? SrplPlanlananSure { get; set; }

    [Column("srpl_tamamlanan_sure")]
    public int? SrplTamamlananSure { get; set; }

    [Column("srpl_planlanan_miktar")]
    public double? SrplPlanlananMiktar { get; set; }

    [Column("srpl_tutar")]
    public double? SrplTutar { get; set; }

    [Column("srpl_planlanan_baslama_tarihi")]
    public DateTime? SrplPlanlananBaslamaTarihi { get; set; }

    [Column("srpl_aciklama")]
    [StringLength(80)]
    public string? SrplAciklama { get; set; }

    [Column("srpl_garanti_dahili_fl")]
    public bool? SrplGarantiDahiliFl { get; set; }

    [Column("srpl_onaylandi_fl")]
    public bool? SrplOnaylandiFl { get; set; }

    [Column("srpl_kapandi_fl")]
    public bool? SrplKapandiFl { get; set; }

    [Column("srpl_iskonto")]
    public double? SrplIskonto { get; set; }
}
