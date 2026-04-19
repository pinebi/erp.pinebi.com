using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("hesap_ozeti_islem_kodlari")]
public class HesapOzetiIslemKodlari
{
    [Column("ehoz_Guid")]
    public Guid? EhozGuid { get; set; }

    [Column("ehoz_DBCno")]
    public short? EhozDBCno { get; set; }

    [Column("ehoz_SpecRECno")]
    public int? EhozSpecRECno { get; set; }

    [Column("ehoz_iptal")]
    public bool? EhozIptal { get; set; }

    [Column("ehoz_fileid")]
    public short? EhozFileid { get; set; }

    [Column("ehoz_hidden")]
    public bool? EhozHidden { get; set; }

    [Column("ehoz_kilitli")]
    public bool? EhozKilitli { get; set; }

    [Column("ehoz_degisti")]
    public bool? EhozDegisti { get; set; }

    [Column("ehoz_checksum")]
    public int? EhozChecksum { get; set; }

    [Column("ehoz_create_user")]
    public short? EhozCreateUser { get; set; }

    [Column("ehoz_create_date")]
    public DateTime? EhozCreateDate { get; set; }

    [Column("ehoz_lastup_user")]
    public short? EhozLastupUser { get; set; }

    [Column("ehoz_lastup_date")]
    public DateTime? EhozLastupDate { get; set; }

    [Column("ehoz_special1")]
    [StringLength(4)]
    public string? EhozSpecial1 { get; set; }

    [Column("ehoz_special2")]
    [StringLength(4)]
    public string? EhozSpecial2 { get; set; }

    [Column("ehoz_special3")]
    [StringLength(4)]
    public string? EhozSpecial3 { get; set; }

    [Column("ehoz_bankahesapcinsi")]
    public byte? EhozBankahesapcinsi { get; set; }

    [Column("ehoz_bankahesapkodu")]
    [StringLength(25)]
    public string? EhozBankahesapkodu { get; set; }

    [Column("ehoz_satirno")]
    public int? EhozSatirno { get; set; }

    [Column("ehoz_islemkodu")]
    [StringLength(50)]
    public string? EhozIslemkodu { get; set; }

    [Column("ehoz_islemaciklamasi")]
    [StringLength(50)]
    public string? EhozIslemaciklamasi { get; set; }

    [Column("ehoz_karsihesapcinsi")]
    public byte? EhozKarsihesapcinsi { get; set; }

    [Column("ehoz_karsihesapkodu")]
    [StringLength(25)]
    public string? EhozKarsihesapkodu { get; set; }

    [Column("ehoz_karsihesapgrupno")]
    public byte? EhozKarsihesapgrupno { get; set; }

    [Column("ehoz_evraktipi")]
    public byte? EhozEvraktipi { get; set; }

    [Column("ehoz_stfonpntr")]
    public byte? EhozStfonpntr { get; set; }

    [Column("ehoz_evrakseri")]
    [StringLength(50)]
    public string? EhozEvrakseri { get; set; }

    [Column("ehoz_faturacirocarikodu")]
    [StringLength(25)]
    public string? EhozFaturacirocarikodu { get; set; }

    [Column("ehoz_srmmrk")]
    [StringLength(25)]
    public string? EhozSrmmrk { get; set; }

    [Column("ehoz_proje")]
    [StringLength(25)]
    public string? EhozProje { get; set; }

    [Column("ehoz_mfis_kisaevraktipi")]
    public byte? EhozMfisKisaevraktipi { get; set; }

    [Column("ehoz_mfis_satistipi")]
    public byte? EhozMfisSatistipi { get; set; }

    [Column("ehoz_mfis_alistipi")]
    public byte? EhozMfisAlistipi { get; set; }

    [Column("ehoz_mfis_tahtedtipi")]
    public byte? EhozMfisTahtedtipi { get; set; }

    [Column("ehoz_mfis_digerevrakadi")]
    [StringLength(50)]
    public string? EhozMfisDigerevrakadi { get; set; }

    [Column("ehoz_satici_kodu")]
    [StringLength(25)]
    public string? EhozSaticiKodu { get; set; }
}
