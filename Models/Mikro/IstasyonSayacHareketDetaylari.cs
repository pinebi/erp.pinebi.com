using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("istasyon_sayac_hareket_detaylari")]
public class IstasyonSayacHareketDetaylari
{
    [Column("shdt_Guid")]
    public Guid? ShdtGuid { get; set; }

    [Column("shdt_DBCno")]
    public short? ShdtDBCno { get; set; }

    [Column("shdt_SpecRECno")]
    public int? ShdtSpecRECno { get; set; }

    [Column("shdt_iptal")]
    public bool? ShdtIptal { get; set; }

    [Column("shdt_fileid")]
    public short? ShdtFileid { get; set; }

    [Column("shdt_hidden")]
    public bool? ShdtHidden { get; set; }

    [Column("shdt_kilitli")]
    public bool? ShdtKilitli { get; set; }

    [Column("shdt_degisti")]
    public bool? ShdtDegisti { get; set; }

    [Column("shdt_checksum")]
    public int? ShdtChecksum { get; set; }

    [Column("shdt_create_user")]
    public short? ShdtCreateUser { get; set; }

    [Column("shdt_create_date")]
    public DateTime? ShdtCreateDate { get; set; }

    [Column("shdt_lastup_user")]
    public short? ShdtLastupUser { get; set; }

    [Column("shdt_lastup_date")]
    public DateTime? ShdtLastupDate { get; set; }

    [Column("shdt_special1")]
    [StringLength(4)]
    public string? ShdtSpecial1 { get; set; }

    [Column("shdt_special2")]
    [StringLength(4)]
    public string? ShdtSpecial2 { get; set; }

    [Column("shdt_special3")]
    [StringLength(4)]
    public string? ShdtSpecial3 { get; set; }

    [Column("shdt_firma_no")]
    public int? ShdtFirmaNo { get; set; }

    [Column("shdt_sube_no")]
    public int? ShdtSubeNo { get; set; }

    [Column("shdt_sayackodu")]
    [StringLength(25)]
    public string? ShdtSayackodu { get; set; }

    [Column("shdt_depo_no")]
    public int? ShdtDepoNo { get; set; }

    [Column("shdt_stokkodu")]
    [StringLength(25)]
    public string? ShdtStokkodu { get; set; }

    [Column("shdt_vardiyatarihi")]
    public DateTime? ShdtVardiyatarihi { get; set; }

    [Column("shdt_vardiyano")]
    public byte? ShdtVardiyano { get; set; }

    [Column("shdt_filokodu")]
    [StringLength(25)]
    public string? ShdtFilokodu { get; set; }

    [Column("shdt_carikodu")]
    [StringLength(25)]
    public string? ShdtCarikodu { get; set; }

    [Column("shdt_tagnumarasi")]
    [StringLength(25)]
    public string? ShdtTagnumarasi { get; set; }

    [Column("shdt_plaka_veya_personel")]
    [StringLength(25)]
    public string? ShdtPlakaVeyaPersonel { get; set; }

    [Column("shdt_motorsaati")]
    public double? ShdtMotorsaati { get; set; }

    [Column("shdt_kilometre")]
    public double? ShdtKilometre { get; set; }

    [Column("shdt_satistipi")]
    public byte? ShdtSatistipi { get; set; }

    [Column("shdt_satistarihi")]
    public DateTime? ShdtSatistarihi { get; set; }

    [Column("shdt_satissirano")]
    public int? ShdtSatissirano { get; set; }

    [Column("shdt_yakittipi")]
    public byte? ShdtYakittipi { get; set; }

    [Column("shdt_birimfiyat")]
    public double? ShdtBirimfiyat { get; set; }

    [Column("shdt_miktar")]
    public double? ShdtMiktar { get; set; }

    [Column("shdt_tutar")]
    public double? ShdtTutar { get; set; }

    [Column("shdt_pompano")]
    public byte? ShdtPompano { get; set; }

    [Column("shdt_tabancano")]
    public byte? ShdtTabancano { get; set; }

    [Column("shdt_odemeturu")]
    public byte? ShdtOdemeturu { get; set; }

    [Column("shdt_aracplaka")]
    [StringLength(25)]
    public string? ShdtAracplaka { get; set; }

    [Column("shdt_fisno")]
    public int? ShdtFisno { get; set; }

    [Column("shdt_odeme")]
    public double? ShdtOdeme { get; set; }

    [Column("shdt_indirim")]
    public double? ShdtIndirim { get; set; }

    [Column("shdt_hediyepuan")]
    public double? ShdtHediyepuan { get; set; }

    [Column("shdt_hediyetutar")]
    public double? ShdtHediyetutar { get; set; }

    [Column("shdt_hediyekartno")]
    [StringLength(25)]
    public string? ShdtHediyekartno { get; set; }

    [Column("shdt_hediyekartturu")]
    public byte? ShdtHediyekartturu { get; set; }

    [Column("shdt_netbirimfiyat")]
    public double? ShdtNetbirimfiyat { get; set; }

    [Column("shdt_sth_uid")]
    public Guid? ShdtSthUid { get; set; }
}
