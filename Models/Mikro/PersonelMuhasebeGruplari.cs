using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_muhasebe_gruplari")]
public class PersonelMuhasebeGruplari
{
    [Column("pmg_Guid")]
    public Guid? PmgGuid { get; set; }

    [Column("pmg_DBCno")]
    public short? PmgDBCno { get; set; }

    [Column("pmg_SpecRECno")]
    public int? PmgSpecRECno { get; set; }

    [Column("pmg_iptal")]
    public bool? PmgIptal { get; set; }

    [Column("pmg_fileid")]
    public short? PmgFileid { get; set; }

    [Column("pmg_hidden")]
    public bool? PmgHidden { get; set; }

    [Column("pmg_kilitli")]
    public bool? PmgKilitli { get; set; }

    [Column("pmg_degisti")]
    public bool? PmgDegisti { get; set; }

    [Column("pmg_checksum")]
    public int? PmgChecksum { get; set; }

    [Column("pmg_create_user")]
    public short? PmgCreateUser { get; set; }

    [Column("pmg_create_date")]
    public DateTime? PmgCreateDate { get; set; }

    [Column("pmg_lastup_user")]
    public short? PmgLastupUser { get; set; }

    [Column("pmg_lastup_date")]
    public DateTime? PmgLastupDate { get; set; }

    [Column("pmg_special1")]
    [StringLength(4)]
    public string? PmgSpecial1 { get; set; }

    [Column("pmg_special2")]
    [StringLength(4)]
    public string? PmgSpecial2 { get; set; }

    [Column("pmg_special3")]
    [StringLength(4)]
    public string? PmgSpecial3 { get; set; }

    [Column("pmg_kodu")]
    [StringLength(25)]
    public string? PmgKodu { get; set; }

    [Column("pmg_adi")]
    [StringLength(40)]
    public string? PmgAdi { get; set; }

    [Column("pmg_alcnetkod")]
    [StringLength(25)]
    public string? PmgAlcnetkod { get; set; }

    [Column("pmg_alcgvkodu")]
    [StringLength(25)]
    public string? PmgAlcgvkodu { get; set; }

    [Column("pmg_alcdvkodu")]
    [StringLength(25)]
    public string? PmgAlcdvkodu { get; set; }

    [Column("pmg_alcsskpaykod")]
    [StringLength(25)]
    public string? PmgAlcsskpaykod { get; set; }

    [Column("pmg_alcztasperkod")]
    [StringLength(25)]
    public string? PmgAlcztasperkod { get; set; }

    [Column("pmg_alcsskemkod")]
    [StringLength(25)]
    public string? PmgAlcsskemkod { get; set; }

    [Column("pmg_alcsskisvhkod")]
    [StringLength(25)]
    public string? PmgAlcsskisvhkod { get; set; }

    [Column("pmg_alcztasisvkod")]
    [StringLength(25)]
    public string? PmgAlcztasisvkod { get; set; }

    [Column("pmg_alcemkisvhkod")]
    [StringLength(25)]
    public string? PmgAlcemkisvhkod { get; set; }

    [Column("pmg_alcyuvfarkkod")]
    [StringLength(25)]
    public string? PmgAlcyuvfarkkod { get; set; }

    [Column("pmg_alcissigisvpkod")]
    [StringLength(25)]
    public string? PmgAlcissigisvpkod { get; set; }

    [Column("pmg_alcissigperpkod")]
    [StringLength(25)]
    public string? PmgAlcissigperpkod { get; set; }

    [Column("pmg_alnetetkilemeyenagikod")]
    [StringLength(25)]
    public string? PmgAlnetetkilemeyenagikod { get; set; }

    [Column("pmg_alfaydalanilanagikod")]
    [StringLength(25)]
    public string? PmgAlfaydalanilanagikod { get; set; }

    [Column("pmg_alfaydalanilan5746kod")]
    [StringLength(25)]
    public string? PmgAlfaydalanilan5746kod { get; set; }

    [Column("pmg_alfaydalanilan5225kod")]
    [StringLength(25)]
    public string? PmgAlfaydalanilan5225kod { get; set; }

    [Column("pmg_alisvhisgelirikod")]
    [StringLength(25)]
    public string? PmgAlisvhisgelirikod { get; set; }

    [Column("pmg_alisotobeskod")]
    [StringLength(25)]
    public string? PmgAlisotobeskod { get; set; }

    [Column("pmg_brcnorkaz1kod")]
    [StringLength(25)]
    public string? PmgBrcnorkaz1kod { get; set; }

    [Column("pmg_brcnorkaz2kod")]
    [StringLength(25)]
    public string? PmgBrcnorkaz2kod { get; set; }

