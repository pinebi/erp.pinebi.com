using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("pcarihar")]
public class Pcarihar
{
    [Column("po_Guid")]
    public Guid? PoGuid { get; set; }

    [Column("po_DBCno")]
    public short? PoDBCno { get; set; }

    [Column("po_SpecRECno")]
    public int? PoSpecRECno { get; set; }

    [Column("po_iptal")]
    public bool? PoIptal { get; set; }

    [Column("po_fileid")]
    public short? PoFileid { get; set; }

    [Column("po_hidden")]
    public bool? PoHidden { get; set; }

    [Column("po_kilitli")]
    public bool? PoKilitli { get; set; }

    [Column("po_degisti")]
    public bool? PoDegisti { get; set; }

    [Column("po_checksum")]
    public int? PoChecksum { get; set; }

    [Column("po_create_user")]
    public short? PoCreateUser { get; set; }

    [Column("po_create_date")]
    public DateTime? PoCreateDate { get; set; }

    [Column("po_lastup_user")]
    public short? PoLastupUser { get; set; }

    [Column("po_lastup_date")]
    public DateTime? PoLastupDate { get; set; }

    [Column("po_special1")]
    [StringLength(4)]
    public string? PoSpecial1 { get; set; }

    [Column("po_special2")]
    [StringLength(4)]
    public string? PoSpecial2 { get; set; }

    [Column("po_special3")]
    [StringLength(4)]
    public string? PoSpecial3 { get; set; }

    [Column("po_firmano")]
    public int? PoFirmano { get; set; }

    [Column("po_subeno")]
    public int? PoSubeno { get; set; }

    [Column("po_KasaKodu")]
    [StringLength(4)]
    public string? PoKasaKodu { get; set; }

    [Column("po_BelgeNo")]
    public int? PoBelgeNo { get; set; }

    [Column("po_KasiyerKodu")]
    [StringLength(6)]
    public string? PoKasiyerKodu { get; set; }

    [Column("po_BelgeTarihi")]
    public DateTime? PoBelgeTarihi { get; set; }

    [Column("po_BelgeToplam")]
    public double? PoBelgeToplam { get; set; }

    [Column("po_VerMtrh0")]
    public double? PoVerMtrh0 { get; set; }

    [Column("po_VerMtrh1")]
    public double? PoVerMtrh1 { get; set; }

    [Column("po_VerMtrh2")]
    public double? PoVerMtrh2 { get; set; }

    [Column("po_VerMtrh3")]
    public double? PoVerMtrh3 { get; set; }

    [Column("po_VerMtrh4")]
    public double? PoVerMtrh4 { get; set; }

    [Column("po_VerMtrh5")]
    public double? PoVerMtrh5 { get; set; }

    [Column("po_VerMtrh6")]
    public double? PoVerMtrh6 { get; set; }

    [Column("po_VerMtrh7")]
    public double? PoVerMtrh7 { get; set; }

    [Column("po_VerMtrh8")]
    public double? PoVerMtrh8 { get; set; }

    [Column("po_VerMtrh9")]
    public double? PoVerMtrh9 { get; set; }

    [Column("po_VerMtrh10")]
    public double? PoVerMtrh10 { get; set; }

    [Column("po_Vergi1")]
    public double? PoVergi1 { get; set; }

    [Column("po_Vergi2")]
    public double? PoVergi2 { get; set; }

    [Column("po_Vergi3")]
    public double? PoVergi3 { get; set; }

    [Column("po_Vergi4")]
    public double? PoVergi4 { get; set; }

    [Column("po_Vergi5")]
    public double? PoVergi5 { get; set; }

    [Column("po_Vergi6")]
    public double? PoVergi6 { get; set; }

    [Column("po_Vergi7")]
    public double? PoVergi7 { get; set; }

    [Column("po_Vergi8")]
    public double? PoVergi8 { get; set; }

    [Column("po_Vergi9")]
    public double? PoVergi9 { get; set; }

    [Column("po_Vergi10")]
    public double? PoVergi10 { get; set; }

    [Column("po_Fisfatura")]
    public byte? PoFisfatura { get; set; }

    [Column("po_Pozisyon")]
    public byte? PoPozisyon { get; set; }

    [Column("po_CariKodu")]
    [StringLength(25)]
    public string? PoCariKodu { get; set; }

    [Column("po_Yuvarlama")]
    public double? PoYuvarlama { get; set; }

    [Column("po_Odm_AnaDtut1")]
    public double? PoOdmAnaDtut1 { get; set; }

    [Column("po_Odm_OrjDtut1")]
    public double? PoOdmOrjDtut1 { get; set; }

    [Column("po_Odm_AnaDtut2")]
    public double? PoOdmAnaDtut2 { get; set; }

    [Column("po_Odm_OrjDtut2")]
    public double? PoOdmOrjDtut2 { get; set; }

