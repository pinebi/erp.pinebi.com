using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("muhtasar_gruplari")]
public class MuhtasarGruplari
{
    [Column("mg_Guid")]
    public Guid? MgGuid { get; set; }

    [Column("mg_DBCno")]
    public short? MgDBCno { get; set; }

    [Column("mg_SpecRECno")]
    public int? MgSpecRECno { get; set; }

    [Column("mg_iptal")]
    public bool? MgIptal { get; set; }

    [Column("mg_fileid")]
    public short? MgFileid { get; set; }

    [Column("mg_hidden")]
    public bool? MgHidden { get; set; }

    [Column("mg_kilitli")]
    public bool? MgKilitli { get; set; }

    [Column("mg_degisti")]
    public bool? MgDegisti { get; set; }

    [Column("mg_checksum")]
    public int? MgChecksum { get; set; }

    [Column("mg_create_user")]
    public short? MgCreateUser { get; set; }

    [Column("mg_create_date")]
    public DateTime? MgCreateDate { get; set; }

    [Column("mg_lastup_user")]
    public short? MgLastupUser { get; set; }

    [Column("mg_lastup_date")]
    public DateTime? MgLastupDate { get; set; }

    [Column("mg_special1")]
    [StringLength(4)]
    public string? MgSpecial1 { get; set; }

    [Column("mg_special2")]
    [StringLength(4)]
    public string? MgSpecial2 { get; set; }

    [Column("mg_special3")]
    [StringLength(4)]
    public string? MgSpecial3 { get; set; }

    [Column("mg_kodu")]
    [StringLength(25)]
    public string? MgKodu { get; set; }

    [Column("mg_aciklama")]
    [StringLength(50)]
    public string? MgAciklama { get; set; }

    [Column("mg_isletme_fl")]
    public bool? MgIsletmeFl { get; set; }

    [Column("mg_uygulamasekli")]
    public byte? MgUygulamasekli { get; set; }

    [Column("mg_vergidairesi")]
    [StringLength(10)]
    public string? MgVergidairesi { get; set; }

    [Column("mg_Muh_gv_tesvik")]
    public byte? MgMuhGvTesvik { get; set; }

    [Column("mg_MuhTurKodu1")]
    public int? MgMuhTurKodu1 { get; set; }

    [Column("mg_MuhTurKodu2")]
    public int? MgMuhTurKodu2 { get; set; }

    [Column("mg_MuhTurKodu3")]
    public int? MgMuhTurKodu3 { get; set; }

    [Column("mg_MuhTurKodu4")]
    public int? MgMuhTurKodu4 { get; set; }

    [Column("mg_MuhTurKodu5")]
    public int? MgMuhTurKodu5 { get; set; }

    [Column("mg_MuhTurKodu6")]
    public int? MgMuhTurKodu6 { get; set; }

    [Column("mg_MuhTurKodu7")]
    public int? MgMuhTurKodu7 { get; set; }

    [Column("mg_MuhTurKodu8")]
    public int? MgMuhTurKodu8 { get; set; }

    [Column("mg_MuhTurKodu9")]
    public int? MgMuhTurKodu9 { get; set; }

    [Column("mg_MuhTurKodu10")]
    public int? MgMuhTurKodu10 { get; set; }

    [Column("mg_MuhTurKodu11")]
    public int? MgMuhTurKodu11 { get; set; }

    [Column("mg_MuhTurKodu12")]
    public int? MgMuhTurKodu12 { get; set; }

    [Column("mg_MuhTurKodu13")]
    public int? MgMuhTurKodu13 { get; set; }

    [Column("mg_MuhTurKodu14")]
    public int? MgMuhTurKodu14 { get; set; }

    [Column("mg_MuhTurKodu15")]
    public int? MgMuhTurKodu15 { get; set; }

    [Column("mg_MuhTurKodu16")]
    public int? MgMuhTurKodu16 { get; set; }

    [Column("mg_MuhTurKodu17")]
    public int? MgMuhTurKodu17 { get; set; }

    [Column("mg_MuhTurKodu18")]
    public int? MgMuhTurKodu18 { get; set; }

    [Column("mg_MuhTurKodu19")]
    public int? MgMuhTurKodu19 { get; set; }

    [Column("mg_MuhTurKodu20")]
    public int? MgMuhTurKodu20 { get; set; }

    [Column("mg_MuhTurKodu21")]
    public int? MgMuhTurKodu21 { get; set; }

