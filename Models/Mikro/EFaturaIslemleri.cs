using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("e_fatura_islemleri")]
public class EFaturaIslemleri
{
    [Column("efi_Guid")]
    public Guid? EfiGuid { get; set; }

    [Column("efi_DBCno")]
    public short? EfiDBCno { get; set; }

    [Column("efi_SpecRECno")]
    public int? EfiSpecRECno { get; set; }

    [Column("efi_iptal")]
    public bool? EfiIptal { get; set; }

    [Column("efi_fileid")]
    public short? EfiFileid { get; set; }

    [Column("efi_hidden")]
    public bool? EfiHidden { get; set; }

    [Column("efi_kilitli")]
    public bool? EfiKilitli { get; set; }

    [Column("efi_degisti")]
    public bool? EfiDegisti { get; set; }

    [Column("efi_checksum")]
    public int? EfiChecksum { get; set; }

    [Column("efi_create_user")]
    public short? EfiCreateUser { get; set; }

    [Column("efi_create_date")]
    public DateTime? EfiCreateDate { get; set; }

    [Column("efi_lastup_user")]
    public short? EfiLastupUser { get; set; }

    [Column("efi_lastup_date")]
    public DateTime? EfiLastupDate { get; set; }

    [Column("efi_special1")]
    [StringLength(4)]
    public string? EfiSpecial1 { get; set; }

    [Column("efi_special2")]
    [StringLength(4)]
    public string? EfiSpecial2 { get; set; }

    [Column("efi_special3")]
    [StringLength(4)]
    public string? EfiSpecial3 { get; set; }

    [Column("efi_tip")]
    public byte? EfiTip { get; set; }

    [Column("efi_evrakno_seri")]
    [StringLength(50)]
    public string? EfiEvraknoSeri { get; set; }

    [Column("efi_evrakno_sira")]
    public int? EfiEvraknoSira { get; set; }

    [Column("efi_evrak_tipi")]
    public byte? EfiEvrakTipi { get; set; }

    [Column("efi_gib_seri_sira")]
    [StringLength(40)]
    public string? EfiGibSeriSira { get; set; }

    [Column("efi_uuid")]
    [StringLength(40)]
    public string? EfiUuid { get; set; }

    [Column("efi_onaylandi_fl")]
    public bool? EfiOnaylandiFl { get; set; }

    [Column("efi_OnaylayanKulNo")]
    public short? EfiOnaylayanKulNo { get; set; }

    [Column("efi_onaylama_tarihi")]
    public DateTime? EfiOnaylamaTarihi { get; set; }

    [Column("efi_islem_tipi")]
    public byte? EfiIslemTipi { get; set; }

    [Column("efi_yazdirma_sayisi")]
    public int? EfiYazdirmaSayisi { get; set; }

    [Column("efi_fpgonderildi_fl")]
    public bool? EfiFpgonderildiFl { get; set; }
}
