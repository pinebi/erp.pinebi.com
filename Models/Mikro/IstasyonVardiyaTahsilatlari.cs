using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("istasyon_vardiya_tahsilatlari")]
public class IstasyonVardiyaTahsilatlari
{
    [Column("vn_Guid")]
    public Guid? VnGuid { get; set; }

    [Column("vn_DBCno")]
    public short? VnDBCno { get; set; }

    [Column("vn_SpecRECno")]
    public int? VnSpecRECno { get; set; }

    [Column("vn_iptal")]
    public bool? VnIptal { get; set; }

    [Column("vn_fileid")]
    public short? VnFileid { get; set; }

    [Column("vn_hidden")]
    public bool? VnHidden { get; set; }

    [Column("vn_kilitli")]
    public bool? VnKilitli { get; set; }

    [Column("vn_degisti")]
    public bool? VnDegisti { get; set; }

    [Column("vn_checksum")]
    public int? VnChecksum { get; set; }

    [Column("vn_create_user")]
    public short? VnCreateUser { get; set; }

    [Column("vn_create_date")]
    public DateTime? VnCreateDate { get; set; }

    [Column("vn_lastup_user")]
    public short? VnLastupUser { get; set; }

    [Column("vn_lastup_date")]
    public DateTime? VnLastupDate { get; set; }

    [Column("vn_special1")]
    [StringLength(4)]
    public string? VnSpecial1 { get; set; }

    [Column("vn_special2")]
    [StringLength(4)]
    public string? VnSpecial2 { get; set; }

    [Column("vn_special3")]
    [StringLength(4)]
    public string? VnSpecial3 { get; set; }

    [Column("vn_firmano")]
    public int? VnFirmano { get; set; }

    [Column("vn_subeno")]
    public int? VnSubeno { get; set; }

    [Column("vn_vardiyahesaptip")]
    public byte? VnVardiyahesaptip { get; set; }

    [Column("vn_Tarihi")]
    public DateTime? VnTarihi { get; set; }

    [Column("vn_Numarasi")]
    public byte? VnNumarasi { get; set; }

    [Column("vn_pers_kodu")]
    [StringLength(25)]
    public string? VnPersKodu { get; set; }

    [Column("vn_sira_no")]
    public int? VnSiraNo { get; set; }

    [Column("vn_kasa_banka_kodu")]
    [StringLength(25)]
    public string? VnKasaBankaKodu { get; set; }

    [Column("vn_Tahsilat_sekli")]
    public byte? VnTahsilatSekli { get; set; }

    [Column("vn_Tutar")]
    public double? VnTutar { get; set; }

    [Column("vn_Musteri_Komisyon")]
    public double? VnMusteriKomisyon { get; set; }

    [Column("vn_VadeTarihi")]
    public DateTime? VnVadeTarihi { get; set; }
}