    [Column("pmg_brcnorkaz3kod")]
    [StringLength(25)]
    public string? PmgBrcnorkaz3kod { get; set; }

    [Column("pmg_brcnorkaz4kod")]
    [StringLength(25)]
    public string? PmgBrcnorkaz4kod { get; set; }

    [Column("pmg_brcnorkaz5kod")]
    [StringLength(25)]
    public string? PmgBrcnorkaz5kod { get; set; }

    [Column("pmg_brcnorkaz6kod")]
    [StringLength(25)]
    public string? PmgBrcnorkaz6kod { get; set; }

    [Column("pmg_brcekkaz1kod")]
    [StringLength(25)]
    public string? PmgBrcekkaz1kod { get; set; }

    [Column("pmg_brcekkaz2kod")]
    [StringLength(25)]
    public string? PmgBrcekkaz2kod { get; set; }

    [Column("pmg_brcekkaz3kod")]
    [StringLength(25)]
    public string? PmgBrcekkaz3kod { get; set; }

    [Column("pmg_brcekkaz4kod")]
    [StringLength(25)]
    public string? PmgBrcekkaz4kod { get; set; }

    [Column("pmg_brcekkaz5kod")]
    [StringLength(25)]
    public string? PmgBrcekkaz5kod { get; set; }

    [Column("pmg_brcekkaz6kod")]
    [StringLength(25)]
    public string? PmgBrcekkaz6kod { get; set; }

    [Column("pmg_brcekkaz7kod")]
    [StringLength(25)]
    public string? PmgBrcekkaz7kod { get; set; }

    [Column("pmg_brcekkaz8kod")]
    [StringLength(25)]
    public string? PmgBrcekkaz8kod { get; set; }

    [Column("pmg_brcekkaz9kod")]
    [StringLength(25)]
    public string? PmgBrcekkaz9kod { get; set; }

    [Column("pmg_brcekkaz10kod")]
    [StringLength(25)]
    public string? PmgBrcekkaz10kod { get; set; }

    [Column("pmg_brcekkaz11kod")]
    [StringLength(25)]
    public string? PmgBrcekkaz11kod { get; set; }