    [Column("po_Odm_AnaDtut3")]
    public double? PoOdmAnaDtut3 { get; set; }

    [Column("po_Odm_OrjDtut3")]
    public double? PoOdmOrjDtut3 { get; set; }

    [Column("po_Odm_AnaDtut4")]
    public double? PoOdmAnaDtut4 { get; set; }

    [Column("po_Odm_OrjDtut4")]
    public double? PoOdmOrjDtut4 { get; set; }

    [Column("po_Odm_AnaDtut5")]
    public double? PoOdmAnaDtut5 { get; set; }

    [Column("po_Odm_OrjDtut5")]
    public double? PoOdmOrjDtut5 { get; set; }

    [Column("po_Odm_AnaDtut6")]
    public double? PoOdmAnaDtut6 { get; set; }

    [Column("po_Odm_OrjDtut6")]
    public double? PoOdmOrjDtut6 { get; set; }

    [Column("po_Odm_AnaDtut7")]
    public double? PoOdmAnaDtut7 { get; set; }

    [Column("po_Odm_OrjDtut7")]
    public double? PoOdmOrjDtut7 { get; set; }

    [Column("po_Odm_AnaDtut8")]
    public double? PoOdmAnaDtut8 { get; set; }

    [Column("po_Odm_OrjDtut8")]
    public double? PoOdmOrjDtut8 { get; set; }

    [Column("po_Odm_AnaDtut9")]
    public double? PoOdmAnaDtut9 { get; set; }

    [Column("po_Odm_OrjDtut9")]
    public double? PoOdmOrjDtut9 { get; set; }

    [Column("po_Odm_AnaDtut10")]
    public double? PoOdmAnaDtut10 { get; set; }

    [Column("po_Odm_OrjDtut10")]
    public double? PoOdmOrjDtut10 { get; set; }

    [Column("po_Odm_AnaDtut11")]
    public double? PoOdmAnaDtut11 { get; set; }

    [Column("po_Odm_OrjDtut11")]
    public double? PoOdmOrjDtut11 { get; set; }

    [Column("po_Odm_AnaDtut12")]
    public double? PoOdmAnaDtut12 { get; set; }

    [Column("po_Odm_OrjDtut12")]
    public double? PoOdmOrjDtut12 { get; set; }

    [Column("po_Odm_AnaDtut13")]
    public double? PoOdmAnaDtut13 { get; set; }

    [Column("po_Odm_OrjDtut13")]
    public double? PoOdmOrjDtut13 { get; set; }

    [Column("po_Odm_AnaDtut14")]
    public double? PoOdmAnaDtut14 { get; set; }

    [Column("po_Odm_OrjDtut14")]
    public double? PoOdmOrjDtut14 { get; set; }

    [Column("po_Odm_AnaDtut15")]
    public double? PoOdmAnaDtut15 { get; set; }

    [Column("po_Odm_OrjDtut15")]
    public double? PoOdmOrjDtut15 { get; set; }

    [Column("po_Odm_AnaDtut16")]
    public double? PoOdmAnaDtut16 { get; set; }

    [Column("po_Odm_OrjDtut16")]
    public double? PoOdmOrjDtut16 { get; set; }

    [Column("po_Odm_AnaDtut17")]
    public double? PoOdmAnaDtut17 { get; set; }

    [Column("po_Odm_OrjDtut17")]
    public double? PoOdmOrjDtut17 { get; set; }

    [Column("po_Odm_AnaDtut18")]
    public double? PoOdmAnaDtut18 { get; set; }

    [Column("po_Odm_OrjDtut18")]
    public double? PoOdmOrjDtut18 { get; set; }

    [Column("po_Odm_AnaDtut19")]
    public double? PoOdmAnaDtut19 { get; set; }

    [Column("po_Odm_OrjDtut19")]
    public double? PoOdmOrjDtut19 { get; set; }

    [Column("po_Odm_AnaDtut20")]
    public double? PoOdmAnaDtut20 { get; set; }

    [Column("po_Odm_OrjDtut20")]
    public double? PoOdmOrjDtut20 { get; set; }

    [Column("po_Odm_AnaDtut21")]
    public double? PoOdmAnaDtut21 { get; set; }

    [Column("po_Odm_OrjDtut21")]
    public double? PoOdmOrjDtut21 { get; set; }

    [Column("po_Odm_AnaDtut22")]
    public double? PoOdmAnaDtut22 { get; set; }

    [Column("po_Odm_OrjDtut22")]
    public double? PoOdmOrjDtut22 { get; set; }

    [Column("po_Odm_AnaDtut23")]
    public double? PoOdmAnaDtut23 { get; set; }

    [Column("po_Odm_OrjDtut23")]
    public double? PoOdmOrjDtut23 { get; set; }

