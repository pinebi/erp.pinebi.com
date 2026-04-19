using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("bakim_pdi_tanimlari")]
public class BakimPdiTanimlari
{
    [Column("bpdi_Guid")]
    public Guid? BpdiGuid { get; set; }

    [Column("bpdi_DBCno")]
    public short? BpdiDBCno { get; set; }

    [Column("bpdi_SpecRECno")]
    public int? BpdiSpecRECno { get; set; }

    [Column("bpdi_iptal")]
    public bool? BpdiIptal { get; set; }

    [Column("bpdi_fileid")]
    public short? BpdiFileid { get; set; }

    [Column("bpdi_hidden")]
    public bool? BpdiHidden { get; set; }

    [Column("bpdi_kilitli")]
    public bool? BpdiKilitli { get; set; }

    [Column("bpdi_degisti")]
    public bool? BpdiDegisti { get; set; }

    [Column("bpdi_checksum")]
    public int? BpdiChecksum { get; set; }

    [Column("bpdi_create_user")]
    public short? BpdiCreateUser { get; set; }

    [Column("bpdi_create_date")]
    public DateTime? BpdiCreateDate { get; set; }

    [Column("bpdi_lastup_user")]
    public short? BpdiLastupUser { get; set; }

    [Column("bpdi_lastup_date")]
    public DateTime? BpdiLastupDate { get; set; }

    [Column("bpdi_special1")]
    [StringLength(4)]
    public string? BpdiSpecial1 { get; set; }

    [Column("bpdi_special2")]
    [StringLength(4)]
    public string? BpdiSpecial2 { get; set; }

    [Column("bpdi_special3")]
    [StringLength(4)]
    public string? BpdiSpecial3 { get; set; }

    [Column("bpdi_kodu")]
    [StringLength(25)]
    public string? BpdiKodu { get; set; }

    [Column("bpdi_kontrol_tarihi")]
    public DateTime? BpdiKontrolTarihi { get; set; }

    [Column("bpdi_stok_kodu")]
    [StringLength(25)]
    public string? BpdiStokKodu { get; set; }

    [Column("bpdi_cihaz_seri")]
    [StringLength(25)]
    public string? BpdiCihazSeri { get; set; }

    [Column("bpdi_sayac")]
    public int? BpdiSayac { get; set; }

    [Column("bpdi_gidecegi_cari")]
    [StringLength(25)]
    public string? BpdiGidecegiCari { get; set; }

    [Column("bpdi_perskodu")]
    [StringLength(25)]
    public string? BpdiPerskodu { get; set; }

    [Column("bpdi_kontrol_sonucu")]
    public byte? BpdiKontrolSonucu { get; set; }

    [Column("bpdi_aciklama1")]
    [StringLength(60)]
    public string? BpdiAciklama1 { get; set; }

    [Column("bpdi_aciklama2")]
    [StringLength(60)]
    public string? BpdiAciklama2 { get; set; }
}
