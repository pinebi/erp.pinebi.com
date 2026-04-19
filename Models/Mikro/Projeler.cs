using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("projeler")]
public class Projeler
{
    [Column("pro_Guid")]
    public Guid? ProGuid { get; set; }

    [Column("pro_DBCno")]
    public short? ProDBCno { get; set; }

    [Column("pro_SpecRECno")]
    public int? ProSpecRECno { get; set; }

    [Column("pro_iptal")]
    public bool? ProIptal { get; set; }

    [Column("pro_fileid")]
    public short? ProFileid { get; set; }

    [Column("pro_hidden")]
    public bool? ProHidden { get; set; }

    [Column("pro_kilitli")]
    public bool? ProKilitli { get; set; }

    [Column("pro_degisti")]
    public bool? ProDegisti { get; set; }

    [Column("pro_checksum")]
    public int? ProChecksum { get; set; }

    [Column("pro_create_user")]
    public short? ProCreateUser { get; set; }

    [Column("pro_create_date")]
    public DateTime? ProCreateDate { get; set; }

    [Column("pro_lastup_user")]
    public short? ProLastupUser { get; set; }

    [Column("pro_lastup_date")]
    public DateTime? ProLastupDate { get; set; }

    [Column("pro_special1")]
    [StringLength(4)]
    public string? ProSpecial1 { get; set; }

    [Column("pro_special2")]
    [StringLength(4)]
    public string? ProSpecial2 { get; set; }

    [Column("pro_special3")]
    [StringLength(4)]
    public string? ProSpecial3 { get; set; }

    [Column("pro_kodu")]
    [StringLength(25)]
    public string? ProKodu { get; set; }

    [Column("pro_adi")]
    [StringLength(40)]
    public string? ProAdi { get; set; }

    [Column("pro_musterikodu")]
    [StringLength(25)]
    public string? ProMusterikodu { get; set; }

    [Column("pro_sormerkodu")]
    [StringLength(25)]
    public string? ProSormerkodu { get; set; }

    [Column("pro_bolgekodu")]
    [StringLength(25)]
    public string? ProBolgekodu { get; set; }

    [Column("pro_sektorkodu")]
    [StringLength(25)]
    public string? ProSektorkodu { get; set; }

    [Column("pro_grupkodu")]
    [StringLength(25)]
    public string? ProGrupkodu { get; set; }

    [Column("pro_muh_kod_artikeli")]
    [StringLength(10)]
    public string? ProMuhKodArtikeli { get; set; }

    [Column("pro_durumu")]
    public byte? ProDurumu { get; set; }

    [Column("pro_aciklama")]
    [StringLength(50)]
    public string? ProAciklama { get; set; }

    [Column("pro_ana_projekodu")]
    [StringLength(25)]
    public string? ProAnaProjekodu { get; set; }

    [Column("pro_planlanan_sure")]
    public int? ProPlanlananSure { get; set; }

    [Column("pro_planlanan_bastarih")]
    public DateTime? ProPlanlananBastarih { get; set; }

    [Column("pro_planlanan_bittarih")]
    public DateTime? ProPlanlananBittarih { get; set; }

    [Column("pro_gerceklesen_bastarih")]
    public DateTime? ProGerceklesenBastarih { get; set; }

    [Column("pro_gerceklesen_bittarih")]
    public DateTime? ProGerceklesenBittarih { get; set; }

    [Column("pro_baslangic_gecikmesebep")]
    [StringLength(50)]
    public string? ProBaslangicGecikmesebep { get; set; }

    [Column("pro_bitis_gecikmesebep")]
    [StringLength(50)]
    public string? ProBitisGecikmesebep { get; set; }

    [Column("pro_performans_orani")]
    public double? ProPerformansOrani { get; set; }

    [Column("pro_teminat_sekli")]
    public byte? ProTeminatSekli { get; set; }

    [Column("pro_teminat_doviz_cinsi")]
    public byte? ProTeminatDovizCinsi { get; set; }

    [Column("pro_teminat")]
    public double? ProTeminat { get; set; }

    [Column("pro_isavansi_sekli")]
    public byte? ProIsavansiSekli { get; set; }

    [Column("pro_isavansi_doviz_cinsi")]
    public byte? ProIsavansiDovizCinsi { get; set; }

    [Column("pro_isavansi")]
    public double? ProIsavansi { get; set; }
}