    [Column("po_Odm_AnaDtut24")]
    public double? PoOdmAnaDtut24 { get; set; }

    [Column("po_Odm_OrjDtut24")]
    public double? PoOdmOrjDtut24 { get; set; }

    [Column("po_Odm_AnaDtut25")]
    public double? PoOdmAnaDtut25 { get; set; }

    [Column("po_Odm_OrjDtut25")]
    public double? PoOdmOrjDtut25 { get; set; }

    [Column("po_Odm_AnaDtut26")]
    public double? PoOdmAnaDtut26 { get; set; }

    [Column("po_Odm_OrjDtut26")]
    public double? PoOdmOrjDtut26 { get; set; }

    [Column("po_Odm_AnaDtut27")]
    public double? PoOdmAnaDtut27 { get; set; }

    [Column("po_Odm_OrjDtut27")]
    public double? PoOdmOrjDtut27 { get; set; }

    [Column("po_Odm_AnaDtut28")]
    public double? PoOdmAnaDtut28 { get; set; }

    [Column("po_Odm_OrjDtut28")]
    public double? PoOdmOrjDtut28 { get; set; }

    [Column("po_Odm_AnaDtut29")]
    public double? PoOdmAnaDtut29 { get; set; }

    [Column("po_Odm_OrjDtut29")]
    public double? PoOdmOrjDtut29 { get; set; }

    [Column("po_Odm_AnaDtut30")]
    public double? PoOdmAnaDtut30 { get; set; }

    [Column("po_Odm_OrjDtut30")]
    public double? PoOdmOrjDtut30 { get; set; }

    [Column("po_Odm_AnaDtut31")]
    public double? PoOdmAnaDtut31 { get; set; }

    [Column("po_Odm_OrjDtut31")]
    public double? PoOdmOrjDtut31 { get; set; }

    [Column("po_Odm_AnaDtut32")]
    public double? PoOdmAnaDtut32 { get; set; }

    [Column("po_Odm_OrjDtut32")]
    public double? PoOdmOrjDtut32 { get; set; }

    [Column("po_Odm_AnaDtut33")]
    public double? PoOdmAnaDtut33 { get; set; }

    [Column("po_Odm_OrjDtut33")]
    public double? PoOdmOrjDtut33 { get; set; }

    [Column("po_Odm_AnaDtut34")]
    public double? PoOdmAnaDtut34 { get; set; }

    [Column("po_Odm_OrjDtut34")]
    public double? PoOdmOrjDtut34 { get; set; }

    [Column("po_Odm_AnaDtut35")]
    public double? PoOdmAnaDtut35 { get; set; }

    [Column("po_Odm_OrjDtut35")]
    public double? PoOdmOrjDtut35 { get; set; }

    [Column("po_Odm_AnaDtut36")]
    public double? PoOdmAnaDtut36 { get; set; }

    [Column("po_Odm_OrjDtut36")]
    public double? PoOdmOrjDtut36 { get; set; }

    [Column("po_Odm_AnaDtut37")]
    public double? PoOdmAnaDtut37 { get; set; }

    [Column("po_Odm_OrjDtut37")]
    public double? PoOdmOrjDtut37 { get; set; }

    [Column("po_Odm_AnaDtut38")]
    public double? PoOdmAnaDtut38 { get; set; }

    [Column("po_Odm_OrjDtut38")]
    public double? PoOdmOrjDtut38 { get; set; }

    [Column("po_Odm_AnaDtut39")]
    public double? PoOdmAnaDtut39 { get; set; }

    [Column("po_Odm_OrjDtut39")]
    public double? PoOdmOrjDtut39 { get; set; }

    [Column("po_Odm_AnaDtut40")]
    public double? PoOdmAnaDtut40 { get; set; }

    [Column("po_Odm_OrjDtut40")]
    public double? PoOdmOrjDtut40 { get; set; }

    [Column("po_Odm_AnaDtut41")]
    public double? PoOdmAnaDtut41 { get; set; }

    [Column("po_Odm_OrjDtut41")]
    public double? PoOdmOrjDtut41 { get; set; }

    [Column("po_Odm_AnaDtut42")]
    public double? PoOdmAnaDtut42 { get; set; }

    [Column("po_Odm_OrjDtut42")]
    public double? PoOdmOrjDtut42 { get; set; }

    [Column("po_Odm_AnaDtut43")]
    public double? PoOdmAnaDtut43 { get; set; }

    [Column("po_Odm_OrjDtut43")]
    public double? PoOdmOrjDtut43 { get; set; }

    [Column("po_Odm_AnaDtut44")]
    public double? PoOdmAnaDtut44 { get; set; }

    [Column("po_Odm_OrjDtut44")]
    public double? PoOdmOrjDtut44 { get; set; }

