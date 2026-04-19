using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("uretim_operasyon_calisanlari")]
public class UretimOperasyonCalisanlari
{
    [Column("opc_Guid")]
    public Guid? OpcGuid { get; set; }

    [Column("opc_DBCno")]
    public short? OpcDBCno { get; set; }

    [Column("opc_SpecRECNo")]
    public int? OpcSpecRECNo { get; set; }

    [Column("opc_iptal")]
    public bool? OpcIptal { get; set; }

    [Column("opc_fileid")]
    public short? OpcFileid { get; set; }

    [Column("opc_hidden")]
    public bool? OpcHidden { get; set; }

    [Column("opc_kilitli")]
    public bool? OpcKilitli { get; set; }

    [Column("opc_degisti")]
    public bool? OpcDegisti { get; set; }

    [Column("opc_checksum")]
    public int? OpcChecksum { get; set; }

    [Column("opc_create_user")]
    public short? OpcCreateUser { get; set; }

    [Column("opc_create_date")]
    public DateTime? OpcCreateDate { get; set; }

    [Column("opc_lastup_user")]
    public short? OpcLastupUser { get; set; }

    [Column("opc_lastup_date")]
    public DateTime? OpcLastupDate { get; set; }

    [Column("opc_special1")]
    [StringLength(4)]
    public string? OpcSpecial1 { get; set; }

    [Column("opc_special2")]
    [StringLength(4)]
    public string? OpcSpecial2 { get; set; }

    [Column("opc_special3")]
    [StringLength(4)]
    public string? OpcSpecial3 { get; set; }

    [Column("opc_OpTamam_uid")]
    public Guid? OpcOpTamamUid { get; set; }

    [Column("opc_PersonelKodu")]
    [StringLength(25)]
    public string? OpcPersonelKodu { get; set; }

    [Column("opc_CalistigiSure")]
    public int? OpcCalistigiSure { get; set; }
}
