using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("uretim_plan_matrisi")]
public class UretimPlanMatrisi
{
    [Column("mtrs_Guid")]
    public Guid? MtrsGuid { get; set; }

    [Column("mtrs_DBCno")]
    public short? MtrsDBCno { get; set; }

    [Column("mtrs_SpecRECno")]
    public int? MtrsSpecRECno { get; set; }

    [Column("mtrs_iptal")]
    public bool? MtrsIptal { get; set; }

    [Column("mtrs_fileid")]
    public short? MtrsFileid { get; set; }

    [Column("mtrs_hidden")]
    public bool? MtrsHidden { get; set; }

    [Column("mtrs_kilitli")]
    public bool? MtrsKilitli { get; set; }

    [Column("mtrs_degisti")]
    public bool? MtrsDegisti { get; set; }

    [Column("mtrs_checksum")]
    public int? MtrsChecksum { get; set; }

    [Column("mtrs_create_user")]
    public short? MtrsCreateUser { get; set; }

    [Column("mtrs_create_date")]
    public DateTime? MtrsCreateDate { get; set; }

    [Column("mtrs_lastup_user")]
    public short? MtrsLastupUser { get; set; }

    [Column("mtrs_lastup_date")]
    public DateTime? MtrsLastupDate { get; set; }

    [Column("mtrs_special1")]
    [StringLength(4)]
    public string? MtrsSpecial1 { get; set; }

    [Column("mtrs_special2")]
    [StringLength(4)]
    public string? MtrsSpecial2 { get; set; }

    [Column("mtrs_special3")]
    [StringLength(4)]
    public string? MtrsSpecial3 { get; set; }

    [Column("mtrs_kodu")]
    [StringLength(25)]
    public string? MtrsKodu { get; set; }

    [Column("mtrs_aciklama")]
    [StringLength(50)]
    public string? MtrsAciklama { get; set; }

    [Column("mtrs_donemadi1")]
    [StringLength(25)]
    public string? MtrsDonemadi1 { get; set; }

    [Column("mtrs_bastar1")]
    public DateTime? MtrsBastar1 { get; set; }

    [Column("mtrs_bittar1")]
    public DateTime? MtrsBittar1 { get; set; }

    [Column("mtrs_donemadi2")]
    [StringLength(25)]
    public string? MtrsDonemadi2 { get; set; }

    [Column("mtrs_bastar2")]
    public DateTime? MtrsBastar2 { get; set; }

    [Column("mtrs_bittar2")]
    public DateTime? MtrsBittar2 { get; set; }

    [Column("mtrs_donemadi3")]
    [StringLength(25)]
    public string? MtrsDonemadi3 { get; set; }

    [Column("mtrs_bastar3")]
    public DateTime? MtrsBastar3 { get; set; }

    [Column("mtrs_bittar3")]
    public DateTime? MtrsBittar3 { get; set; }

    [Column("mtrs_donemadi4")]
    [StringLength(25)]
    public string? MtrsDonemadi4 { get; set; }

    [Column("mtrs_bastar4")]
    public DateTime? MtrsBastar4 { get; set; }

    [Column("mtrs_bittar4")]
    public DateTime? MtrsBittar4 { get; set; }

    [Column("mtrs_donemadi5")]
    [StringLength(25)]
    public string? MtrsDonemadi5 { get; set; }

    [Column("mtrs_bastar5")]
    public DateTime? MtrsBastar5 { get; set; }

    [Column("mtrs_bittar5")]
    public DateTime? MtrsBittar5 { get; set; }

    [Column("mtrs_donemadi6")]
    [StringLength(25)]
    public string? MtrsDonemadi6 { get; set; }

    [Column("mtrs_bastar6")]
    public DateTime? MtrsBastar6 { get; set; }

    [Column("mtrs_bittar6")]
    public DateTime? MtrsBittar6 { get; set; }

    [Column("mtrs_donemadi7")]
    [StringLength(25)]
    public string? MtrsDonemadi7 { get; set; }

    [Column("mtrs_bastar7")]
    public DateTime? MtrsBastar7 { get; set; }

    [Column("mtrs_bittar7")]
    public DateTime? MtrsBittar7 { get; set; }

    [Column("mtrs_donemadi8")]
    [StringLength(25)]
    public string? MtrsDonemadi8 { get; set; }