    [Column("po_Odm_AnaDtut45")]
    public double? PoOdmAnaDtut45 { get; set; }

    [Column("po_Odm_OrjDtut45")]
    public double? PoOdmOrjDtut45 { get; set; }

    [Column("po_Odm_AnaDtut46")]
    public double? PoOdmAnaDtut46 { get; set; }

    [Column("po_Odm_OrjDtut46")]
    public double? PoOdmOrjDtut46 { get; set; }

    [Column("po_Odm_AnaDtut47")]
    public double? PoOdmAnaDtut47 { get; set; }

    [Column("po_Odm_OrjDtut47")]
    public double? PoOdmOrjDtut47 { get; set; }

    [Column("po_Odm_AnaDtut48")]
    public double? PoOdmAnaDtut48 { get; set; }

    [Column("po_Odm_OrjDtut48")]
    public double? PoOdmOrjDtut48 { get; set; }

    [Column("po_Odm_AnaDtut49")]
    public double? PoOdmAnaDtut49 { get; set; }

    [Column("po_Odm_OrjDtut49")]
    public double? PoOdmOrjDtut49 { get; set; }

    [Column("po_Odm_AnaDtut50")]
    public double? PoOdmAnaDtut50 { get; set; }

    [Column("po_Odm_OrjDtut50")]
    public double? PoOdmOrjDtut50 { get; set; }

    [Column("po_Vadeler_OdemeTipi1")]
    public byte? PoVadelerOdemeTipi1 { get; set; }

    [Column("po_Vadeler_vade1")]
    public DateTime? PoVadelerVade1 { get; set; }

    [Column("po_Vadeler_Tutar1")]
    public double? PoVadelerTutar1 { get; set; }

    [Column("po_Vadeler_OdemeTipi2")]
    public byte? PoVadelerOdemeTipi2 { get; set; }

    [Column("po_Vadeler_vade2")]
    public DateTime? PoVadelerVade2 { get; set; }

    [Column("po_Vadeler_Tutar2")]
    public double? PoVadelerTutar2 { get; set; }

    [Column("po_Vadeler_OdemeTipi3")]
    public byte? PoVadelerOdemeTipi3 { get; set; }

    [Column("po_Vadeler_vade3")]
    public DateTime? PoVadelerVade3 { get; set; }

    [Column("po_Vadeler_Tutar3")]
    public double? PoVadelerTutar3 { get; set; }

    [Column("po_Vadeler_OdemeTipi4")]
    public byte? PoVadelerOdemeTipi4 { get; set; }

    [Column("po_Vadeler_vade4")]
    public DateTime? PoVadelerVade4 { get; set; }

    [Column("po_Vadeler_Tutar4")]
    public double? PoVadelerTutar4 { get; set; }

    [Column("po_Vadeler_OdemeTipi5")]
    public byte? PoVadelerOdemeTipi5 { get; set; }

    [Column("po_Vadeler_vade5")]
    public DateTime? PoVadelerVade5 { get; set; }

    [Column("po_Vadeler_Tutar5")]
    public double? PoVadelerTutar5 { get; set; }

    [Column("po_Vadeler_OdemeTipi6")]
    public byte? PoVadelerOdemeTipi6 { get; set; }

    [Column("po_Vadeler_vade6")]
    public DateTime? PoVadelerVade6 { get; set; }

    [Column("po_Vadeler_Tutar6")]
    public double? PoVadelerTutar6 { get; set; }

    [Column("po_Vadeler_OdemeTipi7")]
    public byte? PoVadelerOdemeTipi7 { get; set; }

    [Column("po_Vadeler_vade7")]
    public DateTime? PoVadelerVade7 { get; set; }

    [Column("po_Vadeler_Tutar7")]
    public double? PoVadelerTutar7 { get; set; }

    [Column("po_Vadeler_OdemeTipi8")]
    public byte? PoVadelerOdemeTipi8 { get; set; }

    [Column("po_Vadeler_vade8")]
    public DateTime? PoVadelerVade8 { get; set; }

    [Column("po_Vadeler_Tutar8")]
    public double? PoVadelerTutar8 { get; set; }

    [Column("po_Vadeler_OdemeTipi9")]
    public byte? PoVadelerOdemeTipi9 { get; set; }

    [Column("po_Vadeler_vade9")]
    public DateTime? PoVadelerVade9 { get; set; }

    [Column("po_Vadeler_Tutar9")]
    public double? PoVadelerTutar9 { get; set; }

    [Column("po_Vadeler_OdemeTipi10")]
    public byte? PoVadelerOdemeTipi10 { get; set; }

    [Column("po_Vadeler_vade10")]
    public DateTime? PoVadelerVade10 { get; set; }

    [Column("po_Vadeler_Tutar10")]
    public double? PoVadelerTutar10 { get; set; }