    [Column("mg_MuhTurKodu22")]
    public int? MgMuhTurKodu22 { get; set; }

    [Column("mg_MuhTurKodu23")]
    public int? MgMuhTurKodu23 { get; set; }

    [Column("mg_MuhTurKodu24")]
    public int? MgMuhTurKodu24 { get; set; }

    [Column("mg_MuhTurKodu25")]
    public int? MgMuhTurKodu25 { get; set; }

    [Column("mg_MuhTurKodu26")]
    public int? MgMuhTurKodu26 { get; set; }

    [Column("mg_MuhTurKodu27")]
    public int? MgMuhTurKodu27 { get; set; }

    [Column("mg_MuhTurKodu28")]
    public int? MgMuhTurKodu28 { get; set; }

    [Column("mg_MuhTurKodu29")]
    public int? MgMuhTurKodu29 { get; set; }

    [Column("mg_MuhTurKodu30")]
    public int? MgMuhTurKodu30 { get; set; }

    [Column("mg_MuhTurKodu31")]
    public int? MgMuhTurKodu31 { get; set; }

    [Column("mg_MuhTurKodu32")]
    public int? MgMuhTurKodu32 { get; set; }

    [Column("mg_MuhTurKodu33")]
    public int? MgMuhTurKodu33 { get; set; }

    [Column("mg_MuhTurKodu34")]
    public int? MgMuhTurKodu34 { get; set; }

    [Column("mg_MuhTurKodu35")]
    public int? MgMuhTurKodu35 { get; set; }

    [Column("mg_MuhTurKodu36")]
    public int? MgMuhTurKodu36 { get; set; }

    [Column("mg_MuhTurKodu37")]
    public int? MgMuhTurKodu37 { get; set; }

    [Column("mg_MuhTurKodu38")]
    public int? MgMuhTurKodu38 { get; set; }

    [Column("mg_MuhTurKodu39")]
    public int? MgMuhTurKodu39 { get; set; }

    [Column("mg_MuhTurKodu40")]
    public int? MgMuhTurKodu40 { get; set; }

    [Column("mg_MuhKodlari1")]
    [StringLength(25)]
    public string? MgMuhKodlari1 { get; set; }

    [Column("mg_MuhKodlari2")]
    [StringLength(25)]
    public string? MgMuhKodlari2 { get; set; }

    [Column("mg_MuhKodlari3")]
    [StringLength(25)]
    public string? MgMuhKodlari3 { get; set; }

    [Column("mg_MuhKodlari4")]
    [StringLength(25)]
    public string? MgMuhKodlari4 { get; set; }

    [Column("mg_MuhKodlari5")]
    [StringLength(25)]
    public string? MgMuhKodlari5 { get; set; }

    [Column("mg_MuhKodlari6")]
    [StringLength(25)]
    public string? MgMuhKodlari6 { get; set; }

    [Column("mg_MuhKodlari7")]
    [StringLength(25)]
    public string? MgMuhKodlari7 { get; set; }

    [Column("mg_MuhKodlari8")]
    [StringLength(25)]
    public string? MgMuhKodlari8 { get; set; }

    [Column("mg_MuhKodlari9")]
    [StringLength(25)]
    public string? MgMuhKodlari9 { get; set; }

    [Column("mg_MuhKodlari10")]
    [StringLength(25)]
    public string? MgMuhKodlari10 { get; set; }

    [Column("mg_MuhKodlari11")]
    [StringLength(25)]
    public string? MgMuhKodlari11 { get; set; }

    [Column("mg_MuhKodlari12")]
    [StringLength(25)]
    public string? MgMuhKodlari12 { get; set; }

    [Column("mg_MuhKodlari13")]
    [StringLength(25)]
    public string? MgMuhKodlari13 { get; set; }

    [Column("mg_MuhKodlari14")]
    [StringLength(25)]
    public string? MgMuhKodlari14 { get; set; }

    [Column("mg_MuhKodlari15")]
    [StringLength(25)]
    public string? MgMuhKodlari15 { get; set; }

    [Column("mg_MuhKodlari16")]
    [StringLength(25)]
    public string? MgMuhKodlari16 { get; set; }

    [Column("mg_MuhKodlari17")]
    [StringLength(25)]
    public string? MgMuhKodlari17 { get; set; }

    [Column("mg_MuhKodlari18")]
    [StringLength(25)]
    public string? MgMuhKodlari18 { get; set; }