    [Column("pmg_brcsosyrd1kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd1kod { get; set; }

    [Column("pmg_brcsosyrd2kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd2kod { get; set; }

    [Column("pmg_brcsosyrd3kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd3kod { get; set; }

    [Column("pmg_brcsosyrd4kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd4kod { get; set; }

    [Column("pmg_brcsosyrd5kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd5kod { get; set; }

    [Column("pmg_brcsosyrd6kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd6kod { get; set; }

    [Column("pmg_brcsosyrd7kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd7kod { get; set; }

    [Column("pmg_brcsosyrd8kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd8kod { get; set; }

    [Column("pmg_brcsosyrd9kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd9kod { get; set; }

    [Column("pmg_brcsosyrd10kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd10kod { get; set; }

    [Column("pmg_brcsosyrd11kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd11kod { get; set; }

    [Column("pmg_brcsosyrd12kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd12kod { get; set; }

    [Column("pmg_brcsosyrd13kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd13kod { get; set; }

    [Column("pmg_brcsosyrd14kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd14kod { get; set; }

    [Column("pmg_brcsosyrd15kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd15kod { get; set; }

    [Column("pmg_brcsosyrd16kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd16kod { get; set; }

    [Column("pmg_brcsosyrd17kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd17kod { get; set; }

    [Column("pmg_brcsosyrd18kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd18kod { get; set; }

    [Column("pmg_brcsosyrd19kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd19kod { get; set; }

    [Column("pmg_brcsosyrd20kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd20kod { get; set; }

    [Column("pmg_brcsosyrd21kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd21kod { get; set; }

    [Column("pmg_brcsosyrd22kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd22kod { get; set; }

    [Column("pmg_brcsosyrd23kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd23kod { get; set; }

    [Column("pmg_brcsosyrd24kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd24kod { get; set; }

    [Column("pmg_brcsosyrd25kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd25kod { get; set; }

    [Column("pmg_brcsosyrd26kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd26kod { get; set; }

    [Column("pmg_brcsosyrd27kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd27kod { get; set; }

    [Column("brcsosyrd28kod")]
    [StringLength(25)]
    public string? Brcsosyrd28kod { get; set; }

    [Column("pmg_brcsosyrd29kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd29kod { get; set; }

    [Column("pmg_brcsosyrd30kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd30kod { get; set; }

    [Column("pmg_brcsosyrd31kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd31kod { get; set; }

    [Column("pmg_brcsosyrd32kod")]
    [StringLength(25)]
    public string? PmgBrcsosyrd32kod { get; set; }

    [Column("pmg_brcsskisvgdkod")]
    [StringLength(25)]
    public string? PmgBrcsskisvgdkod { get; set; }

    [Column("pmg_brcztasisvgdkod")]
    [StringLength(25)]
    public string? PmgBrcztasisvgdkod { get; set; }

    [Column("pmg_brcemkisvgdkod")]
    [StringLength(25)]
    public string? PmgBrcemkisvgdkod { get; set; }

    [Column("pmg_brcvakkesgdkod")]
    [StringLength(25)]
    public string? PmgBrcvakkesgdkod { get; set; }

    [Column("pmg_brcyuvfarkkod")]
    [StringLength(25)]
    public string? PmgBrcyuvfarkkod { get; set; }

    [Column("pmg_brcissigisvgkod")]
    [StringLength(25)]
    public string? PmgBrcissigisvgkod { get; set; }

    [Column("pmg_brcneteeklenen5746kod")]
    [StringLength(25)]
    public string? PmgBrcneteeklenen5746kod { get; set; }

    [Column("pmg_brcneteeklenen5225kod")]
    [StringLength(25)]
    public string? PmgBrcneteeklenen5225kod { get; set; }

    [Column("pmg_alcnetcns")]
    public byte? PmgAlcnetcns { get; set; }

    [Column("pmg_alcgvcns")]
    public byte? PmgAlcgvcns { get; set; }

    [Column("pmg_alcdvcns")]
    public byte? PmgAlcdvcns { get; set; }

    [Column("pmg_alcztaspercns")]
    public byte? PmgAlcztaspercns { get; set; }

    [Column("pmg_alcztascns")]
    public byte? PmgAlcztascns { get; set; }

    [Column("pmg_alcsskemcns")]
    public byte? PmgAlcsskemcns { get; set; }

    [Column("pmg_alcsskisvhcns")]
    public byte? PmgAlcsskisvhcns { get; set; }

    [Column("pmg_alcztasisvcns")]
    public byte? PmgAlcztasisvcns { get; set; }

    [Column("pmg_alcemkisvhcns")]
    public byte? PmgAlcemkisvhcns { get; set; }

    [Column("pmg_alcyuvfarkcns")]
    public byte? PmgAlcyuvfarkcns { get; set; }

    [Column("pmg_alcissigisvpcns")]
    public byte? PmgAlcissigisvpcns { get; set; }

    [Column("pmg_alcissigperpcns")]
    public byte? PmgAlcissigperpcns { get; set; }

    [Column("pmg_alnetetkilemeyenagicns")]
    public byte? PmgAlnetetkilemeyenagicns { get; set; }

    [Column("pmg_alfaydalanilanagicns")]
    public byte? PmgAlfaydalanilanagicns { get; set; }

    [Column("pmg_alfaydalanilan5746cns")]
    public byte? PmgAlfaydalanilan5746cns { get; set; }

    [Column("pmg_alfaydalanilan5225cns")]
    public byte? PmgAlfaydalanilan5225cns { get; set; }

    [Column("pmg_alisvhisgeliricns")]
    public byte? PmgAlisvhisgeliricns { get; set; }

    [Column("pmg_alisotobescns")]
    public byte? PmgAlisotobescns { get; set; }

    [Column("pmg_brcnorkaz1cns")]
    public byte? PmgBrcnorkaz1cns { get; set; }

    [Column("pmg_brcnorkaz2cns")]
    public byte? PmgBrcnorkaz2cns { get; set; }

    [Column("pmg_brcnorkaz3cns")]
    public byte? PmgBrcnorkaz3cns { get; set; }

    [Column("pmg_brcnorkaz4cns")]
    public byte? PmgBrcnorkaz4cns { get; set; }

    [Column("pmg_brcnorkaz5cns")]
    public byte? PmgBrcnorkaz5cns { get; set; }

    [Column("pmg_brcnorkaz6cns")]
    public byte? PmgBrcnorkaz6cns { get; set; }

    [Column("pmg_brcekkaz1cns")]
    public byte? PmgBrcekkaz1cns { get; set; }

    [Column("pmg_brcekkaz2cns")]
    public byte? PmgBrcekkaz2cns { get; set; }

    [Column("pmg_brcekkaz3cns")]
    public byte? PmgBrcekkaz3cns { get; set; }

    [Column("pmg_brcekkaz4cns")]
    public byte? PmgBrcekkaz4cns { get; set; }

    [Column("pmg_brcekkaz5cns")]
    public byte? PmgBrcekkaz5cns { get; set; }

    [Column("pmg_brcekkaz6cns")]
    public byte? PmgBrcekkaz6cns { get; set; }

    [Column("pmg_brcekkaz7cns")]
    public byte? PmgBrcekkaz7cns { get; set; }

    [Column("pmg_brcekkaz8cns")]
    public byte? PmgBrcekkaz8cns { get; set; }

    [Column("pmg_brcekkaz9cns")]
    public byte? PmgBrcekkaz9cns { get; set; }

    [Column("pmg_brcekkaz10cns")]
    public byte? PmgBrcekkaz10cns { get; set; }

    [Column("pmg_brcekkaz11cns")]
    public byte? PmgBrcekkaz11cns { get; set; }

    [Column("pmg_brcsosyrd1cns")]
    public byte? PmgBrcsosyrd1cns { get; set; }

    [Column("pmg_brcsosyrd2cns")]
    public byte? PmgBrcsosyrd2cns { get; set; }

    [Column("pmg_brcsosyrd3cns")]
    public byte? PmgBrcsosyrd3cns { get; set; }

    [Column("pmg_brcsosyrd4cns")]
    public byte? PmgBrcsosyrd4cns { get; set; }

    [Column("pmg_brcsosyrd5cns")]
    public byte? PmgBrcsosyrd5cns { get; set; }

    [Column("pmg_brcsosyrd6cns")]
    public byte? PmgBrcsosyrd6cns { get; set; }

    [Column("pmg_brcsosyrd7cns")]
    public byte? PmgBrcsosyrd7cns { get; set; }

    [Column("pmg_brcsosyrd8cns")]
    public byte? PmgBrcsosyrd8cns { get; set; }

    [Column("pmg_brcsosyrd9cns")]
    public byte? PmgBrcsosyrd9cns { get; set; }

    [Column("pmg_brcsosyrd10cns")]
    public byte? PmgBrcsosyrd10cns { get; set; }

    [Column("pmg_brcsosyrd11cns")]
    public byte? PmgBrcsosyrd11cns { get; set; }

    [Column("pmg_brcsosyrd12cns")]
    public byte? PmgBrcsosyrd12cns { get; set; }

    [Column("pmg_brcsosyrd14cns")]
    public byte? PmgBrcsosyrd14cns { get; set; }

    [Column("pmg_brcsosyrd15cns")]
    public byte? PmgBrcsosyrd15cns { get; set; }

    [Column("pmg_brcsosyrd16cns")]
    public byte? PmgBrcsosyrd16cns { get; set; }

    [Column("pmg_brcsosyrd17cns")]
    public byte? PmgBrcsosyrd17cns { get; set; }

    [Column("pmg_brcsosyrd18cns")]
    public byte? PmgBrcsosyrd18cns { get; set; }

    [Column("pmg_brcsosyrd19cns")]
    public byte? PmgBrcsosyrd19cns { get; set; }

    [Column("pmg_brcsosyrd20cns")]
    public byte? PmgBrcsosyrd20cns { get; set; }

    [Column("pmg_brcsosyrd21cns")]
    public byte? PmgBrcsosyrd21cns { get; set; }

    [Column("pmg_brcsosyrd22cns")]
    public byte? PmgBrcsosyrd22cns { get; set; }

    [Column("pmg_brcsosyrd23cns")]
    public byte? PmgBrcsosyrd23cns { get; set; }

    [Column("pmg_brcsosyrd24cns")]
    public byte? PmgBrcsosyrd24cns { get; set; }

    [Column("pmg_brcsosyrd25cns")]
    public byte? PmgBrcsosyrd25cns { get; set; }

    [Column("pmg_brcsosyrd26cns")]
    public byte? PmgBrcsosyrd26cns { get; set; }

    [Column("pmg_brcsosyrd27cns")]
    public byte? PmgBrcsosyrd27cns { get; set; }

    [Column("pmg_brcsosyrd28cns")]
    public byte? PmgBrcsosyrd28cns { get; set; }

    [Column("pmg_brcsosyrd29cns")]
    public byte? PmgBrcsosyrd29cns { get; set; }

    [Column("pmg_brcsosyrd30cns")]
    public byte? PmgBrcsosyrd30cns { get; set; }

    [Column("pmg_brcsosyrd31cns")]
    public byte? PmgBrcsosyrd31cns { get; set; }

    [Column("pmg_brcsosyrd32cns")]
    public byte? PmgBrcsosyrd32cns { get; set; }

    [Column("pmg_brcsskisvgdcns")]
    public byte? PmgBrcsskisvgdcns { get; set; }

    [Column("pmg_brcztasisvgdcns")]
    public byte? PmgBrcztasisvgdcns { get; set; }

    [Column("pmg_brcemkisvgdcns")]
    public byte? PmgBrcemkisvgdcns { get; set; }

    [Column("pmg_brcvakkesgdcns")]
    public byte? PmgBrcvakkesgdcns { get; set; }

    [Column("pmg_brcyuvfarkcns")]
    public byte? PmgBrcyuvfarkcns { get; set; }

    [Column("pmg_brcissigisvgcns")]
    public byte? PmgBrcissigisvgcns { get; set; }

    [Column("pmg_brcneteeklenen5746cns")]
    public byte? PmgBrcneteeklenen5746cns { get; set; }

    [Column("pmg_brcneteeklenen5225cns")]
    public byte? PmgBrcneteeklenen5225cns { get; set; }

    [Column("pmg_alcnetcns_grupno")]
    public byte? PmgAlcnetcnsGrupno { get; set; }

    [Column("pmg_alcgvcns_grupno")]
    public byte? PmgAlcgvcnsGrupno { get; set; }

    [Column("pmg_alcdvcns_grupno")]
    public byte? PmgAlcdvcnsGrupno { get; set; }

    [Column("pmg_alcztaspercns_grupno")]
    public byte? PmgAlcztaspercnsGrupno { get; set; }

    [Column("pmg_alcztascns_grupno")]
    public byte? PmgAlcztascnsGrupno { get; set; }

    [Column("pmg_alcsskemcns_grupno")]
    public byte? PmgAlcsskemcnsGrupno { get; set; }

    [Column("pmg_alcsskisvhcns_grupno")]
    public byte? PmgAlcsskisvhcnsGrupno { get; set; }

    [Column("pmg_alcztasisvcns_grupno")]
    public byte? PmgAlcztasisvcnsGrupno { get; set; }

    [Column("pmg_alcemkisvhcns_grupno")]
    public byte? PmgAlcemkisvhcnsGrupno { get; set; }

    [Column("pmg_alcyuvfarkcns_grupno")]
    public byte? PmgAlcyuvfarkcnsGrupno { get; set; }

    [Column("pmg_alcissigisvpcns_grupno")]
    public byte? PmgAlcissigisvpcnsGrupno { get; set; }

    [Column("pmg_alcissigperpcns_grupno")]
    public byte? PmgAlcissigperpcnsGrupno { get; set; }

    [Column("pmg_alnetetkilemeyenagi_grupno")]
    public byte? PmgAlnetetkilemeyenagiGrupno { get; set; }

    [Column("pmg_alfaydalanilanagi_grupno")]
    public byte? PmgAlfaydalanilanagiGrupno { get; set; }

    [Column("pmg_alfaydalanilan5746_grupno")]
    public byte? PmgAlfaydalanilan5746Grupno { get; set; }

    [Column("pmg_alfaydalanilan5225_grupno")]
    public byte? PmgAlfaydalanilan5225Grupno { get; set; }

    [Column("pmg_alisvhisgeliri_grupno")]
    public byte? PmgAlisvhisgeliriGrupno { get; set; }

    [Column("pmg_otobes_grupno")]
    public byte? PmgOtobesGrupno { get; set; }

    [Column("pmg_brcnorkaz1cns_grupno")]
    public byte? PmgBrcnorkaz1cnsGrupno { get; set; }

    [Column("pmg_brcnorkaz2cns_grupno")]
    public byte? PmgBrcnorkaz2cnsGrupno { get; set; }

    [Column("pmg_brcnorkaz3cns_grupno")]
    public byte? PmgBrcnorkaz3cnsGrupno { get; set; }

    [Column("pmg_brcnorkaz4cns_grupno")]
    public byte? PmgBrcnorkaz4cnsGrupno { get; set; }

    [Column("pmg_brcnorkaz5cns_grupno")]
    public byte? PmgBrcnorkaz5cnsGrupno { get; set; }

    [Column("pmg_brcnorkaz6cns_grupno")]
    public byte? PmgBrcnorkaz6cnsGrupno { get; set; }

    [Column("pmg_brcekkaz1cns_grupno")]
    public byte? PmgBrcekkaz1cnsGrupno { get; set; }

    [Column("pmg_brcekkaz2cns_grupno")]
    public byte? PmgBrcekkaz2cnsGrupno { get; set; }

    [Column("pmg_brcekkaz3cns_grupno")]
    public byte? PmgBrcekkaz3cnsGrupno { get; set; }

    [Column("pmg_brcekkaz4cns_grupno")]
    public byte? PmgBrcekkaz4cnsGrupno { get; set; }

    [Column("pmg_brcekkaz5cns_grupno")]
    public byte? PmgBrcekkaz5cnsGrupno { get; set; }

    [Column("pmg_brcekkaz6cns_grupno")]
    public byte? PmgBrcekkaz6cnsGrupno { get; set; }

    [Column("pmg_brcekkaz7cns_grupno")]
    public byte? PmgBrcekkaz7cnsGrupno { get; set; }

    [Column("pmg_brcekkaz8cns_grupno")]
    public byte? PmgBrcekkaz8cnsGrupno { get; set; }

    [Column("pmg_brcekkaz9cns_grupno")]
    public byte? PmgBrcekkaz9cnsGrupno { get; set; }

    [Column("pmg_brcekkaz10cns_grupno")]
    public byte? PmgBrcekkaz10cnsGrupno { get; set; }

    [Column("pmg_brcekkaz11cns_grupno")]
    public byte? PmgBrcekkaz11cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd1cns_grupno")]
    public byte? PmgBrcsosyrd1cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd2cns_grupno")]
    public byte? PmgBrcsosyrd2cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd3cns_grupno")]
    public byte? PmgBrcsosyrd3cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd4cns_grupno")]
    public byte? PmgBrcsosyrd4cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd5cns_grupno")]
    public byte? PmgBrcsosyrd5cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd6cns_grupno")]
    public byte? PmgBrcsosyrd6cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd7cns_grupno")]
    public byte? PmgBrcsosyrd7cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd8cns_grupno")]
    public byte? PmgBrcsosyrd8cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd9cns_grupno")]
    public byte? PmgBrcsosyrd9cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd10cns_grupno")]
    public byte? PmgBrcsosyrd10cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd11cns_grupno")]
    public byte? PmgBrcsosyrd11cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd12cns_grupno")]
    public byte? PmgBrcsosyrd12cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd13cns_grupno")]
    public byte? PmgBrcsosyrd13cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd14cns_grupno")]
    public byte? PmgBrcsosyrd14cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd15cns_grupno")]
    public byte? PmgBrcsosyrd15cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd16cns_grupno")]
    public byte? PmgBrcsosyrd16cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd17cns_grupno")]
    public byte? PmgBrcsosyrd17cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd18cns_grupno")]
    public byte? PmgBrcsosyrd18cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd19cns_grupno")]
    public byte? PmgBrcsosyrd19cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd20cns_grupno")]
    public byte? PmgBrcsosyrd20cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd21cns_grupno")]
    public byte? PmgBrcsosyrd21cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd22cns_grupno")]
    public byte? PmgBrcsosyrd22cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd23cns_grupno")]
    public byte? PmgBrcsosyrd23cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd24cns_grupno")]
    public byte? PmgBrcsosyrd24cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd25cns_grupno")]
    public byte? PmgBrcsosyrd25cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd26cns_grupno")]
    public byte? PmgBrcsosyrd26cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd27cns_grupno")]
    public byte? PmgBrcsosyrd27cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd28cns_grupno")]
    public byte? PmgBrcsosyrd28cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd29cns_grupno")]
    public byte? PmgBrcsosyrd29cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd30cns_grupno")]
    public byte? PmgBrcsosyrd30cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd31cns_grupno")]
    public byte? PmgBrcsosyrd31cnsGrupno { get; set; }

    [Column("pmg_brcsosyrd32cns_grupno")]
    public byte? PmgBrcsosyrd32cnsGrupno { get; set; }

    [Column("pmg_brcsskisvgdcns_grupno")]
    public byte? PmgBrcsskisvgdcnsGrupno { get; set; }

    [Column("pmg_brcztasisvgdcns_grupno")]
    public byte? PmgBrcztasisvgdcnsGrupno { get; set; }

    [Column("pmg_brcemkisvgdcns_grupno")]
    public byte? PmgBrcemkisvgdcnsGrupno { get; set; }

    [Column("pmg_brcvakkesgdcns_grupno")]
    public byte? PmgBrcvakkesgdcnsGrupno { get; set; }

    [Column("pmg_brcyuvfarkcns_grupno")]
    public byte? PmgBrcyuvfarkcnsGrupno { get; set; }

    [Column("pmg_brcissigisvgcns_grupno")]
    public byte? PmgBrcissigisvgcnsGrupno { get; set; }

    [Column("pmg_brcneteeklenen5746_grupno")]
    public byte? PmgBrcneteeklenen5746Grupno { get; set; }

    [Column("pmg_brcneteeklenen5225_grupno")]
    public byte? PmgBrcneteeklenen5225Grupno { get; set; }

    [Column("pmg_ticari")]
    public bool? PmgTicari { get; set; }

    [Column("pmg_ozelalacakcaricins1")]
    public byte? PmgOzelalacakcaricins1 { get; set; }

    [Column("pmg_ozelalacakcaricins2")]
    public byte? PmgOzelalacakcaricins2 { get; set; }

    [Column("pmg_ozelalacakcaricins3")]
    public byte? PmgOzelalacakcaricins3 { get; set; }

    [Column("pmg_ozelalacakcaricins4")]
    public byte? PmgOzelalacakcaricins4 { get; set; }

    [Column("pmg_ozelalacakcaricins5")]
    public byte? PmgOzelalacakcaricins5 { get; set; }

    [Column("pmg_ozelalacakcaricins6")]
    public byte? PmgOzelalacakcaricins6 { get; set; }

    [Column("pmg_ozelalacakcaricins7")]
    public byte? PmgOzelalacakcaricins7 { get; set; }

    [Column("pmg_ozelalacakcaricins8")]
    public byte? PmgOzelalacakcaricins8 { get; set; }

    [Column("pmg_ozelalacakcaricins9")]
    public byte? PmgOzelalacakcaricins9 { get; set; }

    [Column("pmg_ozelalacakcaricins10")]
    public byte? PmgOzelalacakcaricins10 { get; set; }

    [Column("pmg_ozelalacakcaricins11")]
    public byte? PmgOzelalacakcaricins11 { get; set; }

    [Column("pmg_ozelalacakcaricins12")]
    public byte? PmgOzelalacakcaricins12 { get; set; }

    [Column("pmg_ozelalacakcaricins13")]
    public byte? PmgOzelalacakcaricins13 { get; set; }

    [Column("pmg_ozelalacakcaricins14")]
    public byte? PmgOzelalacakcaricins14 { get; set; }

    [Column("pmg_ozelalacakcaricins15")]
    public byte? PmgOzelalacakcaricins15 { get; set; }

    [Column("pmg_ozelalacakcaricins16")]
    public byte? PmgOzelalacakcaricins16 { get; set; }

    [Column("pmg_ozelalacakcaricins17")]
    public byte? PmgOzelalacakcaricins17 { get; set; }

    [Column("pmg_ozelalacakcaricins18")]
    public byte? PmgOzelalacakcaricins18 { get; set; }

    [Column("pmg_ozelalacakcaricins19")]
    public byte? PmgOzelalacakcaricins19 { get; set; }

    [Column("pmg_ozelalacakcaricins20")]
    public byte? PmgOzelalacakcaricins20 { get; set; }

    [Column("pmg_ozelalacakcaricins21")]
    public byte? PmgOzelalacakcaricins21 { get; set; }

    [Column("pmg_ozelalacakcaricins22")]
    public byte? PmgOzelalacakcaricins22 { get; set; }

    [Column("pmg_ozelalacakcaricins23")]
    public byte? PmgOzelalacakcaricins23 { get; set; }

    [Column("pmg_ozelalacakcaricins24")]
    public byte? PmgOzelalacakcaricins24 { get; set; }

    [Column("pmg_ozelalacakkod1")]
    [StringLength(40)]
    public string? PmgOzelalacakkod1 { get; set; }

    [Column("pmg_ozelalacakkod2")]
    [StringLength(40)]
    public string? PmgOzelalacakkod2 { get; set; }

    [Column("pmg_ozelalacakkod3")]
    [StringLength(40)]
    public string? PmgOzelalacakkod3 { get; set; }

    [Column("pmg_ozelalacakkod4")]
    [StringLength(40)]
    public string? PmgOzelalacakkod4 { get; set; }

    [Column("pmg_ozelalacakkod5")]
    [StringLength(40)]
    public string? PmgOzelalacakkod5 { get; set; }

    [Column("pmg_ozelalacakkod6")]
    [StringLength(40)]
    public string? PmgOzelalacakkod6 { get; set; }

    [Column("pmg_ozelalacakkod7")]
    [StringLength(40)]
    public string? PmgOzelalacakkod7 { get; set; }

    [Column("pmg_ozelalacakkod8")]
    [StringLength(40)]
    public string? PmgOzelalacakkod8 { get; set; }

    [Column("pmg_ozelalacakkod9")]
    [StringLength(40)]
    public string? PmgOzelalacakkod9 { get; set; }

    [Column("pmg_ozelalacakkod10")]
    [StringLength(40)]
    public string? PmgOzelalacakkod10 { get; set; }

    [Column("pmg_ozelalacakkod11")]
    [StringLength(40)]
    public string? PmgOzelalacakkod11 { get; set; }

    [Column("pmg_ozelalacakkod12")]
    [StringLength(40)]
    public string? PmgOzelalacakkod12 { get; set; }

    [Column("pmg_ozelalacakkod13")]
    [StringLength(40)]
    public string? PmgOzelalacakkod13 { get; set; }

    [Column("pmg_ozelalacakkod14")]
    [StringLength(40)]
    public string? PmgOzelalacakkod14 { get; set; }

    [Column("pmg_ozelalacakkod15")]
    [StringLength(40)]
    public string? PmgOzelalacakkod15 { get; set; }

    [Column("pmg_ozelalacakkod16")]
    [StringLength(40)]
    public string? PmgOzelalacakkod16 { get; set; }

    [Column("pmg_ozelalacakkod17")]
    [StringLength(40)]
    public string? PmgOzelalacakkod17 { get; set; }

    [Column("pmg_ozelalacakkod18")]
    [StringLength(40)]
    public string? PmgOzelalacakkod18 { get; set; }

    [Column("pmg_ozelalacakkod19")]
    [StringLength(40)]
    public string? PmgOzelalacakkod19 { get; set; }

    [Column("pmg_ozelalacakkod20")]
    [StringLength(40)]
    public string? PmgOzelalacakkod20 { get; set; }

    [Column("pmg_ozelalacakkod21")]
    [StringLength(40)]
    public string? PmgOzelalacakkod21 { get; set; }

    [Column("pmg_ozelalacakkod22")]
    [StringLength(40)]
    public string? PmgOzelalacakkod22 { get; set; }

    [Column("pmg_ozelalacakkod23")]
    [StringLength(40)]
    public string? PmgOzelalacakkod23 { get; set; }

    [Column("pmg_ozelalacakkod24")]
    [StringLength(40)]
    public string? PmgOzelalacakkod24 { get; set; }

    [Column("pmg_ozelalacakcarigrup1")]
    public byte? PmgOzelalacakcarigrup1 { get; set; }

    [Column("pmg_ozelalacakcarigrup2")]
    public byte? PmgOzelalacakcarigrup2 { get; set; }

    [Column("pmg_ozelalacakcarigrup3")]
    public byte? PmgOzelalacakcarigrup3 { get; set; }

    [Column("pmg_ozelalacakcarigrup4")]
    public byte? PmgOzelalacakcarigrup4 { get; set; }

    [Column("pmg_ozelalacakcarigrup5")]
    public byte? PmgOzelalacakcarigrup5 { get; set; }

    [Column("pmg_ozelalacakcarigrup6")]
    public byte? PmgOzelalacakcarigrup6 { get; set; }

    [Column("pmg_ozelalacakcarigrup7")]
    public byte? PmgOzelalacakcarigrup7 { get; set; }

    [Column("pmg_ozelalacakcarigrup8")]
    public byte? PmgOzelalacakcarigrup8 { get; set; }

    [Column("pmg_ozelalacakcarigrup9")]
    public byte? PmgOzelalacakcarigrup9 { get; set; }

    [Column("pmg_ozelalacakcarigrup10")]
    public byte? PmgOzelalacakcarigrup10 { get; set; }

    [Column("pmg_ozelalacakcarigrup11")]
    public byte? PmgOzelalacakcarigrup11 { get; set; }

    [Column("pmg_ozelalacakcarigrup12")]
    public byte? PmgOzelalacakcarigrup12 { get; set; }

    [Column("pmg_ozelalacakcarigrup13")]
    public byte? PmgOzelalacakcarigrup13 { get; set; }

    [Column("pmg_ozelalacakcarigrup14")]
    public byte? PmgOzelalacakcarigrup14 { get; set; }

    [Column("pmg_ozelalacakcarigrup15")]
    public byte? PmgOzelalacakcarigrup15 { get; set; }

    [Column("pmg_ozelalacakcarigrup16")]
    public byte? PmgOzelalacakcarigrup16 { get; set; }

    [Column("pmg_ozelalacakcarigrup17")]
    public byte? PmgOzelalacakcarigrup17 { get; set; }

    [Column("pmg_ozelalacakcarigrup18")]
    public byte? PmgOzelalacakcarigrup18 { get; set; }

    [Column("pmg_ozelalacakcarigrup19")]
    public byte? PmgOzelalacakcarigrup19 { get; set; }

    [Column("pmg_ozelalacakcarigrup20")]
    public byte? PmgOzelalacakcarigrup20 { get; set; }

    [Column("pmg_ozelalacakcarigrup21")]
    public byte? PmgOzelalacakcarigrup21 { get; set; }

    [Column("pmg_ozelalacakcarigrup22")]
    public byte? PmgOzelalacakcarigrup22 { get; set; }

    [Column("pmg_ozelalacakcarigrup23")]
    public byte? PmgOzelalacakcarigrup23 { get; set; }

    [Column("pmg_ozelalacakcarigrup24")]
    public byte? PmgOzelalacakcarigrup24 { get; set; }
}