    [Column("po_Vadeler_OdemeTipi11")]
    public byte? PoVadelerOdemeTipi11 { get; set; }

    [Column("po_Vadeler_vade11")]
    public DateTime? PoVadelerVade11 { get; set; }

    [Column("po_Vadeler_Tutar11")]
    public double? PoVadelerTutar11 { get; set; }

    [Column("po_Vadeler_OdemeTipi12")]
    public byte? PoVadelerOdemeTipi12 { get; set; }

    [Column("po_Vadeler_vade12")]
    public DateTime? PoVadelerVade12 { get; set; }

    [Column("po_Vadeler_Tutar12")]
    public double? PoVadelerTutar12 { get; set; }

    [Column("po_Vadeler_OdemeTipi13")]
    public byte? PoVadelerOdemeTipi13 { get; set; }

    [Column("po_Vadeler_vade13")]
    public DateTime? PoVadelerVade13 { get; set; }

    [Column("po_Vadeler_Tutar13")]
    public double? PoVadelerTutar13 { get; set; }

    [Column("po_Vadeler_OdemeTipi14")]
    public byte? PoVadelerOdemeTipi14 { get; set; }

    [Column("po_Vadeler_vade14")]
    public DateTime? PoVadelerVade14 { get; set; }

    [Column("po_Vadeler_Tutar14")]
    public double? PoVadelerTutar14 { get; set; }

    [Column("po_Vadeler_OdemeTipi15")]
    public byte? PoVadelerOdemeTipi15 { get; set; }

    [Column("po_Vadeler_vade15")]
    public DateTime? PoVadelerVade15 { get; set; }

    [Column("po_Vadeler_Tutar15")]
    public double? PoVadelerTutar15 { get; set; }

    [Column("po_Vadeler_OdemeTipi16")]
    public byte? PoVadelerOdemeTipi16 { get; set; }

    [Column("po_Vadeler_vade16")]
    public DateTime? PoVadelerVade16 { get; set; }

    [Column("po_Vadeler_Tutar16")]
    public double? PoVadelerTutar16 { get; set; }

    [Column("po_Vadeler_OdemeTipi17")]
    public byte? PoVadelerOdemeTipi17 { get; set; }

    [Column("po_Vadeler_vade17")]
    public DateTime? PoVadelerVade17 { get; set; }

    [Column("po_Vadeler_Tutar17")]
    public double? PoVadelerTutar17 { get; set; }

    [Column("po_Vadeler_OdemeTipi18")]
    public byte? PoVadelerOdemeTipi18 { get; set; }

    [Column("po_Vadeler_vade18")]
    public DateTime? PoVadelerVade18 { get; set; }

    [Column("po_Vadeler_Tutar18")]
    public double? PoVadelerTutar18 { get; set; }

    [Column("po_Vadeler_OdemeTipi19")]
    public byte? PoVadelerOdemeTipi19 { get; set; }

    [Column("po_Vadeler_vade19")]
    public DateTime? PoVadelerVade19 { get; set; }

    [Column("po_Vadeler_Tutar19")]
    public double? PoVadelerTutar19 { get; set; }

    [Column("po_Vadeler_OdemeTipi20")]
    public byte? PoVadelerOdemeTipi20 { get; set; }

    [Column("po_Vadeler_vade20")]
    public DateTime? PoVadelerVade20 { get; set; }

    [Column("po_Vadeler_Tutar20")]
    public double? PoVadelerTutar20 { get; set; }

    [Column("po_Vadeler_OdemeTipi21")]
    public byte? PoVadelerOdemeTipi21 { get; set; }

    [Column("po_Vadeler_vade21")]
    public DateTime? PoVadelerVade21 { get; set; }

    [Column("po_Vadeler_Tutar21")]
    public double? PoVadelerTutar21 { get; set; }

    [Column("po_Vadeler_OdemeTipi22")]
    public byte? PoVadelerOdemeTipi22 { get; set; }

    [Column("po_Vadeler_vade22")]
    public DateTime? PoVadelerVade22 { get; set; }

    [Column("po_Vadeler_Tutar22")]
    public double? PoVadelerTutar22 { get; set; }

    [Column("po_Vadeler_OdemeTipi23")]
    public byte? PoVadelerOdemeTipi23 { get; set; }

    [Column("po_Vadeler_vade23")]
    public DateTime? PoVadelerVade23 { get; set; }

    [Column("po_Vadeler_Tutar23")]
    public double? PoVadelerTutar23 { get; set; }

    [Column("po_Vadeler_OdemeTipi24")]
    public byte? PoVadelerOdemeTipi24 { get; set; }

    [Column("po_Vadeler_vade24")]
    public DateTime? PoVadelerVade24 { get; set; }

    [Column("po_Vadeler_Tutar24")]
    public double? PoVadelerTutar24 { get; set; }

