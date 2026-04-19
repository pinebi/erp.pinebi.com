using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("vardiyalar")]
public class Vardiyalar
{
    [Column("vardiya_Guid")]
    public Guid? VardiyaGuid { get; set; }

    [Column("vardiya_DBCno")]
    public short? VardiyaDBCno { get; set; }

    [Column("vardiya_SpecRECNo")]
    public int? VardiyaSpecRECNo { get; set; }

    [Column("vardiya_iptal")]
    public bool? VardiyaIptal { get; set; }

    [Column("vardiya_fileid")]
    public short? VardiyaFileid { get; set; }

    [Column("vardiya_hidden")]
    public bool? VardiyaHidden { get; set; }

    [Column("vardiya_kilitli")]
    public bool? VardiyaKilitli { get; set; }

    [Column("vardiya_degisti")]
    public bool? VardiyaDegisti { get; set; }

    [Column("vardiya_checksum")]
    public int? VardiyaChecksum { get; set; }

    [Column("vardiya_create_user")]
    public short? VardiyaCreateUser { get; set; }

    [Column("vardiya_create_date")]
    public DateTime? VardiyaCreateDate { get; set; }

    [Column("vardiya_lastup_user")]
    public short? VardiyaLastupUser { get; set; }

    [Column("vardiya_lastup_date")]
    public DateTime? VardiyaLastupDate { get; set; }

    [Column("vardiya_special1")]
    [StringLength(4)]
    public string? VardiyaSpecial1 { get; set; }

    [Column("vardiya_special2")]
    [StringLength(4)]
    public string? VardiyaSpecial2 { get; set; }

    [Column("vardiya_special3")]
    [StringLength(4)]
    public string? VardiyaSpecial3 { get; set; }

    [Column("vardiya_kodu")]
    [StringLength(25)]
    public string? VardiyaKodu { get; set; }

    [Column("vardiya_ismi")]
    [StringLength(40)]
    public string? VardiyaIsmi { get; set; }

    [Column("vardiya_adedi")]
    public byte? VardiyaAdedi { get; set; }

    [Column("vardiya_renk")]
    public int? VardiyaRenk { get; set; }

    [Column("vardiya_ekkazancno")]
    public byte? VardiyaEkkazancno { get; set; }

    [Column("vardiya_tolerans")]
    public int? VardiyaTolerans { get; set; }

    [Column("vardiya_vbassaat1")]
    public DateTime? VardiyaVbassaat1 { get; set; }

    [Column("vardiya_vbitsaat1")]
    public DateTime? VardiyaVbitsaat1 { get; set; }

    [Column("vardiya_vmobassaat1_1")]
    public DateTime? VardiyaVmobassaat11 { get; set; }

    [Column("vardiya_vmobitsaat1_1")]
    public DateTime? VardiyaVmobitsaat11 { get; set; }

    [Column("vardiya_vmobassaat1_2")]
    public DateTime? VardiyaVmobassaat12 { get; set; }

    [Column("vardiya_vmobitsaat1_2")]
    public DateTime? VardiyaVmobitsaat12 { get; set; }

    [Column("vardiya_vmobassaat1_3")]
    public DateTime? VardiyaVmobassaat13 { get; set; }

    [Column("vardiya_vmobitsaat1_3")]
    public DateTime? VardiyaVmobitsaat13 { get; set; }

    [Column("vardiya_vmobassaat1_4")]
    public DateTime? VardiyaVmobassaat14 { get; set; }

    [Column("vardiya_vmobitsaat1_4")]
    public DateTime? VardiyaVmobitsaat14 { get; set; }

    [Column("vardiya_vbassaat2")]
    public DateTime? VardiyaVbassaat2 { get; set; }

    [Column("vardiya_vbitsaat2")]
    public DateTime? VardiyaVbitsaat2 { get; set; }

    [Column("vardiya_vmobassaat2_1")]
    public DateTime? VardiyaVmobassaat21 { get; set; }

    [Column("vardiya_vmobitsaat2_1")]
    public DateTime? VardiyaVmobitsaat21 { get; set; }

    [Column("vardiya_vmobassaat2_2")]
    public DateTime? VardiyaVmobassaat22 { get; set; }

    [Column("vardiya_vmobitsaat2_2")]
    public DateTime? VardiyaVmobitsaat22 { get; set; }

    [Column("vardiya_vmobassaat2_3")]
    public DateTime? VardiyaVmobassaat23 { get; set; }

    [Column("vardiya_vmobitsaat2_3")]
    public DateTime? VardiyaVmobitsaat23 { get; set; }

    [Column("vardiya_vmobassaat2_4")]
    public DateTime? VardiyaVmobassaat24 { get; set; }

    [Column("vardiya_vmobitsaat2_4")]
    public DateTime? VardiyaVmobitsaat24 { get; set; }

    [Column("vardiya_vbassaat3")]
    public DateTime? VardiyaVbassaat3 { get; set; }

    [Column("vardiya_vbitsaat3")]
    public DateTime? VardiyaVbitsaat3 { get; set; }

    [Column("vardiya_vmobassaat3_1")]
    public DateTime? VardiyaVmobassaat31 { get; set; }

    [Column("vardiya_vmobitsaat3_1")]
    public DateTime? VardiyaVmobitsaat31 { get; set; }

    [Column("vardiya_vmobassaat3_2")]
    public DateTime? VardiyaVmobassaat32 { get; set; }

    [Column("vardiya_vmobitsaat3_2")]
    public DateTime? VardiyaVmobitsaat32 { get; set; }

    [Column("vardiya_vmobassaat3_3")]
    public DateTime? VardiyaVmobassaat33 { get; set; }

    [Column("vardiya_vmobitsaat3_3")]
    public DateTime? VardiyaVmobitsaat33 { get; set; }

    [Column("vardiya_vmobassaat3_4")]
    public DateTime? VardiyaVmobassaat34 { get; set; }

    [Column("vardiya_vmobitsaat3_4")]
    public DateTime? VardiyaVmobitsaat34 { get; set; }

    [Column("vardiya_vbassaat4")]
    public DateTime? VardiyaVbassaat4 { get; set; }

    [Column("vardiya_vbitsaat4")]
    public DateTime? VardiyaVbitsaat4 { get; set; }

    [Column("vardiya_vmobassaat4_1")]
    public DateTime? VardiyaVmobassaat41 { get; set; }

    [Column("vardiya_vmobitsaat4_1")]
    public DateTime? VardiyaVmobitsaat41 { get; set; }

    [Column("vardiya_vmobassaat4_2")]
    public DateTime? VardiyaVmobassaat42 { get; set; }

    [Column("vardiya_vmobitsaat4_2")]
    public DateTime? VardiyaVmobitsaat42 { get; set; }

    [Column("vardiya_vmobassaat4_3")]
    public DateTime? VardiyaVmobassaat43 { get; set; }

    [Column("vardiya_vmobitsaat4_3")]
    public DateTime? VardiyaVmobitsaat43 { get; set; }

    [Column("vardiya_vmobassaat4_4")]
    public DateTime? VardiyaVmobassaat44 { get; set; }

    [Column("vardiya_vmobitsaat4_4")]
    public DateTime? VardiyaVmobitsaat44 { get; set; }
}
