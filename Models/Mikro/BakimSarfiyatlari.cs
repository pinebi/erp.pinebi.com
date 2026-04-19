using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("bakim_sarfiyatlari")]
public class BakimSarfiyatlari
{
    [Column("bsrf_Guid")]
    public Guid? BsrfGuid { get; set; }

    [Column("bsrf_DBCno")]
    public short? BsrfDBCno { get; set; }

    [Column("bsrf_Spec_Rec_no")]
    public int? BsrfSpecRecNo { get; set; }

    [Column("bsrf_iptal")]
    public bool? BsrfIptal { get; set; }

    [Column("bsrf_fileid")]
    public short? BsrfFileid { get; set; }

    [Column("bsrf_hidden")]
    public bool? BsrfHidden { get; set; }

    [Column("bsrf_kilitli")]
    public bool? BsrfKilitli { get; set; }

    [Column("bsrf_degisti")]
    public bool? BsrfDegisti { get; set; }

    [Column("bsrf_checksum")]
    public int? BsrfChecksum { get; set; }

    [Column("bsrf_create_user")]
    public short? BsrfCreateUser { get; set; }

    [Column("bsrf_create_date")]
    public DateTime? BsrfCreateDate { get; set; }

    [Column("bsrf_lastup_user")]
    public short? BsrfLastupUser { get; set; }

    [Column("bsrf_lastup_date")]
    public DateTime? BsrfLastupDate { get; set; }

    [Column("bsrf_special1")]
    [StringLength(4)]
    public string? BsrfSpecial1 { get; set; }

    [Column("bsrf_special2")]
    [StringLength(4)]
    public string? BsrfSpecial2 { get; set; }

    [Column("bsrf_special3")]
    [StringLength(4)]
    public string? BsrfSpecial3 { get; set; }

    [Column("bsrf_firmano")]
    public int? BsrfFirmano { get; set; }

    [Column("bsrf_subeno")]
    public int? BsrfSubeno { get; set; }

    [Column("bsrf_evraktarihi")]
    public DateTime? BsrfEvraktarihi { get; set; }

    [Column("bsrf_evrakseri")]
    [StringLength(50)]
    public string? BsrfEvrakseri { get; set; }

    [Column("bsrf_evraksira")]
    public int? BsrfEvraksira { get; set; }

    [Column("bsrf_evraksatir")]
    public int? BsrfEvraksatir { get; set; }

    [Column("bsrf_belgeno")]
    [StringLength(50)]
    public string? BsrfBelgeno { get; set; }

    [Column("bsrf_belge_tarih")]
    public DateTime? BsrfBelgeTarih { get; set; }

    [Column("bsrf_isemri")]
    [StringLength(25)]
    public string? BsrfIsemri { get; set; }

    [Column("bsrf_StokKodu")]
    [StringLength(25)]
    public string? BsrfStokKodu { get; set; }

    [Column("bsrf_Miktar")]
    public double? BsrfMiktar { get; set; }

    [Column("bsrf_birim_pntr")]
    public byte? BsrfBirimPntr { get; set; }

    [Column("bsrf_aciklama")]
    [StringLength(40)]
    public string? BsrfAciklama { get; set; }

    [Column("bsrf_proje")]
    [StringLength(25)]
    public string? BsrfProje { get; set; }

    [Column("bsrf_srmmrkkodu")]
    [StringLength(25)]
    public string? BsrfSrmmrkkodu { get; set; }
}