    [Column("po_Vadeler_OdemeTipi25")]
    public byte? PoVadelerOdemeTipi25 { get; set; }

    [Column("po_Vadeler_vade25")]
    public DateTime? PoVadelerVade25 { get; set; }

    [Column("po_Vadeler_Tutar25")]
    public double? PoVadelerTutar25 { get; set; }

    [Column("po_Vadeler_OdemeTipi26")]
    public byte? PoVadelerOdemeTipi26 { get; set; }

    [Column("po_Vadeler_vade26")]
    public DateTime? PoVadelerVade26 { get; set; }

    [Column("po_Vadeler_Tutar26")]
    public double? PoVadelerTutar26 { get; set; }

    [Column("po_Vadeler_OdemeTipi27")]
    public byte? PoVadelerOdemeTipi27 { get; set; }

    [Column("po_Vadeler_vade27")]
    public DateTime? PoVadelerVade27 { get; set; }

    [Column("po_Vadeler_Tutar27")]
    public double? PoVadelerTutar27 { get; set; }

    [Column("po_Vadeler_OdemeTipi28")]
    public byte? PoVadelerOdemeTipi28 { get; set; }

    [Column("po_Vadeler_vade28")]
    public DateTime? PoVadelerVade28 { get; set; }

    [Column("po_Vadeler_Tutar28")]
    public double? PoVadelerTutar28 { get; set; }

    [Column("po_Vadeler_OdemeTipi29")]
    public byte? PoVadelerOdemeTipi29 { get; set; }

    [Column("po_Vadeler_vade29")]
    public DateTime? PoVadelerVade29 { get; set; }

    [Column("po_Vadeler_Tutar29")]
    public double? PoVadelerTutar29 { get; set; }

    [Column("po_Vadeler_OdemeTipi30")]
    public byte? PoVadelerOdemeTipi30 { get; set; }

    [Column("po_Vadeler_vade30")]
    public DateTime? PoVadelerVade30 { get; set; }

    [Column("po_Vadeler_Tutar30")]
    public double? PoVadelerTutar30 { get; set; }

    [Column("po_Vadeler_OdemeTipi31")]
    public byte? PoVadelerOdemeTipi31 { get; set; }

    [Column("po_Vadeler_vade31")]
    public DateTime? PoVadelerVade31 { get; set; }

    [Column("po_Vadeler_Tutar31")]
    public double? PoVadelerTutar31 { get; set; }

    [Column("po_Vadeler_OdemeTipi32")]
    public byte? PoVadelerOdemeTipi32 { get; set; }

    [Column("po_Vadeler_vade32")]
    public DateTime? PoVadelerVade32 { get; set; }

    [Column("po_Vadeler_Tutar32")]
    public double? PoVadelerTutar32 { get; set; }

    [Column("po_Vadeler_OdemeTipi33")]
    public byte? PoVadelerOdemeTipi33 { get; set; }

    [Column("po_Vadeler_vade33")]
    public DateTime? PoVadelerVade33 { get; set; }

    [Column("po_Vadeler_Tutar33")]
    public double? PoVadelerTutar33 { get; set; }

    [Column("po_Vadeler_OdemeTipi34")]
    public byte? PoVadelerOdemeTipi34 { get; set; }

    [Column("po_Vadeler_vade34")]
    public DateTime? PoVadelerVade34 { get; set; }

    [Column("po_Vadeler_Tutar34")]
    public double? PoVadelerTutar34 { get; set; }

    [Column("po_Vadeler_OdemeTipi35")]
    public byte? PoVadelerOdemeTipi35 { get; set; }

    [Column("po_Vadeler_vade35")]
    public DateTime? PoVadelerVade35 { get; set; }

    [Column("po_Vadeler_Tutar35")]
    public double? PoVadelerTutar35 { get; set; }

    [Column("po_Vadeler_OdemeTipi36")]
    public byte? PoVadelerOdemeTipi36 { get; set; }

    [Column("po_Vadeler_vade36")]
    public DateTime? PoVadelerVade36 { get; set; }

    [Column("po_Vadeler_Tutar36")]
    public double? PoVadelerTutar36 { get; set; }

    [Column("po_Tks_Satis")]
    public bool? PoTksSatis { get; set; }

    [Column("po_Tks_Satis_Tutar")]
    public double? PoTksSatisTutar { get; set; }

    [Column("po_Odm_TaksitTipi1")]
    public byte? PoOdmTaksitTipi1 { get; set; }

    [Column("po_Odm_TaksitTipi2")]
    public byte? PoOdmTaksitTipi2 { get; set; }

    [Column("po_Odm_TaksitTipi3")]
    public byte? PoOdmTaksitTipi3 { get; set; }

    [Column("po_Odm_TaksitTipi4")]
    public byte? PoOdmTaksitTipi4 { get; set; }