    [Column("mtrs_bastar8")]
    public DateTime? MtrsBastar8 { get; set; }

    [Column("mtrs_bittar8")]
    public DateTime? MtrsBittar8 { get; set; }

    [Column("mtrs_donemadi9")]
    [StringLength(25)]
    public string? MtrsDonemadi9 { get; set; }

    [Column("mtrs_bastar9")]
    public DateTime? MtrsBastar9 { get; set; }

    [Column("mtrs_bittar9")]
    public DateTime? MtrsBittar9 { get; set; }

    [Column("mtrs_donemadi10")]
    [StringLength(25)]
    public string? MtrsDonemadi10 { get; set; }

    [Column("mtrs_bastar10")]
    public DateTime? MtrsBastar10 { get; set; }

    [Column("mtrs_bittar10")]
    public DateTime? MtrsBittar10 { get; set; }

    [Column("mtrs_donemadi11")]
    [StringLength(25)]
    public string? MtrsDonemadi11 { get; set; }

    [Column("mtrs_bastar11")]
    public DateTime? MtrsBastar11 { get; set; }

    [Column("mtrs_bittar11")]
    public DateTime? MtrsBittar11 { get; set; }

    [Column("mtrs_donemadi12")]
    [StringLength(25)]
    public string? MtrsDonemadi12 { get; set; }

    [Column("mtrs_bastar12")]
    public DateTime? MtrsBastar12 { get; set; }

    [Column("mtrs_bittar12")]
    public DateTime? MtrsBittar12 { get; set; }

    [Column("mtrs_donemadi13")]
    [StringLength(25)]
    public string? MtrsDonemadi13 { get; set; }

    [Column("mtrs_bastar13")]
    public DateTime? MtrsBastar13 { get; set; }

    [Column("mtrs_bittar13")]
    public DateTime? MtrsBittar13 { get; set; }

    [Column("mtrs_donemadi14")]
    [StringLength(25)]
    public string? MtrsDonemadi14 { get; set; }

    [Column("mtrs_bastar14")]
    public DateTime? MtrsBastar14 { get; set; }

    [Column("mtrs_bittar14")]
    public DateTime? MtrsBittar14 { get; set; }

    [Column("mtrs_donemadi15")]
    [StringLength(25)]
    public string? MtrsDonemadi15 { get; set; }

    [Column("mtrs_bastar15")]
    public DateTime? MtrsBastar15 { get; set; }

    [Column("mtrs_bittar15")]
    public DateTime? MtrsBittar15 { get; set; }

    [Column("mtrs_donemadi16")]
    [StringLength(25)]
    public string? MtrsDonemadi16 { get; set; }

    [Column("mtrs_bastar16")]
    public DateTime? MtrsBastar16 { get; set; }

    [Column("mtrs_bittar16")]
    public DateTime? MtrsBittar16 { get; set; }

    [Column("mtrs_donemadi17")]
    [StringLength(25)]
    public string? MtrsDonemadi17 { get; set; }

    [Column("mtrs_bastar17")]
    public DateTime? MtrsBastar17 { get; set; }

    [Column("mtrs_bittar17")]
    public DateTime? MtrsBittar17 { get; set; }

    [Column("mtrs_donemadi18")]
    [StringLength(25)]
    public string? MtrsDonemadi18 { get; set; }

    [Column("mtrs_bastar18")]
    public DateTime? MtrsBastar18 { get; set; }

    [Column("mtrs_bittar18")]
    public DateTime? MtrsBittar18 { get; set; }

    [Column("mtrs_donemadi19")]
    [StringLength(25)]
    public string? MtrsDonemadi19 { get; set; }

    [Column("mtrs_bastar19")]
    public DateTime? MtrsBastar19 { get; set; }

    [Column("mtrs_bittar19")]
    public DateTime? MtrsBittar19 { get; set; }

    [Column("mtrs_donemadi20")]
    [StringLength(25)]
    public string? MtrsDonemadi20 { get; set; }

    [Column("mtrs_bastar20")]
    public DateTime? MtrsBastar20 { get; set; }

    [Column("mtrs_bittar20")]
    public DateTime? MtrsBittar20 { get; set; }

    [Column("mtrs_donemadi21")]
    [StringLength(25)]
    public string? MtrsDonemadi21 { get; set; }

    [Column("mtrs_bastar21")]
    public DateTime? MtrsBastar21 { get; set; }