    [Column("mg_MuhKodlari19")]
    [StringLength(25)]
    public string? MgMuhKodlari19 { get; set; }

    [Column("mg_MuhKodlari20")]
    [StringLength(25)]
    public string? MgMuhKodlari20 { get; set; }

    [Column("mg_MuhKodlari21")]
    [StringLength(25)]
    public string? MgMuhKodlari21 { get; set; }

    [Column("mg_MuhKodlari22")]
    [StringLength(25)]
    public string? MgMuhKodlari22 { get; set; }

    [Column("mg_MuhKodlari23")]
    [StringLength(25)]
    public string? MgMuhKodlari23 { get; set; }

    [Column("mg_MuhKodlari24")]
    [StringLength(25)]
    public string? MgMuhKodlari24 { get; set; }

    [Column("mg_MuhKodlari25")]
    [StringLength(25)]
    public string? MgMuhKodlari25 { get; set; }

    [Column("mg_MuhKodlari26")]
    [StringLength(25)]
    public string? MgMuhKodlari26 { get; set; }

    [Column("mg_MuhKodlari27")]
    [StringLength(25)]
    public string? MgMuhKodlari27 { get; set; }

    [Column("mg_MuhKodlari28")]
    [StringLength(25)]
    public string? MgMuhKodlari28 { get; set; }

    [Column("mg_MuhKodlari29")]
    [StringLength(25)]
    public string? MgMuhKodlari29 { get; set; }

    [Column("mg_MuhKodlari30")]
    [StringLength(25)]
    public string? MgMuhKodlari30 { get; set; }

    [Column("mg_MuhKodlari31")]
    [StringLength(25)]
    public string? MgMuhKodlari31 { get; set; }

    [Column("mg_MuhKodlari32")]
    [StringLength(25)]
    public string? MgMuhKodlari32 { get; set; }

    [Column("mg_MuhKodlari33")]
    [StringLength(25)]
    public string? MgMuhKodlari33 { get; set; }

    [Column("mg_MuhKodlari34")]
    [StringLength(25)]
    public string? MgMuhKodlari34 { get; set; }

    [Column("mg_MuhKodlari35")]
    [StringLength(25)]
    public string? MgMuhKodlari35 { get; set; }

    [Column("mg_MuhKodlari36")]
    [StringLength(25)]
    public string? MgMuhKodlari36 { get; set; }

    [Column("mg_MuhKodlari37")]
    [StringLength(25)]
    public string? MgMuhKodlari37 { get; set; }

    [Column("mg_MuhKodlari38")]
    [StringLength(25)]
    public string? MgMuhKodlari38 { get; set; }

    [Column("mg_MuhKodlari39")]
    [StringLength(25)]
    public string? MgMuhKodlari39 { get; set; }

    [Column("mg_MuhKodlari40")]
    [StringLength(25)]
    public string? MgMuhKodlari40 { get; set; }

    [Column("mg_MuhOranlari1")]
    public double? MgMuhOranlari1 { get; set; }

    [Column("mg_MuhOranlari2")]
    public double? MgMuhOranlari2 { get; set; }

    [Column("mg_MuhOranlari3")]
    public double? MgMuhOranlari3 { get; set; }

    [Column("mg_MuhOranlari4")]
    public double? MgMuhOranlari4 { get; set; }

    [Column("mg_MuhOranlari5")]
    public double? MgMuhOranlari5 { get; set; }

    [Column("mg_MuhOranlari6")]
    public double? MgMuhOranlari6 { get; set; }

    [Column("mg_MuhOranlari7")]
    public double? MgMuhOranlari7 { get; set; }

    [Column("mg_MuhOranlari8")]
    public double? MgMuhOranlari8 { get; set; }

    [Column("mg_MuhOranlari9")]
    public double? MgMuhOranlari9 { get; set; }

    [Column("mg_MuhOranlari10")]
    public double? MgMuhOranlari10 { get; set; }

    [Column("mg_MuhOranlari11")]
    public double? MgMuhOranlari11 { get; set; }

    [Column("mg_MuhOranlari12")]
    public double? MgMuhOranlari12 { get; set; }

    [Column("mg_MuhOranlari13")]
    public double? MgMuhOranlari13 { get; set; }

    [Column("mg_MuhOranlari14")]
    public double? MgMuhOranlari14 { get; set; }

    [Column("mg_MuhOranlari15")]
    public double? MgMuhOranlari15 { get; set; }