    [Column("po_Odm_TaksitTipi5")]
    public byte? PoOdmTaksitTipi5 { get; set; }

    [Column("po_Odm_TaksitTipi6")]
    public byte? PoOdmTaksitTipi6 { get; set; }

    [Column("po_Odm_TaksitTipi7")]
    public byte? PoOdmTaksitTipi7 { get; set; }

    [Column("po_Odm_TaksitTipi8")]
    public byte? PoOdmTaksitTipi8 { get; set; }

    [Column("po_Odm_TaksitTipi9")]
    public byte? PoOdmTaksitTipi9 { get; set; }

    [Column("po_Odm_TaksitTipi10")]
    public byte? PoOdmTaksitTipi10 { get; set; }

    [Column("po_Odm_TaksitTipi11")]
    public byte? PoOdmTaksitTipi11 { get; set; }

    [Column("po_Odm_TaksitTipi12")]
    public byte? PoOdmTaksitTipi12 { get; set; }

    [Column("po_Odm_TaksitTipi13")]
    public byte? PoOdmTaksitTipi13 { get; set; }

    [Column("po_Odm_TaksitTipi14")]
    public byte? PoOdmTaksitTipi14 { get; set; }

    [Column("po_Odm_TaksitTipi15")]
    public byte? PoOdmTaksitTipi15 { get; set; }

    [Column("po_Odm_TaksitTipi16")]
    public byte? PoOdmTaksitTipi16 { get; set; }

    [Column("po_Odm_TaksitTipi17")]
    public byte? PoOdmTaksitTipi17 { get; set; }

    [Column("po_Odm_TaksitTipi18")]
    public byte? PoOdmTaksitTipi18 { get; set; }

    [Column("po_Odm_TaksitTipi19")]
    public byte? PoOdmTaksitTipi19 { get; set; }

    [Column("po_Odm_TaksitTipi20")]
    public byte? PoOdmTaksitTipi20 { get; set; }

    [Column("po_Odm_TaksitTipi21")]
    public byte? PoOdmTaksitTipi21 { get; set; }

    [Column("po_Odm_TaksitTipi22")]
    public byte? PoOdmTaksitTipi22 { get; set; }

    [Column("po_Odm_TaksitTipi23")]
    public byte? PoOdmTaksitTipi23 { get; set; }

    [Column("po_Odm_TaksitTipi24")]
    public byte? PoOdmTaksitTipi24 { get; set; }

    [Column("po_Odm_TaksitTipi25")]
    public byte? PoOdmTaksitTipi25 { get; set; }

    [Column("po_Odm_TaksitTipi26")]
    public byte? PoOdmTaksitTipi26 { get; set; }

    [Column("po_Odm_TaksitTipi27")]
    public byte? PoOdmTaksitTipi27 { get; set; }

    [Column("po_Odm_TaksitTipi28")]
    public byte? PoOdmTaksitTipi28 { get; set; }

    [Column("po_Odm_TaksitTipi29")]
    public byte? PoOdmTaksitTipi29 { get; set; }

    [Column("po_Odm_TaksitTipi30")]
    public byte? PoOdmTaksitTipi30 { get; set; }

    [Column("po_Odm_TaksitTipi31")]
    public byte? PoOdmTaksitTipi31 { get; set; }

    [Column("po_Odm_TaksitTipi32")]
    public byte? PoOdmTaksitTipi32 { get; set; }

    [Column("po_Odm_TaksitTipi33")]
    public byte? PoOdmTaksitTipi33 { get; set; }

    [Column("po_Odm_TaksitTipi34")]
    public byte? PoOdmTaksitTipi34 { get; set; }

    [Column("po_Odm_TaksitTipi35")]
    public byte? PoOdmTaksitTipi35 { get; set; }

    [Column("po_Odm_TaksitTipi36")]
    public byte? PoOdmTaksitTipi36 { get; set; }

    [Column("po_Odm_TaksitTipi37")]
    public byte? PoOdmTaksitTipi37 { get; set; }

    [Column("po_Odm_TaksitTipi38")]
    public byte? PoOdmTaksitTipi38 { get; set; }

    [Column("po_Odm_TaksitTipi39")]
    public byte? PoOdmTaksitTipi39 { get; set; }

    [Column("po_Odm_TaksitTipi40")]
    public byte? PoOdmTaksitTipi40 { get; set; }

    [Column("po_Odm_TaksitTipi41")]
    public byte? PoOdmTaksitTipi41 { get; set; }

    [Column("po_Odm_TaksitTipi42")]
    public byte? PoOdmTaksitTipi42 { get; set; }

    [Column("po_Odm_TaksitTipi43")]
    public byte? PoOdmTaksitTipi43 { get; set; }

    [Column("po_Odm_TaksitTipi44")]
    public byte? PoOdmTaksitTipi44 { get; set; }