    [Column("mtrs_bittar21")]
    public DateTime? MtrsBittar21 { get; set; }

    [Column("mtrs_donemadi22")]
    [StringLength(25)]
    public string? MtrsDonemadi22 { get; set; }

    [Column("mtrs_bastar22")]
    public DateTime? MtrsBastar22 { get; set; }

    [Column("mtrs_bittar22")]
    public DateTime? MtrsBittar22 { get; set; }

    [Column("mtrs_donemadi23")]
    [StringLength(25)]
    public string? MtrsDonemadi23 { get; set; }

    [Column("mtrs_bastar23")]
    public DateTime? MtrsBastar23 { get; set; }

    [Column("mtrs_bittar23")]
    public DateTime? MtrsBittar23 { get; set; }

    [Column("mtrs_donemadi24")]
    [StringLength(25)]
    public string? MtrsDonemadi24 { get; set; }

    [Column("mtrs_bastar24")]
    public DateTime? MtrsBastar24 { get; set; }

    [Column("mtrs_bittar24")]
    public DateTime? MtrsBittar24 { get; set; }

    [Column("mtrs_donemadi25")]
    [StringLength(25)]
    public string? MtrsDonemadi25 { get; set; }

    [Column("mtrs_bastar25")]
    public DateTime? MtrsBastar25 { get; set; }

    [Column("mtrs_bittar25")]
    public DateTime? MtrsBittar25 { get; set; }

    [Column("mtrs_donemadi26")]
    [StringLength(25)]
    public string? MtrsDonemadi26 { get; set; }

    [Column("mtrs_bastar26")]
    public DateTime? MtrsBastar26 { get; set; }

    [Column("mtrs_bittar26")]
    public DateTime? MtrsBittar26 { get; set; }

    [Column("mtrs_donemadi27")]
    [StringLength(25)]
    public string? MtrsDonemadi27 { get; set; }

    [Column("mtrs_bastar27")]
    public DateTime? MtrsBastar27 { get; set; }

    [Column("mtrs_bittar27")]
    public DateTime? MtrsBittar27 { get; set; }

    [Column("mtrs_donemadi28")]
    [StringLength(25)]
    public string? MtrsDonemadi28 { get; set; }

    [Column("mtrs_bastar28")]
    public DateTime? MtrsBastar28 { get; set; }

    [Column("mtrs_bittar28")]
    public DateTime? MtrsBittar28 { get; set; }

    [Column("mtrs_donemadi29")]
    [StringLength(25)]
    public string? MtrsDonemadi29 { get; set; }

    [Column("mtrs_bastar29")]
    public DateTime? MtrsBastar29 { get; set; }

    [Column("mtrs_bittar29")]
    public DateTime? MtrsBittar29 { get; set; }

    [Column("mtrs_donemadi30")]
    [StringLength(25)]
    public string? MtrsDonemadi30 { get; set; }

    [Column("mtrs_bastar30")]
    public DateTime? MtrsBastar30 { get; set; }

    [Column("mtrs_bittar30")]
    public DateTime? MtrsBittar30 { get; set; }

    [Column("mtrs_donemadi31")]
    [StringLength(25)]
    public string? MtrsDonemadi31 { get; set; }

    [Column("mtrs_bastar31")]
    public DateTime? MtrsBastar31 { get; set; }

    [Column("mtrs_bittar31")]
    public DateTime? MtrsBittar31 { get; set; }

    [Column("mtrs_donemadi32")]
    [StringLength(25)]
    public string? MtrsDonemadi32 { get; set; }

    [Column("mtrs_bastar32")]
    public DateTime? MtrsBastar32 { get; set; }

    [Column("mtrs_bittar32")]
    public DateTime? MtrsBittar32 { get; set; }

    [Column("mtrs_donemadi33")]
    [StringLength(25)]
    public string? MtrsDonemadi33 { get; set; }

    [Column("mtrs_bastar33")]
    public DateTime? MtrsBastar33 { get; set; }

    [Column("mtrs_bittar33")]
    public DateTime? MtrsBittar33 { get; set; }

    [Column("mtrs_donemadi34")]
    [StringLength(25)]
    public string? MtrsDonemadi34 { get; set; }

    [Column("mtrs_bastar34")]
    public DateTime? MtrsBastar34 { get; set; }

