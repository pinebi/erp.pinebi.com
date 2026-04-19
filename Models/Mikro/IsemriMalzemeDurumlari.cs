using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("isemri_malzeme_durumlari")]
public class IsemriMalzemeDurumlari
{
    [Column("ish_Guid")]
    public Guid? IshGuid { get; set; }

    [Column("ish_DBCno")]
    public short? IshDBCno { get; set; }

    [Column("ish_SpecRecNo")]
    public int? IshSpecRecNo { get; set; }

    [Column("ish_iptal")]
    public bool? IshIptal { get; set; }

    [Column("ish_fileid")]
    public short? IshFileid { get; set; }

    [Column("ish_hidden")]
    public bool? IshHidden { get; set; }

    [Column("ish_kilitli")]
    public bool? IshKilitli { get; set; }

    [Column("ish_degisti")]
    public bool? IshDegisti { get; set; }

    [Column("ish_checksum")]
    public int? IshChecksum { get; set; }

    [Column("ish_create_user")]
    public short? IshCreateUser { get; set; }

    [Column("ish_create_date")]
    public DateTime? IshCreateDate { get; set; }

    [Column("ish_lastup_user")]
    public short? IshLastupUser { get; set; }

    [Column("ish_lastup_date")]
    public DateTime? IshLastupDate { get; set; }

    [Column("ish_ozelkod1")]
    [StringLength(4)]
    public string? IshOzelkod1 { get; set; }

    [Column("ish_ozelkod2")]
    [StringLength(4)]
    public string? IshOzelkod2 { get; set; }

    [Column("ish_ozelkod3")]
    [StringLength(4)]
    public string? IshOzelkod3 { get; set; }

    [Column("ish_stok_hizm_gider")]
    public byte? IshStokHizmGider { get; set; }

    [Column("ish_stokhizm_gid_kod")]
    [StringLength(25)]
    public string? IshStokhizmGidKod { get; set; }

    [Column("ish_isemri")]
    [StringLength(25)]
    public string? IshIsemri { get; set; }

    [Column("ish_fasoncu")]
    [StringLength(25)]
    public string? IshFasoncu { get; set; }

    [Column("ish_sevk_miktar")]
    public double? IshSevkMiktar { get; set; }

    [Column("ish_sevk_deger0")]
    public double? IshSevkDeger0 { get; set; }

    [Column("ish_sevk_deger1")]
    public double? IshSevkDeger1 { get; set; }

    [Column("ish_sevk_deger2")]
    public double? IshSevkDeger2 { get; set; }

    [Column("ish_iade_miktar")]
    public double? IshIadeMiktar { get; set; }

    [Column("ish_iade_deger0")]
    public double? IshIadeDeger0 { get; set; }

    [Column("ish_iade_deger1")]
    public double? IshIadeDeger1 { get; set; }

    [Column("ish_iade_deger2")]
    public double? IshIadeDeger2 { get; set; }

    [Column("ish_tuket_miktar")]
    public double? IshTuketMiktar { get; set; }

    [Column("ish_tuket_deger0")]
    public double? IshTuketDeger0 { get; set; }

    [Column("ish_tuket_deger1")]
    public double? IshTuketDeger1 { get; set; }

    [Column("ish_tuket_deger2")]
    public double? IshTuketDeger2 { get; set; }

    [Column("ish_uret_miktar")]
    public double? IshUretMiktar { get; set; }

    [Column("ish_uret_deger0")]
    public double? IshUretDeger0 { get; set; }

    [Column("ish_uret_deger1")]
    public double? IshUretDeger1 { get; set; }

    [Column("ish_uret_deger2")]
    public double? IshUretDeger2 { get; set; }

    [Column("ish_uretiade_miktar")]
    public double? IshUretiadeMiktar { get; set; }

    [Column("ish_uretiade_deg0")]
    public double? IshUretiadeDeg0 { get; set; }

    [Column("ish_uretiade_deg1")]
    public double? IshUretiadeDeg1 { get; set; }

    [Column("ish_uretiade_deg2")]
    public double? IshUretiadeDeg2 { get; set; }

    [Column("ish_plan_sevkmiktar")]
    public double? IshPlanSevkmiktar { get; set; }

    [Column("ish_planuretim")]
    public double? IshPlanuretim { get; set; }

    [Column("ish_GenelUretimMaliyeti_Ana")]
    public double? IshGenelUretimMaliyetiAna { get; set; }

    [Column("ish_GenelUretimMaliyeti_Alt")]
    public double? IshGenelUretimMaliyetiAlt { get; set; }

    [Column("ish_GenelUretimMaliyeti_Orj")]
    public double? IshGenelUretimMaliyetiOrj { get; set; }

    [Column("ish_DirektIscilikMaliyeti_Ana")]
    public double? IshDirektIscilikMaliyetiAna { get; set; }

    [Column("ish_DirektIscilikMaliyeti_Alt")]
    public double? IshDirektIscilikMaliyetiAlt { get; set; }

    [Column("ish_DirektIscilikMaliyeti_Orj")]
    public double? IshDirektIscilikMaliyetiOrj { get; set; }
}