    [Column("po_Odm_TaksitTipi45")]
    public byte? PoOdmTaksitTipi45 { get; set; }

    [Column("po_Odm_TaksitTipi46")]
    public byte? PoOdmTaksitTipi46 { get; set; }

    [Column("po_Odm_TaksitTipi47")]
    public byte? PoOdmTaksitTipi47 { get; set; }

    [Column("po_Odm_TaksitTipi48")]
    public byte? PoOdmTaksitTipi48 { get; set; }

    [Column("po_Odm_TaksitTipi49")]
    public byte? PoOdmTaksitTipi49 { get; set; }

    [Column("po_Odm_TaksitTipi50")]
    public byte? PoOdmTaksitTipi50 { get; set; }

    [Column("po_OdemeNo1")]
    public byte? PoOdemeNo1 { get; set; }

    [Column("po_ProvizyonKodu1")]
    [StringLength(10)]
    public string? PoProvizyonKodu1 { get; set; }

    [Column("po_ProvizyonTutari1")]
    public double? PoProvizyonTutari1 { get; set; }

    [Column("po_OdemeNo2")]
    public byte? PoOdemeNo2 { get; set; }

    [Column("po_ProvizyonKodu2")]
    [StringLength(10)]
    public string? PoProvizyonKodu2 { get; set; }

    [Column("po_ProvizyonTutari2")]
    public double? PoProvizyonTutari2 { get; set; }

    [Column("po_OdemeNo3")]
    public byte? PoOdemeNo3 { get; set; }

    [Column("po_ProvizyonKodu3")]
    [StringLength(10)]
    public string? PoProvizyonKodu3 { get; set; }

    [Column("po_ProvizyonTutari3")]
    public double? PoProvizyonTutari3 { get; set; }

    [Column("po_OdemeNo4")]
    public byte? PoOdemeNo4 { get; set; }

    [Column("po_ProvizyonKodu4")]
    [StringLength(10)]
    public string? PoProvizyonKodu4 { get; set; }

    [Column("po_ProvizyonTutari4")]
    public double? PoProvizyonTutari4 { get; set; }

    [Column("po_OdemeNo5")]
    public byte? PoOdemeNo5 { get; set; }

    [Column("po_ProvizyonKodu5")]
    [StringLength(10)]
    public string? PoProvizyonKodu5 { get; set; }

    [Column("po_ProvizyonTutari5")]
    public double? PoProvizyonTutari5 { get; set; }

    [Column("po_OdemeNo6")]
    public byte? PoOdemeNo6 { get; set; }

    [Column("po_ProvizyonKodu6")]
    [StringLength(10)]
    public string? PoProvizyonKodu6 { get; set; }

    [Column("po_ProvizyonTutari6")]
    public double? PoProvizyonTutari6 { get; set; }

    [Column("po_Tahsilat_evrakno_seri")]
    [StringLength(50)]
    public string? PoTahsilatEvraknoSeri { get; set; }

    [Column("po_Tahsilat_evrakno_sira")]
    public int? PoTahsilatEvraknoSira { get; set; }

    [Column("po_Tahsilat_Tutari")]
    public double? PoTahsilatTutari { get; set; }

    [Column("po_ParaUstuOdemeTipi")]
    public byte? PoParaUstuOdemeTipi { get; set; }

    [Column("po_ParaUstuAnaDtut")]
    public double? PoParaUstuAnaDtut { get; set; }

    [Column("po_ParaUstuOrjDtut")]
    public double? PoParaUstuOrjDtut { get; set; }

    [Column("po_EvrakID")]
    [StringLength(40)]
    public string? PoEvrakID { get; set; }

    [Column("po_AdresNo")]
    public int? PoAdresNo { get; set; }

    [Column("po_EArsivSeri")]
    [StringLength(7)]
    public string? PoEArsivSeri { get; set; }

    [Column("po_EArsivSira")]
    public int? PoEArsivSira { get; set; }

    [Column("po_ZNo")]
    public int? PoZNo { get; set; }

    [Column("po_FNo")]
    public int? PoFNo { get; set; }

    [Column("po_EJNo")]
    public int? PoEJNo { get; set; }

    [Column("po_OKCEvrakID")]
    [StringLength(40)]
    public string? PoOKCEvrakID { get; set; }

    [Column("po_YolcuBeraberKod")]
    [StringLength(25)]
    public string? PoYolcuBeraberKod { get; set; }

    [Column("po_YolcuBeraberIstisnaKodu")]
    [StringLength(5)]
    public string? PoYolcuBeraberIstisnaKodu { get; set; }

    [Column("po_YolcuBeraberAraciKurumKodu")]
    [StringLength(25)]
    public string? PoYolcuBeraberAraciKurumKodu { get; set; }
}
