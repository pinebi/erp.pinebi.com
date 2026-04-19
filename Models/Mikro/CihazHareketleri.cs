using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("cihaz_hareketleri")]
public class CihazHareketleri
{
    [Column("ChHar_Guid")]
    public Guid? ChHarGuid { get; set; }

    [Column("ChHar_DBCno")]
    public short? ChHarDBCno { get; set; }

    [Column("ChHar_Spec_Rec_no")]
    public int? ChHarSpecRecNo { get; set; }

    [Column("ChHar_iptal")]
    public bool? ChHarIptal { get; set; }

    [Column("ChHar_fileid")]
    public short? ChHarFileid { get; set; }

    [Column("ChHar_hidden")]
    public bool? ChHarHidden { get; set; }

    [Column("ChHar_kilitli")]
    public bool? ChHarKilitli { get; set; }

    [Column("ChHar_degisti")]
    public bool? ChHarDegisti { get; set; }

    [Column("ChHar_checksum")]
    public int? ChHarChecksum { get; set; }

    [Column("ChHar_create_user")]
    public short? ChHarCreateUser { get; set; }

    [Column("ChHar_create_date")]
    public DateTime? ChHarCreateDate { get; set; }

    [Column("ChHar_lastup_user")]
    public short? ChHarLastupUser { get; set; }

    [Column("ChHar_lastup_date")]
    public DateTime? ChHarLastupDate { get; set; }

    [Column("ChHar_special1")]
    [StringLength(4)]
    public string? ChHarSpecial1 { get; set; }

    [Column("ChHar_special2")]
    [StringLength(4)]
    public string? ChHarSpecial2 { get; set; }

    [Column("ChHar_special3")]
    [StringLength(4)]
    public string? ChHarSpecial3 { get; set; }

    [Column("ChHar_SeriNo")]
    [StringLength(25)]
    public string? ChHarSeriNo { get; set; }

    [Column("ChHar_StokKodu")]
    [StringLength(25)]
    public string? ChHarStokKodu { get; set; }

    [Column("ChHar_master_tablo")]
    public byte? ChHarMasterTablo { get; set; }

    [Column("ChHar_master_uid")]
    public Guid? ChHarMasterUid { get; set; }

    [Column("ChHar_rezerve_fl")]
    public bool? ChHarRezerveFl { get; set; }
}