    [Column("mtrs_bittar34")]
    public DateTime? MtrsBittar34 { get; set; }

    [Column("mtrs_donemadi35")]
    [StringLength(25)]
    public string? MtrsDonemadi35 { get; set; }

    [Column("mtrs_bastar35")]
    public DateTime? MtrsBastar35 { get; set; }

    [Column("mtrs_bittar35")]
    public DateTime? MtrsBittar35 { get; set; }

    [Column("mtrs_donemadi36")]
    [StringLength(25)]
    public string? MtrsDonemadi36 { get; set; }

    [Column("mtrs_bastar36")]
    public DateTime? MtrsBastar36 { get; set; }

    [Column("mtrs_bittar36")]
    public DateTime? MtrsBittar36 { get; set; }

    [Column("mtrs_donemadi37")]
    [StringLength(25)]
    public string? MtrsDonemadi37 { get; set; }

    [Column("mtrs_bastar37")]
    public DateTime? MtrsBastar37 { get; set; }

    [Column("mtrs_bittar37")]
    public DateTime? MtrsBittar37 { get; set; }

    [Column("mtrs_donemadi38")]
    [StringLength(25)]
    public string? MtrsDonemadi38 { get; set; }

    [Column("mtrs_bastar38")]
    public DateTime? MtrsBastar38 { get; set; }

    [Column("mtrs_bittar38")]
    public DateTime? MtrsBittar38 { get; set; }

    [Column("mtrs_donemadi39")]
    [StringLength(25)]
    public string? MtrsDonemadi39 { get; set; }

    [Column("mtrs_bastar39")]
    public DateTime? MtrsBastar39 { get; set; }

    [Column("mtrs_bittar39")]
    public DateTime? MtrsBittar39 { get; set; }

    [Column("mtrs_donemadi40")]
    [StringLength(25)]
    public string? MtrsDonemadi40 { get; set; }

    [Column("mtrs_bastar40")]
    public DateTime? MtrsBastar40 { get; set; }

    [Column("mtrs_bittar40")]
    public DateTime? MtrsBittar40 { get; set; }

    [Column("mtrs_donemadi41")]
    [StringLength(25)]
    public string? MtrsDonemadi41 { get; set; }

    [Column("mtrs_bastar41")]
    public DateTime? MtrsBastar41 { get; set; }

    [Column("mtrs_bittar41")]
    public DateTime? MtrsBittar41 { get; set; }

    [Column("mtrs_donemadi42")]
    [StringLength(25)]
    public string? MtrsDonemadi42 { get; set; }

    [Column("mtrs_bastar42")]
    public DateTime? MtrsBastar42 { get; set; }

    [Column("mtrs_bittar42")]
    public DateTime? MtrsBittar42 { get; set; }

    [Column("mtrs_donemadi43")]
    [StringLength(25)]
    public string? MtrsDonemadi43 { get; set; }

    [Column("mtrs_bastar43")]
    public DateTime? MtrsBastar43 { get; set; }

    [Column("mtrs_bittar43")]
    public DateTime? MtrsBittar43 { get; set; }

    [Column("mtrs_donemadi44")]
    [StringLength(25)]
    public string? MtrsDonemadi44 { get; set; }

    [Column("mtrs_bastar44")]
    public DateTime? MtrsBastar44 { get; set; }

    [Column("mtrs_bittar44")]
    public DateTime? MtrsBittar44 { get; set; }

    [Column("mtrs_donemadi45")]
    [StringLength(25)]
    public string? MtrsDonemadi45 { get; set; }

    [Column("mtrs_bastar45")]
    public DateTime? MtrsBastar45 { get; set; }

    [Column("mtrs_bittar45")]
    public DateTime? MtrsBittar45 { get; set; }

    [Column("mtrs_donemadi46")]
    [StringLength(25)]
    public string? MtrsDonemadi46 { get; set; }

    [Column("mtrs_bastar46")]
    public DateTime? MtrsBastar46 { get; set; }

    [Column("mtrs_bittar46")]
    public DateTime? MtrsBittar46 { get; set; }

    [Column("mtrs_donemadi47")]
    [StringLength(25)]
    public string? MtrsDonemadi47 { get; set; }

    [Column("mtrs_bastar47")]
    public DateTime? MtrsBastar47 { get; set; }

    [Column("mtrs_bittar47")]
    public DateTime? MtrsBittar47 { get; set; }

