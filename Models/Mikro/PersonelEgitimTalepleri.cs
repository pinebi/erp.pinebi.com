using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_egitim_talepleri")]
public class PersonelEgitimTalepleri
{
    [Column("pet_Guid")]
    public Guid? PetGuid { get; set; }

    [Column("pet_DBCno")]
    public short? PetDBCno { get; set; }

    [Column("pet_SpecRECno")]
    public int? PetSpecRECno { get; set; }

    [Column("pet_iptal")]
    public bool? PetIptal { get; set; }

    [Column("pet_fileid")]
    public short? PetFileid { get; set; }

    [Column("pet_hidden")]
    public bool? PetHidden { get; set; }

    [Column("pet_kilitli")]
    public bool? PetKilitli { get; set; }

    [Column("pet_degisti")]
    public bool? PetDegisti { get; set; }

    [Column("pet_checksum")]
    public int? PetChecksum { get; set; }

    [Column("pet_create_user")]
    public short? PetCreateUser { get; set; }

    [Column("pet_create_date")]
    public DateTime? PetCreateDate { get; set; }

    [Column("pet_lastup_user")]
    public short? PetLastupUser { get; set; }

    [Column("pet_lastup_date")]
    public DateTime? PetLastupDate { get; set; }

    [Column("pet_special1")]
    [StringLength(4)]
    public string? PetSpecial1 { get; set; }

    [Column("pet_special2")]
    [StringLength(4)]
    public string? PetSpecial2 { get; set; }

    [Column("pet_special3")]
    [StringLength(4)]
    public string? PetSpecial3 { get; set; }

    [Column("pet_perskodu")]
    [StringLength(25)]
    public string? PetPerskodu { get; set; }

    [Column("pet_taleptarihi")]
    public DateTime? PetTaleptarihi { get; set; }

    [Column("pet_egitimkodu")]
    [StringLength(25)]
    public string? PetEgitimkodu { get; set; }

    [Column("pet_talepdurumu")]
    public byte? PetTalepdurumu { get; set; }

    [Column("pet_onaylayan_kullanici")]
    public int? PetOnaylayanKullanici { get; set; }
}
