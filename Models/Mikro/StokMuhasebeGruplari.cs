using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("stok_muhasebe_gruplari")]
public class StokMuhasebeGruplari
{
    [Column("stmuh_Guid")]
    public Guid StmuhGuid { get; set; }

    [Column("stmuh_DBCno")]
    public short? StmuhDBCno { get; set; }

    [Column("stmuh_SpecRECno")]
    public int? StmuhSpecRECno { get; set; }

    [Column("stmuh_iptal")]
    public bool? StmuhIptal { get; set; }

    [Column("stmuh_fileid")]
    public short? StmuhFileid { get; set; }

    [Column("stmuh_hidden")]
    public bool? StmuhHidden { get; set; }

    [Column("stmuh_kilitli")]
    public bool? StmuhKilitli { get; set; }

    [Column("stmuh_degisti")]
    public bool? StmuhDegisti { get; set; }

    [Column("stmuh_checksum")]
    public int? StmuhChecksum { get; set; }

    [Column("stmuh_create_user")]
    public short? StmuhCreateUser { get; set; }

    [Column("stmuh_create_date")]
    public DateTime? StmuhCreateDate { get; set; }

    [Column("stmuh_lastup_user")]
    public short? StmuhLastupUser { get; set; }

    [Column("stmuh_lastup_date")]
    public DateTime? StmuhLastupDate { get; set; }

    [Column("stmuh_special1")]
    [StringLength(4)]
    public string? StmuhSpecial1 { get; set; }

    [Column("stmuh_special2")]
    [StringLength(4)]
    public string? StmuhSpecial2 { get; set; }

    [Column("stmuh_special3")]
    [StringLength(4)]
    public string? StmuhSpecial3 { get; set; }

    [Column("stmuh_kod")]
    [StringLength(25)]
    public string StmuhKod { get; set; }

    [Column("stmuh_ismi")]
    public string? StmuhIsmi { get; set; }

    [Column("stmuh_muh_kod")]
    [StringLength(40)]
    public string? StmuhMuhKod { get; set; }

    [Column("stmuh_iade_muh_kod")]
    [StringLength(40)]
    public string? StmuhIadeMuhKod { get; set; }

    [Column("stmuh_YurtIciSatMuhK")]
    [StringLength(40)]
    public string? StmuhYurtIciSatMuhK { get; set; }

    [Column("stmuh_SatIadeMuhKod")]
    [StringLength(40)]
    public string? StmuhSatIadeMuhKod { get; set; }

    [Column("stmuh_SatIskMuhKod")]
    [StringLength(40)]
    public string? StmuhSatIskMuhKod { get; set; }

    [Column("stmuh_Al_IskMKod")]
    [StringLength(40)]
    public string? StmuhAlIskMKod { get; set; }

    [Column("stmuh_SatMalMuhKod")]
    [StringLength(40)]
    public string? StmuhSatMalMuhKod { get; set; }

    [Column("stmuh_YurtDisiSatMuh")]
    [StringLength(40)]
    public string? StmuhYurtDisiSatMuh { get; set; }

    [Column("stmuh_ilavemasmuhkod")]
    [StringLength(40)]
    public string? StmuhIlavemasmuhkod { get; set; }

    [Column("stmuh_yatirimtesmuhkod")]
    [StringLength(40)]
    public string? StmuhYatirimtesmuhkod { get; set; }

    [Column("stmuh_depsatmuhkod")]
    [StringLength(40)]
    public string? StmuhDepsatmuhkod { get; set; }

    [Column("stmuh_depsatmalmuhkod")]
    [StringLength(40)]
    public string? StmuhDepsatmalmuhkod { get; set; }

    [Column("stmuh_bagortsatmuhkod")]
    [StringLength(40)]
    public string? StmuhBagortsatmuhkod { get; set; }

    [Column("stmuh_bagortsatIadmuhkod")]
    [StringLength(40)]
    public string? StmuhBagortsatIadmuhkod { get; set; }

    [Column("stmuh_bagortsatIskmuhkod")]
    [StringLength(40)]
    public string? StmuhBagortsatIskmuhkod { get; set; }

    [Column("stmuh_satfiyfarksmuhkod")]
    [StringLength(40)]
    public string? StmuhSatfiyfarksmuhkod { get; set; }

    [Column("stmuh_yurtdisisatmalmuhkod")]
    [StringLength(40)]
    public string? StmuhYurtdisisatmalmuhkod { get; set; }

    [Column("stmuh_bagortsatmalmuhkod")]
    [StringLength(40)]
    public string? StmuhBagortsatmalmuhkod { get; set; }

    [Column("stmuh_sifirbedsatmalmuhkod")]
    [StringLength(40)]
    public string? StmuhSifirbedsatmalmuhkod { get; set; }

    [Column("stmuh_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhUfrsfarkKod { get; set; }

    [Column("stmuh_iade_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhIadeUfrsfarkKod { get; set; }

    [Column("stmuh_yurticisat_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhYurticisatUfrsfarkKod { get; set; }

    [Column("stmuh_satiade_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhSatiadeUfrsfarkKod { get; set; }

    [Column("stmuh_satisk_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhSatiskUfrsfarkKod { get; set; }

    [Column("stmuh_alisk_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhAliskUfrsfarkKod { get; set; }

    [Column("stmuh_satmal_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhSatmalUfrsfarkKod { get; set; }

    [Column("stmuh_yurtdisisat_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhYurtdisisatUfrsfarkKod { get; set; }

    [Column("stmuh_ilavemas_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhIlavemasUfrsfarkKod { get; set; }

    [Column("stmuh_yatirimtes_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhYatirimtesUfrsfarkKod { get; set; }

    [Column("stmuh_depsat_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhDepsatUfrsfarkKod { get; set; }

    [Column("stmuh_depsatmal_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhDepsatmalUfrsfarkKod { get; set; }

    [Column("stmuh_bagortsat_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhBagortsatUfrsfarkKod { get; set; }

    [Column("stmuh_bagortsatiade_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhBagortsatiadeUfrsfarkKod { get; set; }

    [Column("stmuh_bagortsatisk_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhBagortsatiskUfrsfarkKod { get; set; }

    [Column("stmuh_satfiyfark_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhSatfiyfarkUfrsfarkKod { get; set; }

    [Column("stmuh_yurtdisisatmal_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhYurtdisisatmalUfrsfarkKod { get; set; }

    [Column("stmuh_bagortsatmal_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhBagortsatmalUfrsfarkKod { get; set; }

    [Column("stmuh_sifirbedsatmal_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhSifirbedsatmalUfrsfarkKod { get; set; }

    [Column("stmuh_uretimmaliyet_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhUretimmaliyetUfrsfarkKod { get; set; }

    [Column("stmuh_uretimkapasite_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhUretimkapasiteUfrsfarkKod { get; set; }

    [Column("stmuh_degerdusuklugu_ufrsfark_kod")]
    [StringLength(40)]
    public string? StmuhDegerdusukluguUfrsfarkKod { get; set; }
}