    [Column("mtrs_donemadi48")]
    [StringLength(25)]
    public string? MtrsDonemadi48 { get; set; }

    [Column("mtrs_bastar48")]
    public DateTime? MtrsBastar48 { get; set; }

    [Column("mtrs_bittar48")]
    public DateTime? MtrsBittar48 { get; set; }

    [Column("mtrs_donemadi49")]
    [StringLength(25)]
    public string? MtrsDonemadi49 { get; set; }

    [Column("mtrs_bastar49")]
    public DateTime? MtrsBastar49 { get; set; }

    [Column("mtrs_bittar49")]
    public DateTime? MtrsBittar49 { get; set; }

    [Column("mtrs_donemadi50")]
    [StringLength(25)]
    public string? MtrsDonemadi50 { get; set; }

    [Column("mtrs_bastar50")]
    public DateTime? MtrsBastar50 { get; set; }

    [Column("mtrs_bittar50")]
    public DateTime? MtrsBittar50 { get; set; }

    [Column("mtrs_donemadi51")]
    [StringLength(25)]
    public string? MtrsDonemadi51 { get; set; }

    [Column("mtrs_bastar51")]
    public DateTime? MtrsBastar51 { get; set; }

    [Column("mtrs_bittar51")]
    public DateTime? MtrsBittar51 { get; set; }

    [Column("mtrs_donemadi52")]
    [StringLength(25)]
    public string? MtrsDonemadi52 { get; set; }

    [Column("mtrs_bastar52")]
    public DateTime? MtrsBastar52 { get; set; }

    [Column("mtrs_bittar52")]
    public DateTime? MtrsBittar52 { get; set; }

    [Column("mtrs_donemadi53")]
    [StringLength(25)]
    public string? MtrsDonemadi53 { get; set; }

    [Column("mtrs_bastar53")]
    public DateTime? MtrsBastar53 { get; set; }

    [Column("mtrs_bittar53")]
    public DateTime? MtrsBittar53 { get; set; }

    [Column("mtrs_donemadi54")]
    [StringLength(25)]
    public string? MtrsDonemadi54 { get; set; }

    [Column("mtrs_bastar54")]
    public DateTime? MtrsBastar54 { get; set; }

    [Column("mtrs_bittar54")]
    public DateTime? MtrsBittar54 { get; set; }

    [Column("mtrs_donemadi55")]
    [StringLength(25)]
    public string? MtrsDonemadi55 { get; set; }

    [Column("mtrs_bastar55")]
    public DateTime? MtrsBastar55 { get; set; }

    [Column("mtrs_bittar55")]
    public DateTime? MtrsBittar55 { get; set; }

    [Column("mtrs_donemadi56")]
    [StringLength(25)]
    public string? MtrsDonemadi56 { get; set; }

    [Column("mtrs_bastar56")]
    public DateTime? MtrsBastar56 { get; set; }

    [Column("mtrs_bittar56")]
    public DateTime? MtrsBittar56 { get; set; }

    [Column("mtrs_donemadi57")]
    [StringLength(25)]
    public string? MtrsDonemadi57 { get; set; }

    [Column("mtrs_bastar57")]
    public DateTime? MtrsBastar57 { get; set; }

    [Column("mtrs_bittar57")]
    public DateTime? MtrsBittar57 { get; set; }

    [Column("mtrs_donemadi58")]
    [StringLength(25)]
    public string? MtrsDonemadi58 { get; set; }

    [Column("mtrs_bastar58")]
    public DateTime? MtrsBastar58 { get; set; }

    [Column("mtrs_bittar58")]
    public DateTime? MtrsBittar58 { get; set; }

    [Column("mtrs_donemadi59")]
    [StringLength(25)]
    public string? MtrsDonemadi59 { get; set; }

    [Column("mtrs_bastar59")]
    public DateTime? MtrsBastar59 { get; set; }

    [Column("mtrs_bittar59")]
    public DateTime? MtrsBittar59 { get; set; }

    [Column("mtrs_donemadi60")]
    [StringLength(25)]
    public string? MtrsDonemadi60 { get; set; }

    [Column("mtrs_bastar60")]
    public DateTime? MtrsBastar60 { get; set; }

    [Column("mtrs_bittar60")]
    public DateTime? MtrsBittar60 { get; set; }
}