    [Column("mg_MuhOranlari16")]
    public double? MgMuhOranlari16 { get; set; }

    [Column("mg_MuhOranlari17")]
    public double? MgMuhOranlari17 { get; set; }

    [Column("mg_MuhOranlari18")]
    public double? MgMuhOranlari18 { get; set; }

    [Column("mg_MuhOranlari19")]
    public double? MgMuhOranlari19 { get; set; }

    [Column("mg_MuhOranlari20")]
    public double? MgMuhOranlari20 { get; set; }

    [Column("mg_MuhOranlari21")]
    public double? MgMuhOranlari21 { get; set; }

    [Column("mg_MuhOranlari22")]
    public double? MgMuhOranlari22 { get; set; }

    [Column("mg_MuhOranlari23")]
    public double? MgMuhOranlari23 { get; set; }

    [Column("mg_MuhOranlari24")]
    public double? MgMuhOranlari24 { get; set; }

    [Column("mg_MuhOranlari25")]
    public double? MgMuhOranlari25 { get; set; }

    [Column("mg_MuhOranlari26")]
    public double? MgMuhOranlari26 { get; set; }

    [Column("mg_MuhOranlari27")]
    public double? MgMuhOranlari27 { get; set; }

    [Column("mg_MuhOranlari28")]
    public double? MgMuhOranlari28 { get; set; }

    [Column("mg_MuhOranlari29")]
    public double? MgMuhOranlari29 { get; set; }

    [Column("mg_MuhOranlari30")]
    public double? MgMuhOranlari30 { get; set; }

    [Column("mg_MuhOranlari31")]
    public double? MgMuhOranlari31 { get; set; }

    [Column("mg_MuhOranlari32")]
    public double? MgMuhOranlari32 { get; set; }

    [Column("mg_MuhOranlari33")]
    public double? MgMuhOranlari33 { get; set; }

    [Column("mg_MuhOranlari34")]
    public double? MgMuhOranlari34 { get; set; }

    [Column("mg_MuhOranlari35")]
    public double? MgMuhOranlari35 { get; set; }

    [Column("mg_MuhOranlari36")]
    public double? MgMuhOranlari36 { get; set; }

    [Column("mg_MuhOranlari37")]
    public double? MgMuhOranlari37 { get; set; }

    [Column("mg_MuhOranlari38")]
    public double? MgMuhOranlari38 { get; set; }

    [Column("mg_MuhOranlari39")]
    public double? MgMuhOranlari39 { get; set; }

    [Column("mg_MuhOranlari40")]
    public double? MgMuhOranlari40 { get; set; }

    [Column("mg_EvrakOku")]
    public bool? MgEvrakOku { get; set; }

    [Column("mg_TahsilatMuhKodlari1")]
    [StringLength(25)]
    public string? MgTahsilatMuhKodlari1 { get; set; }

    [Column("mg_TahsilatMuhKodlari2")]
    [StringLength(25)]
    public string? MgTahsilatMuhKodlari2 { get; set; }

    [Column("mg_TahsilatMuhKodlari3")]
    [StringLength(25)]
    public string? MgTahsilatMuhKodlari3 { get; set; }

    [Column("mg_TahsilatMuhKodlari4")]
    [StringLength(25)]
    public string? MgTahsilatMuhKodlari4 { get; set; }

    [Column("mg_TahsilatMuhKodlari5")]
    [StringLength(25)]
    public string? MgTahsilatMuhKodlari5 { get; set; }

    [Column("mg_5225belgetarihi")]
    public DateTime? Mg5225belgetarihi { get; set; }

    [Column("mg_5225sayisi")]
    [StringLength(25)]
    public string? Mg5225sayisi { get; set; }

    [Column("mg_Muh_Tesvik_Tarihi")]
    public byte? MgMuhTesvikTarihi { get; set; }

    [Column("mg_yurtdisihizuygtabii_fl")]
    public bool? MgYurtdisihizuygtabiiFl { get; set; }

    [Column("mg_faaliyettipi")]
    public byte? MgFaaliyettipi { get; set; }

    [Column("mg_yurticihasilat")]
    public double? MgYurticihasilat { get; set; }

    [Column("mg_yurtdisihasilat")]
    public double? MgYurtdisihasilat { get; set; }

    [Column("mg_yurtdisihizcalismakodu")]
    [StringLength(25)]
    public string? MgYurtdisihizcalismakodu { get; set; }
}
