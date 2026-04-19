using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_tahakkuk_ozetleri_simulator")]
public class PersonelTahakkukOzetleriSimulator
{
    [Column("pro_Guid")]
    public Guid? ProGuid { get; set; }

    [Column("pro_DBCno")]
    public short? ProDBCno { get; set; }

    [Column("pro_SpecRECno")]
    public int? ProSpecRECno { get; set; }

    [Column("pro_iptal")]
    public bool? ProIptal { get; set; }

    [Column("pro_fileid")]
    public short? ProFileid { get; set; }

    [Column("pro_hidden")]
    public bool? ProHidden { get; set; }

    [Column("pro_kilitli")]
    public bool? ProKilitli { get; set; }

    [Column("pro_degisti")]
    public bool? ProDegisti { get; set; }

    [Column("pro_checksum")]
    public int? ProChecksum { get; set; }

    [Column("pro_create_user")]
    public short? ProCreateUser { get; set; }

    [Column("pro_create_date")]
    public DateTime? ProCreateDate { get; set; }

    [Column("pro_lastup_user")]
    public short? ProLastupUser { get; set; }

    [Column("pro_lastup_date")]
    public DateTime? ProLastupDate { get; set; }

    [Column("pro_special1")]
    [StringLength(4)]
    public string? ProSpecial1 { get; set; }

    [Column("pro_special2")]
    [StringLength(4)]
    public string? ProSpecial2 { get; set; }

    [Column("pro_special3")]
    [StringLength(4)]
    public string? ProSpecial3 { get; set; }

    [Column("pro_kodozet")]
    [StringLength(25)]
    public string? ProKodozet { get; set; }

    [Column("pro_ozetyili")]
    public short? ProOzetyili { get; set; }

    [Column("pro_Ponceodkfayi")]
    public short? ProPonceodkfayi { get; set; }

    [Column("pro_kumvergimat")]
    public double? ProKumvergimat { get; set; }

    [Column("pro_borcu")]
    public double? ProBorcu { get; set; }

    [Column("pro_borcutaksit")]
    public double? ProBorcutaksit { get; set; }

    [Column("pro_icra")]
    public double? ProIcra { get; set; }

    [Column("pro_icrataksit")]
    public double? ProIcrataksit { get; set; }

    [Column("pro_kredi")]
    public double? ProKredi { get; set; }

    [Column("pro_kreditaksit")]
    public double? ProKreditaksit { get; set; }

    [Column("pro_tersbakiye")]
    public double? ProTersbakiye { get; set; }

    [Column("pro_yuvarlamafarki")]
    public double? ProYuvarlamafarki { get; set; }

    [Column("pro_gec_yil_kummatra")]
    public double? ProGecYilKummatra { get; set; }

    [Column("pro_gec_yil_vergi")]
    public double? ProGecYilVergi { get; set; }

    [Column("pro_evrak_tutari")]
    public double? ProEvrakTutari { get; set; }

    [Column("pro_top_vergi_iadesi")]
    public double? ProTopVergiIadesi { get; set; }

    [Column("pro_kumvergi")]
    public double? ProKumvergi { get; set; }

    [Column("pro_kfgeneltoplam")]
    public double? ProKfgeneltoplam { get; set; }

    [Column("pro_tt_genel_toplam")]
    public double? ProTtGenelToplam { get; set; }

    [Column("pro_aylik_sskgun1")]
    public short? ProAylikSskgun1 { get; set; }

    [Column("pro_aylik_sskkaz1")]
    public double? ProAylikSskkaz1 { get; set; }

    [Column("pro_aylik_ssk1")]
    public double? ProAylikSsk1 { get; set; }

    [Column("pro_aylik_gvmatrah1")]
    public double? ProAylikGvmatrah1 { get; set; }

    [Column("pro_aylik_gv1")]
    public double? ProAylikGv1 { get; set; }

    [Column("pro_aylik_dvmatrah1")]
    public double? ProAylikDvmatrah1 { get; set; }

    [Column("pro_aylik_dv1")]
    public double? ProAylikDv1 { get; set; }

    [Column("pro_aylik_konutfn1")]
    public double? ProAylikKonutfn1 { get; set; }

    [Column("pro_aylik_kaz1")]
    public double? ProAylikKaz1 { get; set; }

    [Column("pro_aylik_ekkaz1")]
    public double? ProAylikEkkaz1 { get; set; }

    [Column("pro_aylik_sosyardim1")]
    public double? ProAylikSosyardim1 { get; set; }

    [Column("pro_aylik_kesinti1")]
    public double? ProAylikKesinti1 { get; set; }

    [Column("pro_aylik_netto1")]
    public double? ProAylikNetto1 { get; set; }

    [Column("pro_aylik_v_iade1")]
    public double? ProAylikVIade1 { get; set; }

    [Column("pro_aylik_sosyrdkid1")]
    public double? ProAylikSosyrdkid1 { get; set; }

    [Column("pro_aylik_issigmat1")]
    public double? ProAylikIssigmat1 { get; set; }

    [Column("pro_aylik_issigper1")]
    public double? ProAylikIssigper1 { get; set; }

    [Column("pro_aylik_issigisv1")]
    public double? ProAylikIssigisv1 { get; set; }

    [Column("pro_aylik_issig1")]
    public double? ProAylikIssig1 { get; set; }

    [Column("pro_aylik_sskisv1")]
    public double? ProAylikSskisv1 { get; set; }

    [Column("pro_aylik_asgarigecind1")]
    public double? ProAylikAsgarigecind1 { get; set; }

    [Column("pro_sonrayadevirsskmatrahi1")]
    public double? ProSonrayadevirsskmatrahi1 { get; set; }

    [Column("pro_gecenaylardankullanilanssk1")]
    public double? ProGecenaylardankullanilanssk1 { get; set; }

    [Column("pro_bagkurprimi1")]
    public double? ProBagkurprimi1 { get; set; }

    [Column("pro_aylik_sskgun2")]
    public short? ProAylikSskgun2 { get; set; }

    [Column("pro_aylik_sskkaz2")]
    public double? ProAylikSskkaz2 { get; set; }

    [Column("pro_aylik_ssk2")]
    public double? ProAylikSsk2 { get; set; }

    [Column("pro_aylik_gvmatrah2")]
    public double? ProAylikGvmatrah2 { get; set; }

    [Column("pro_aylik_gv2")]
    public double? ProAylikGv2 { get; set; }

    [Column("pro_aylik_dvmatrah2")]
    public double? ProAylikDvmatrah2 { get; set; }

    [Column("pro_aylik_dv2")]
    public double? ProAylikDv2 { get; set; }

    [Column("pro_aylik_konutfn2")]
    public double? ProAylikKonutfn2 { get; set; }

    [Column("pro_aylik_kaz2")]
    public double? ProAylikKaz2 { get; set; }

    [Column("pro_aylik_ekkaz2")]
    public double? ProAylikEkkaz2 { get; set; }

    [Column("pro_aylik_sosyardim2")]
    public double? ProAylikSosyardim2 { get; set; }

    [Column("pro_aylik_kesinti2")]
    public double? ProAylikKesinti2 { get; set; }

    [Column("pro_aylik_netto2")]
    public double? ProAylikNetto2 { get; set; }

    [Column("pro_aylik_v_iade2")]
    public double? ProAylikVIade2 { get; set; }

    [Column("pro_aylik_sosyrdkid2")]
    public double? ProAylikSosyrdkid2 { get; set; }

    [Column("pro_aylik_issigmat2")]
    public double? ProAylikIssigmat2 { get; set; }

    [Column("pro_aylik_issigper2")]
    public double? ProAylikIssigper2 { get; set; }

    [Column("pro_aylik_issigisv2")]
    public double? ProAylikIssigisv2 { get; set; }

    [Column("pro_aylik_issig2")]
    public double? ProAylikIssig2 { get; set; }

    [Column("pro_aylik_sskisv2")]
    public double? ProAylikSskisv2 { get; set; }

    [Column("pro_aylik_asgarigecind2")]
    public double? ProAylikAsgarigecind2 { get; set; }

    [Column("pro_sonrayadevirsskmatrahi2")]
    public double? ProSonrayadevirsskmatrahi2 { get; set; }

    [Column("pro_gecenaylardankullanilanssk2")]
    public double? ProGecenaylardankullanilanssk2 { get; set; }

    [Column("pro_bagkurprimi2")]
    public double? ProBagkurprimi2 { get; set; }

    [Column("pro_aylik_sskgun3")]
    public short? ProAylikSskgun3 { get; set; }

    [Column("pro_aylik_sskkaz3")]
    public double? ProAylikSskkaz3 { get; set; }

    [Column("pro_aylik_ssk3")]
    public double? ProAylikSsk3 { get; set; }

    [Column("pro_aylik_gvmatrah3")]
    public double? ProAylikGvmatrah3 { get; set; }

    [Column("pro_aylik_gv3")]
    public double? ProAylikGv3 { get; set; }

    [Column("pro_aylik_dvmatrah3")]
    public double? ProAylikDvmatrah3 { get; set; }

    [Column("pro_aylik_dv3")]
    public double? ProAylikDv3 { get; set; }

    [Column("pro_aylik_konutfn3")]
    public double? ProAylikKonutfn3 { get; set; }

    [Column("pro_aylik_kaz3")]
    public double? ProAylikKaz3 { get; set; }

    [Column("pro_aylik_ekkaz3")]
    public double? ProAylikEkkaz3 { get; set; }

    [Column("pro_aylik_sosyardim3")]
    public double? ProAylikSosyardim3 { get; set; }

    [Column("pro_aylik_kesinti3")]
    public double? ProAylikKesinti3 { get; set; }

    [Column("pro_aylik_netto3")]
    public double? ProAylikNetto3 { get; set; }

    [Column("pro_aylik_v_iade3")]
    public double? ProAylikVIade3 { get; set; }

    [Column("pro_aylik_sosyrdkid3")]
    public double? ProAylikSosyrdkid3 { get; set; }

    [Column("pro_aylik_issigmat3")]
    public double? ProAylikIssigmat3 { get; set; }

    [Column("pro_aylik_issigper3")]
    public double? ProAylikIssigper3 { get; set; }

    [Column("pro_aylik_issigisv3")]
    public double? ProAylikIssigisv3 { get; set; }

    [Column("pro_aylik_issig3")]
    public double? ProAylikIssig3 { get; set; }

    [Column("pro_aylik_sskisv3")]
    public double? ProAylikSskisv3 { get; set; }

    [Column("pro_aylik_asgarigecind3")]
    public double? ProAylikAsgarigecind3 { get; set; }

    [Column("pro_sonrayadevirsskmatrahi3")]
    public double? ProSonrayadevirsskmatrahi3 { get; set; }

    [Column("pro_gecenaylardankullanilanssk3")]
    public double? ProGecenaylardankullanilanssk3 { get; set; }

    [Column("pro_bagkurprimi3")]
    public double? ProBagkurprimi3 { get; set; }

    [Column("pro_aylik_sskgun4")]
    public short? ProAylikSskgun4 { get; set; }

    [Column("pro_aylik_sskkaz4")]
    public double? ProAylikSskkaz4 { get; set; }

    [Column("pro_aylik_ssk4")]
    public double? ProAylikSsk4 { get; set; }

    [Column("pro_aylik_gvmatrah4")]
    public double? ProAylikGvmatrah4 { get; set; }

    [Column("pro_aylik_gv4")]
    public double? ProAylikGv4 { get; set; }

    [Column("pro_aylik_dvmatrah4")]
    public double? ProAylikDvmatrah4 { get; set; }

    [Column("pro_aylik_dv4")]
    public double? ProAylikDv4 { get; set; }

    [Column("pro_aylik_konutfn4")]
    public double? ProAylikKonutfn4 { get; set; }

    [Column("pro_aylik_kaz4")]
    public double? ProAylikKaz4 { get; set; }

    [Column("pro_aylik_ekkaz4")]
    public double? ProAylikEkkaz4 { get; set; }

    [Column("pro_aylik_sosyardim4")]
    public double? ProAylikSosyardim4 { get; set; }

    [Column("pro_aylik_kesinti4")]
    public double? ProAylikKesinti4 { get; set; }

    [Column("pro_aylik_netto4")]
    public double? ProAylikNetto4 { get; set; }

    [Column("pro_aylik_v_iade4")]
    public double? ProAylikVIade4 { get; set; }

    [Column("pro_aylik_sosyrdkid4")]
    public double? ProAylikSosyrdkid4 { get; set; }

    [Column("pro_aylik_issigmat4")]
    public double? ProAylikIssigmat4 { get; set; }

    [Column("pro_aylik_issigper4")]
    public double? ProAylikIssigper4 { get; set; }

    [Column("pro_aylik_issigisv4")]
    public double? ProAylikIssigisv4 { get; set; }

    [Column("pro_aylik_issig4")]
    public double? ProAylikIssig4 { get; set; }

    [Column("pro_aylik_sskisv4")]
    public double? ProAylikSskisv4 { get; set; }

    [Column("pro_aylik_asgarigecind4")]
    public double? ProAylikAsgarigecind4 { get; set; }

    [Column("pro_sonrayadevirsskmatrahi4")]
    public double? ProSonrayadevirsskmatrahi4 { get; set; }

    [Column("pro_gecenaylardankullanilanssk4")]
    public double? ProGecenaylardankullanilanssk4 { get; set; }

    [Column("pro_bagkurprimi4")]
    public double? ProBagkurprimi4 { get; set; }

    [Column("pro_aylik_sskgun5")]
    public short? ProAylikSskgun5 { get; set; }

    [Column("pro_aylik_sskkaz5")]
    public double? ProAylikSskkaz5 { get; set; }

    [Column("pro_aylik_ssk5")]
    public double? ProAylikSsk5 { get; set; }

    [Column("pro_aylik_gvmatrah5")]
    public double? ProAylikGvmatrah5 { get; set; }

    [Column("pro_aylik_gv5")]
    public double? ProAylikGv5 { get; set; }

    [Column("pro_aylik_dvmatrah5")]
    public double? ProAylikDvmatrah5 { get; set; }

    [Column("pro_aylik_dv5")]
    public double? ProAylikDv5 { get; set; }

    [Column("pro_aylik_konutfn5")]
    public double? ProAylikKonutfn5 { get; set; }

    [Column("pro_aylik_kaz5")]
    public double? ProAylikKaz5 { get; set; }

    [Column("pro_aylik_ekkaz5")]
    public double? ProAylikEkkaz5 { get; set; }

    [Column("pro_aylik_sosyardim5")]
    public double? ProAylikSosyardim5 { get; set; }

    [Column("pro_aylik_kesinti5")]
    public double? ProAylikKesinti5 { get; set; }

    [Column("pro_aylik_netto5")]
    public double? ProAylikNetto5 { get; set; }

    [Column("pro_aylik_v_iade5")]
    public double? ProAylikVIade5 { get; set; }

    [Column("pro_aylik_sosyrdkid5")]
    public double? ProAylikSosyrdkid5 { get; set; }

    [Column("pro_aylik_issigmat5")]
    public double? ProAylikIssigmat5 { get; set; }

    [Column("pro_aylik_issigper5")]
    public double? ProAylikIssigper5 { get; set; }

    [Column("pro_aylik_issigisv5")]
    public double? ProAylikIssigisv5 { get; set; }

    [Column("pro_aylik_issig5")]
    public double? ProAylikIssig5 { get; set; }

    [Column("pro_aylik_sskisv5")]
    public double? ProAylikSskisv5 { get; set; }

    [Column("pro_aylik_asgarigecind5")]
    public double? ProAylikAsgarigecind5 { get; set; }

    [Column("pro_sonrayadevirsskmatrahi5")]
    public double? ProSonrayadevirsskmatrahi5 { get; set; }

    [Column("pro_gecenaylardankullanilanssk5")]
    public double? ProGecenaylardankullanilanssk5 { get; set; }

    [Column("pro_bagkurprimi5")]
    public double? ProBagkurprimi5 { get; set; }

    [Column("pro_aylik_sskgun6")]
    public short? ProAylikSskgun6 { get; set; }

    [Column("pro_aylik_sskkaz6")]
    public double? ProAylikSskkaz6 { get; set; }

    [Column("pro_aylik_ssk6")]
    public double? ProAylikSsk6 { get; set; }

    [Column("pro_aylik_gvmatrah6")]
    public double? ProAylikGvmatrah6 { get; set; }

    [Column("pro_aylik_gv6")]
    public double? ProAylikGv6 { get; set; }

    [Column("pro_aylik_dvmatrah6")]
    public double? ProAylikDvmatrah6 { get; set; }

    [Column("pro_aylik_dv6")]
    public double? ProAylikDv6 { get; set; }

    [Column("pro_aylik_konutfn6")]
    public double? ProAylikKonutfn6 { get; set; }

    [Column("pro_aylik_kaz6")]
    public double? ProAylikKaz6 { get; set; }

    [Column("pro_aylik_ekkaz6")]
    public double? ProAylikEkkaz6 { get; set; }

    [Column("pro_aylik_sosyardim6")]
    public double? ProAylikSosyardim6 { get; set; }

    [Column("pro_aylik_kesinti6")]
    public double? ProAylikKesinti6 { get; set; }

    [Column("pro_aylik_netto6")]
    public double? ProAylikNetto6 { get; set; }

    [Column("pro_aylik_v_iade6")]
    public double? ProAylikVIade6 { get; set; }

    [Column("pro_aylik_sosyrdkid6")]
    public double? ProAylikSosyrdkid6 { get; set; }

    [Column("pro_aylik_issigmat6")]
    public double? ProAylikIssigmat6 { get; set; }

    [Column("pro_aylik_issigper6")]
    public double? ProAylikIssigper6 { get; set; }

    [Column("pro_aylik_issigisv6")]
    public double? ProAylikIssigisv6 { get; set; }

    [Column("pro_aylik_issig6")]
    public double? ProAylikIssig6 { get; set; }

    [Column("pro_aylik_sskisv6")]
    public double? ProAylikSskisv6 { get; set; }

    [Column("pro_aylik_asgarigecind6")]
    public double? ProAylikAsgarigecind6 { get; set; }

    [Column("pro_sonrayadevirsskmatrahi6")]
    public double? ProSonrayadevirsskmatrahi6 { get; set; }

    [Column("pro_gecenaylardankullanilanssk6")]
    public double? ProGecenaylardankullanilanssk6 { get; set; }

    [Column("pro_bagkurprimi6")]
    public double? ProBagkurprimi6 { get; set; }

    [Column("pro_aylik_sskgun7")]
    public short? ProAylikSskgun7 { get; set; }

    [Column("pro_aylik_sskkaz7")]
    public double? ProAylikSskkaz7 { get; set; }

    [Column("pro_aylik_ssk7")]
    public double? ProAylikSsk7 { get; set; }

    [Column("pro_aylik_gvmatrah7")]
    public double? ProAylikGvmatrah7 { get; set; }

    [Column("pro_aylik_gv7")]
    public double? ProAylikGv7 { get; set; }

    [Column("pro_aylik_dvmatrah7")]
    public double? ProAylikDvmatrah7 { get; set; }

    [Column("pro_aylik_dv7")]
    public double? ProAylikDv7 { get; set; }

    [Column("pro_aylik_konutfn7")]
    public double? ProAylikKonutfn7 { get; set; }

    [Column("pro_aylik_kaz7")]
    public double? ProAylikKaz7 { get; set; }

    [Column("pro_aylik_ekkaz7")]
    public double? ProAylikEkkaz7 { get; set; }

    [Column("pro_aylik_sosyardim7")]
    public double? ProAylikSosyardim7 { get; set; }

    [Column("pro_aylik_kesinti7")]
    public double? ProAylikKesinti7 { get; set; }

    [Column("pro_aylik_netto7")]
    public double? ProAylikNetto7 { get; set; }

    [Column("pro_aylik_v_iade7")]
    public double? ProAylikVIade7 { get; set; }

    [Column("pro_aylik_sosyrdkid7")]
    public double? ProAylikSosyrdkid7 { get; set; }

    [Column("pro_aylik_issigmat7")]
    public double? ProAylikIssigmat7 { get; set; }

    [Column("pro_aylik_issigper7")]
    public double? ProAylikIssigper7 { get; set; }

    [Column("pro_aylik_issigisv7")]
    public double? ProAylikIssigisv7 { get; set; }

    [Column("pro_aylik_issig7")]
    public double? ProAylikIssig7 { get; set; }

    [Column("pro_aylik_sskisv7")]
    public double? ProAylikSskisv7 { get; set; }

    [Column("pro_aylik_asgarigecind7")]
    public double? ProAylikAsgarigecind7 { get; set; }

    [Column("pro_sonrayadevirsskmatrahi7")]
    public double? ProSonrayadevirsskmatrahi7 { get; set; }

    [Column("pro_gecenaylardankullanilanssk7")]
    public double? ProGecenaylardankullanilanssk7 { get; set; }

    [Column("pro_bagkurprimi7")]
    public double? ProBagkurprimi7 { get; set; }

    [Column("pro_aylik_sskgun8")]
    public short? ProAylikSskgun8 { get; set; }

    [Column("pro_aylik_sskkaz8")]
    public double? ProAylikSskkaz8 { get; set; }

    [Column("pro_aylik_ssk8")]
    public double? ProAylikSsk8 { get; set; }

    [Column("pro_aylik_gvmatrah8")]
    public double? ProAylikGvmatrah8 { get; set; }

    [Column("pro_aylik_gv8")]
    public double? ProAylikGv8 { get; set; }

    [Column("pro_aylik_dvmatrah8")]
    public double? ProAylikDvmatrah8 { get; set; }

    [Column("pro_aylik_dv8")]
    public double? ProAylikDv8 { get; set; }

    [Column("pro_aylik_konutfn8")]
    public double? ProAylikKonutfn8 { get; set; }

    [Column("pro_aylik_kaz8")]
    public double? ProAylikKaz8 { get; set; }

    [Column("pro_aylik_ekkaz8")]
    public double? ProAylikEkkaz8 { get; set; }

    [Column("pro_aylik_sosyardim8")]
    public double? ProAylikSosyardim8 { get; set; }

    [Column("pro_aylik_kesinti8")]
    public double? ProAylikKesinti8 { get; set; }

    [Column("pro_aylik_netto8")]
    public double? ProAylikNetto8 { get; set; }

    [Column("pro_aylik_v_iade8")]
    public double? ProAylikVIade8 { get; set; }

    [Column("pro_aylik_sosyrdkid8")]
    public double? ProAylikSosyrdkid8 { get; set; }

    [Column("pro_aylik_issigmat8")]
    public double? ProAylikIssigmat8 { get; set; }

    [Column("pro_aylik_issigper8")]
    public double? ProAylikIssigper8 { get; set; }

    [Column("pro_aylik_issigisv8")]
    public double? ProAylikIssigisv8 { get; set; }

    [Column("pro_aylik_issig8")]
    public double? ProAylikIssig8 { get; set; }

    [Column("pro_aylik_sskisv8")]
    public double? ProAylikSskisv8 { get; set; }

    [Column("pro_aylik_asgarigecind8")]
    public double? ProAylikAsgarigecind8 { get; set; }

    [Column("pro_sonrayadevirsskmatrahi8")]
    public double? ProSonrayadevirsskmatrahi8 { get; set; }

    [Column("pro_gecenaylardankullanilanssk8")]
    public double? ProGecenaylardankullanilanssk8 { get; set; }

    [Column("pro_bagkurprimi8")]
    public double? ProBagkurprimi8 { get; set; }

    [Column("pro_aylik_sskgun9")]
    public short? ProAylikSskgun9 { get; set; }

    [Column("pro_aylik_sskkaz9")]
    public double? ProAylikSskkaz9 { get; set; }

    [Column("pro_aylik_ssk9")]
    public double? ProAylikSsk9 { get; set; }

    [Column("pro_aylik_gvmatrah9")]
    public double? ProAylikGvmatrah9 { get; set; }

    [Column("pro_aylik_gv9")]
    public double? ProAylikGv9 { get; set; }

    [Column("pro_aylik_dvmatrah9")]
    public double? ProAylikDvmatrah9 { get; set; }

    [Column("pro_aylik_dv9")]
    public double? ProAylikDv9 { get; set; }

    [Column("pro_aylik_konutfn9")]
    public double? ProAylikKonutfn9 { get; set; }

    [Column("pro_aylik_kaz9")]
    public double? ProAylikKaz9 { get; set; }

    [Column("pro_aylik_ekkaz9")]
    public double? ProAylikEkkaz9 { get; set; }

    [Column("pro_aylik_sosyardim9")]
    public double? ProAylikSosyardim9 { get; set; }

    [Column("pro_aylik_kesinti9")]
    public double? ProAylikKesinti9 { get; set; }

    [Column("pro_aylik_netto9")]
    public double? ProAylikNetto9 { get; set; }

    [Column("pro_aylik_v_iade9")]
    public double? ProAylikVIade9 { get; set; }

    [Column("pro_aylik_sosyrdkid9")]
    public double? ProAylikSosyrdkid9 { get; set; }

    [Column("pro_aylik_issigmat9")]
    public double? ProAylikIssigmat9 { get; set; }

    [Column("pro_aylik_issigper9")]
    public double? ProAylikIssigper9 { get; set; }

    [Column("pro_aylik_issigisv9")]
    public double? ProAylikIssigisv9 { get; set; }

    [Column("pro_aylik_issig9")]
    public double? ProAylikIssig9 { get; set; }

    [Column("pro_aylik_sskisv9")]
    public double? ProAylikSskisv9 { get; set; }

    [Column("pro_aylik_asgarigecind9")]
    public double? ProAylikAsgarigecind9 { get; set; }

    [Column("pro_sonrayadevirsskmatrahi9")]
    public double? ProSonrayadevirsskmatrahi9 { get; set; }

    [Column("pro_gecenaylardankullanilanssk9")]
    public double? ProGecenaylardankullanilanssk9 { get; set; }

    [Column("pro_bagkurprimi9")]
    public double? ProBagkurprimi9 { get; set; }

    [Column("pro_aylik_sskgun10")]
    public short? ProAylikSskgun10 { get; set; }

    [Column("pro_aylik_sskkaz10")]
    public double? ProAylikSskkaz10 { get; set; }

    [Column("pro_aylik_ssk10")]
    public double? ProAylikSsk10 { get; set; }

    [Column("pro_aylik_gvmatrah10")]
    public double? ProAylikGvmatrah10 { get; set; }

    [Column("pro_aylik_gv10")]
    public double? ProAylikGv10 { get; set; }

    [Column("pro_aylik_dvmatrah10")]
    public double? ProAylikDvmatrah10 { get; set; }

    [Column("pro_aylik_dv10")]
    public double? ProAylikDv10 { get; set; }

    [Column("pro_aylik_konutfn10")]
    public double? ProAylikKonutfn10 { get; set; }

    [Column("pro_aylik_kaz10")]
    public double? ProAylikKaz10 { get; set; }

    [Column("pro_aylik_ekkaz10")]
    public double? ProAylikEkkaz10 { get; set; }

    [Column("pro_aylik_sosyrd10")]
    public double? ProAylikSosyrd10 { get; set; }

    [Column("pro_aylik_kesinti10")]
    public double? ProAylikKesinti10 { get; set; }

    [Column("pro_aylik_netto10")]
    public double? ProAylikNetto10 { get; set; }

    [Column("pro_aylik_v_iade10")]
    public double? ProAylikVIade10 { get; set; }

    [Column("pro_aylik_syrdkid10")]
    public double? ProAylikSyrdkid10 { get; set; }

    [Column("pro_aylik_issigmat10")]
    public double? ProAylikIssigmat10 { get; set; }

    [Column("pro_aylik_issigper10")]
    public double? ProAylikIssigper10 { get; set; }

    [Column("pro_aylik_issigisv10")]
    public double? ProAylikIssigisv10 { get; set; }

    [Column("pro_aylik_issig10")]
    public double? ProAylikIssig10 { get; set; }

    [Column("pro_aylik_sskisv10")]
    public double? ProAylikSskisv10 { get; set; }

    [Column("pro_aylik_asgarigecind10")]
    public double? ProAylikAsgarigecind10 { get; set; }

    [Column("pro_sonrayadevirsskmatrahi10")]
    public double? ProSonrayadevirsskmatrahi10 { get; set; }

    [Column("pro_gecenaylardankullanilanssk10")]
    public double? ProGecenaylardankullanilanssk10 { get; set; }

    [Column("pro_bagkurprimi10")]
    public double? ProBagkurprimi10 { get; set; }

    [Column("pro_aylik_sskgun11")]
    public short? ProAylikSskgun11 { get; set; }

    [Column("pro_aylik_sskkaz11")]
    public double? ProAylikSskkaz11 { get; set; }

    [Column("pro_aylik_ssk11")]
    public double? ProAylikSsk11 { get; set; }

    [Column("pro_aylik_gvmatrah11")]
    public double? ProAylikGvmatrah11 { get; set; }

    [Column("pro_aylik_gv11")]
    public double? ProAylikGv11 { get; set; }

    [Column("pro_aylik_dvmatrah11")]
    public double? ProAylikDvmatrah11 { get; set; }

    [Column("pro_aylik_dv11")]
    public double? ProAylikDv11 { get; set; }

    [Column("pro_aylik_konutfn11")]
    public double? ProAylikKonutfn11 { get; set; }

    [Column("pro_aylik_kaz11")]
    public double? ProAylikKaz11 { get; set; }

    [Column("pro_aylik_ekkaz11")]
    public double? ProAylikEkkaz11 { get; set; }

    [Column("pro_aylik_sosyrd11")]
    public double? ProAylikSosyrd11 { get; set; }

    [Column("pro_aylik_kesinti11")]
    public double? ProAylikKesinti11 { get; set; }

    [Column("pro_aylik_netto11")]
    public double? ProAylikNetto11 { get; set; }

    [Column("pro_aylik_v_iade11")]
    public double? ProAylikVIade11 { get; set; }

    [Column("pro_aylik_syrdkid11")]
    public double? ProAylikSyrdkid11 { get; set; }

    [Column("pro_aylik_issigmat11")]
    public double? ProAylikIssigmat11 { get; set; }

    [Column("pro_aylik_issigper11")]
    public double? ProAylikIssigper11 { get; set; }

    [Column("pro_aylik_issigisv11")]
    public double? ProAylikIssigisv11 { get; set; }

    [Column("pro_aylik_issig11")]
    public double? ProAylikIssig11 { get; set; }

    [Column("pro_aylik_sskisv11")]
    public double? ProAylikSskisv11 { get; set; }

    [Column("pro_aylik_asgarigecind11")]
    public double? ProAylikAsgarigecind11 { get; set; }

    [Column("pro_sonrayadevirsskmatrahi11")]
    public double? ProSonrayadevirsskmatrahi11 { get; set; }

    [Column("pro_gecenaylardankullanilanssk11")]
    public double? ProGecenaylardankullanilanssk11 { get; set; }

    [Column("pro_bagkurprimi11")]
    public double? ProBagkurprimi11 { get; set; }

    [Column("pro_aylik_sskgun12")]
    public short? ProAylikSskgun12 { get; set; }

    [Column("pro_aylik_sskkaz12")]
    public double? ProAylikSskkaz12 { get; set; }

    [Column("pro_aylik_ssk12")]
    public double? ProAylikSsk12 { get; set; }

    [Column("pro_aylik_gvmatrah12")]
    public double? ProAylikGvmatrah12 { get; set; }

    [Column("pro_aylik_gv12")]
    public double? ProAylikGv12 { get; set; }

    [Column("pro_aylik_dvmatrah12")]
    public double? ProAylikDvmatrah12 { get; set; }

    [Column("pro_aylik_dv12")]
    public double? ProAylikDv12 { get; set; }

    [Column("pro_aylik_konutfn12")]
    public double? ProAylikKonutfn12 { get; set; }

    [Column("pro_aylik_kaz12")]
    public double? ProAylikKaz12 { get; set; }

    [Column("pro_aylik_ekkaz12")]
    public double? ProAylikEkkaz12 { get; set; }

    [Column("pro_aylik_sosyrd12")]
    public double? ProAylikSosyrd12 { get; set; }

    [Column("pro_aylik_kesinti12")]
    public double? ProAylikKesinti12 { get; set; }

    [Column("pro_aylik_netto12")]
    public double? ProAylikNetto12 { get; set; }

    [Column("pro_aylik_v_iade12")]
    public double? ProAylikVIade12 { get; set; }

    [Column("pro_aylik_syrdkid12")]
    public double? ProAylikSyrdkid12 { get; set; }

    [Column("pro_aylik_issigmat12")]
    public double? ProAylikIssigmat12 { get; set; }

    [Column("pro_aylik_issigper12")]
    public double? ProAylikIssigper12 { get; set; }

    [Column("pro_aylik_issigisv12")]
    public double? ProAylikIssigisv12 { get; set; }

    [Column("pro_aylik_issig12")]
    public double? ProAylikIssig12 { get; set; }

    [Column("pro_aylik_sskisv12")]
    public double? ProAylikSskisv12 { get; set; }

    [Column("pro_aylik_asgarigecind12")]
    public double? ProAylikAsgarigecind12 { get; set; }

    [Column("pro_sonrayadevirsskmatrahi12")]
    public double? ProSonrayadevirsskmatrahi12 { get; set; }

    [Column("pro_gecenaylardankullanilanssk12")]
    public double? ProGecenaylardankullanilanssk12 { get; set; }

    [Column("pro_bagkurprimi12")]
    public double? ProBagkurprimi12 { get; set; }

    [Column("pro_onceki_hakedis")]
    public DateTime? ProOncekiHakedis { get; set; }

    [Column("pro_izin_hakedis")]
    public DateTime? ProIzinHakedis { get; set; }

    [Column("pro_evrak_top")]
    public double? ProEvrakTop { get; set; }

    [Column("pro_ikramiye")]
    public double? ProIkramiye { get; set; }

    [Column("pro_brut")]
    public double? ProBrut { get; set; }

    [Column("pro_gec_yil_kum")]
    public double? ProGecYilKum { get; set; }

    [Column("pro_gec_yil_sonvergi")]
    public double? ProGecYilSonvergi { get; set; }

    [Column("pro_digersig_isveren")]
    public double? ProDigersigIsveren { get; set; }

    [Column("pro_digersig_isveren2")]
    public double? ProDigersigIsveren2 { get; set; }

    [Column("pro_digersig_isveren3")]
    public double? ProDigersigIsveren3 { get; set; }

    [Column("pro_digersig_isveren4")]
    public double? ProDigersigIsveren4 { get; set; }

    [Column("pro_digersig_isveren5")]
    public double? ProDigersigIsveren5 { get; set; }

    [Column("pro_digersig_isveren6")]
    public double? ProDigersigIsveren6 { get; set; }

    [Column("pro_digersig_isveren7")]
    public double? ProDigersigIsveren7 { get; set; }

    [Column("pro_digersig_isveren8")]
    public double? ProDigersigIsveren8 { get; set; }

    [Column("pro_digersig_isveren9")]
    public double? ProDigersigIsveren9 { get; set; }

    [Column("pro_digersig_isveren10")]
    public double? ProDigersigIsveren10 { get; set; }

    [Column("pro_digersig_isveren11")]
    public double? ProDigersigIsveren11 { get; set; }

    [Column("pro_digersig_isveren12")]
    public double? ProDigersigIsveren12 { get; set; }

    [Column("pro_digersig_calisan")]
    public double? ProDigersigCalisan { get; set; }

    [Column("pro_digersig_calisan2")]
    public double? ProDigersigCalisan2 { get; set; }

    [Column("pro_digersig_calisan3")]
    public double? ProDigersigCalisan3 { get; set; }

    [Column("pro_digersig_calisan4")]
    public double? ProDigersigCalisan4 { get; set; }

    [Column("pro_digersig_calisan5")]
    public double? ProDigersigCalisan5 { get; set; }

    [Column("pro_digersig_calisan6")]
    public double? ProDigersigCalisan6 { get; set; }

    [Column("pro_digersig_calisan7")]
    public double? ProDigersigCalisan7 { get; set; }

    [Column("pro_digersig_calisan8")]
    public double? ProDigersigCalisan8 { get; set; }

    [Column("pro_digersig_calisan9")]
    public double? ProDigersigCalisan9 { get; set; }

    [Column("pro_digersig_calisan10")]
    public double? ProDigersigCalisan10 { get; set; }

    [Column("pro_digersig_calisan11")]
    public double? ProDigersigCalisan11 { get; set; }

    [Column("pro_digersig_calisan12")]
    public double? ProDigersigCalisan12 { get; set; }

    [Column("pro_bireyselsig_isveren")]
    public double? ProBireyselsigIsveren { get; set; }

    [Column("pro_bireyselsig_isveren2")]
    public double? ProBireyselsigIsveren2 { get; set; }

    [Column("pro_bireyselsig_isveren3")]
    public double? ProBireyselsigIsveren3 { get; set; }

    [Column("pro_bireyselsig_isveren4")]
    public double? ProBireyselsigIsveren4 { get; set; }

    [Column("pro_bireyselsig_isveren5")]
    public double? ProBireyselsigIsveren5 { get; set; }

    [Column("pro_bireyselsig_isveren6")]
    public double? ProBireyselsigIsveren6 { get; set; }

    [Column("pro_bireyselsig_isveren7")]
    public double? ProBireyselsigIsveren7 { get; set; }

    [Column("pro_bireyselsig_isveren8")]
    public double? ProBireyselsigIsveren8 { get; set; }

    [Column("pro_bireyselsig_isveren9")]
    public double? ProBireyselsigIsveren9 { get; set; }

    [Column("pro_bireyselsig_isveren10")]
    public double? ProBireyselsigIsveren10 { get; set; }

    [Column("pro_bireyselsig_isveren11")]
    public double? ProBireyselsigIsveren11 { get; set; }

    [Column("pro_bireyselsig_isveren12")]
    public double? ProBireyselsigIsveren12 { get; set; }

    [Column("pro_bireyselsig_calisan")]
    public double? ProBireyselsigCalisan { get; set; }

    [Column("pro_bireyselsig_calisan2")]
    public double? ProBireyselsigCalisan2 { get; set; }

    [Column("pro_bireyselsig_calisan3")]
    public double? ProBireyselsigCalisan3 { get; set; }

    [Column("pro_bireyselsig_calisan4")]
    public double? ProBireyselsigCalisan4 { get; set; }

    [Column("pro_bireyselsig_calisan5")]
    public double? ProBireyselsigCalisan5 { get; set; }

    [Column("pro_bireyselsig_calisan6")]
    public double? ProBireyselsigCalisan6 { get; set; }

    [Column("pro_bireyselsig_calisan7")]
    public double? ProBireyselsigCalisan7 { get; set; }

    [Column("pro_bireyselsig_calisan8")]
    public double? ProBireyselsigCalisan8 { get; set; }

    [Column("pro_bireyselsig_calisan9")]
    public double? ProBireyselsigCalisan9 { get; set; }

    [Column("pro_bireyselsig_calisan10")]
    public double? ProBireyselsigCalisan10 { get; set; }

    [Column("pro_bireyselsig_calisan11")]
    public double? ProBireyselsigCalisan11 { get; set; }

    [Column("pro_bireyselsig_calisan12")]
    public double? ProBireyselsigCalisan12 { get; set; }

    [Column("pro_devirdigsigorta_isveren")]
    public double? ProDevirdigsigortaIsveren { get; set; }

    [Column("pro_devirdigsigorta_calisan")]
    public double? ProDevirdigsigortaCalisan { get; set; }

    [Column("pro_devirbireysig_isveren")]
    public double? ProDevirbireysigIsveren { get; set; }

    [Column("pro_devirbireysig_calisan")]
    public double? ProDevirbireysigCalisan { get; set; }

    [Column("pro_police_tarihi_yeni_fl")]
    public bool? ProPoliceTarihiYeniFl { get; set; }

    [Column("pro_PTTFDvrTutar")]
    public double? ProPTTFDvrTutar { get; set; }

    [Column("pro_PTTFDvrTar")]
    public DateTime? ProPTTFDvrTar { get; set; }

    [Column("pro_PissigDvrTutar")]
    public double? ProPissigDvrTutar { get; set; }

    [Column("pro_PissigDvrTar")]
    public DateTime? ProPissigDvrTar { get; set; }

    [Column("pro_viziteSayac")]
    public short? ProViziteSayac { get; set; }

    [Column("pro_dig_kesinti1")]
    public double? ProDigKesinti1 { get; set; }

    [Column("pro_dig_taksit1")]
    public double? ProDigTaksit1 { get; set; }

    [Column("pro_dig_kesinti2")]
    public double? ProDigKesinti2 { get; set; }

    [Column("pro_dig_taksit2")]
    public double? ProDigTaksit2 { get; set; }

    [Column("pro_dig_kesinti3")]
    public double? ProDigKesinti3 { get; set; }

    [Column("pro_dig_taksit3")]
    public double? ProDigTaksit3 { get; set; }

    [Column("pro_dig_kesinti4")]
    public double? ProDigKesinti4 { get; set; }

    [Column("pro_dig_taksit4")]
    public double? ProDigTaksit4 { get; set; }

    [Column("pro_dig_kesinti5")]
    public double? ProDigKesinti5 { get; set; }

    [Column("pro_dig_taksit5")]
    public double? ProDigTaksit5 { get; set; }

    [Column("pro_dig_kesinti6")]
    public double? ProDigKesinti6 { get; set; }

    [Column("pro_dig_taksit6")]
    public double? ProDigTaksit6 { get; set; }

    [Column("pro_per_ayni_odeme")]
    public double? ProPerAyniOdeme { get; set; }

    [Column("pro_per_ayni_odeme_var_fl")]
    public bool? ProPerAyniOdemeVarFl { get; set; }

    [Column("pro_per_asker_borc")]
    public double? ProPerAskerBorc { get; set; }

    [Column("pro_per_asker_borc_taksit")]
    public double? ProPerAskerBorcTaksit { get; set; }

    [Column("pro_asker_kendisi_ode_fl")]
    public bool? ProAskerKendisiOdeFl { get; set; }

    [Column("pro_gecyil_devir_izin")]
    public short? ProGecyilDevirIzin { get; set; }

    [Column("pro_devreden_sinyority_gunu")]
    public short? ProDevredenSinyorityGunu { get; set; }

    [Column("pro_devreden_izin_parasi_gunu")]
    public short? ProDevredenIzinParasiGunu { get; set; }

    [Column("pro_ufrs_izin_gunu_hakki")]
    public short? ProUfrsIzinGunuHakki { get; set; }

    [Column("pro_ufrs_izin_ucreti")]
    public double? ProUfrsIzinUcreti { get; set; }

    [Column("pro_ufrs_kidem_tazminati")]
    public double? ProUfrsKidemTazminati { get; set; }

    [Column("pro_sgkpriminetabiikazanc1")]
    public double? ProSgkpriminetabiikazanc1 { get; set; }

    [Column("pro_sgkpriminetabiiekkazanc1")]
    public double? ProSgkpriminetabiiekkazanc1 { get; set; }

    [Column("pro_sgkpriminetabiisosyalyardim1")]
    public double? ProSgkpriminetabiisosyalyardim1 { get; set; }

    [Column("pro_sgkpriminetabiikazanc2")]
    public double? ProSgkpriminetabiikazanc2 { get; set; }

    [Column("pro_sgkpriminetabiiekkazanc2")]
    public double? ProSgkpriminetabiiekkazanc2 { get; set; }

    [Column("pro_sgkpriminetabiisosyalyardim2")]
    public double? ProSgkpriminetabiisosyalyardim2 { get; set; }

    [Column("pro_sgkpriminetabiikazanc3")]
    public double? ProSgkpriminetabiikazanc3 { get; set; }

    [Column("pro_sgkpriminetabiiekkazanc3")]
    public double? ProSgkpriminetabiiekkazanc3 { get; set; }

    [Column("pro_sgkpriminetabiisosyalyardim3")]
    public double? ProSgkpriminetabiisosyalyardim3 { get; set; }

    [Column("pro_sgkpriminetabiikazanc4")]
    public double? ProSgkpriminetabiikazanc4 { get; set; }

    [Column("pro_sgkpriminetabiiekkazanc4")]
    public double? ProSgkpriminetabiiekkazanc4 { get; set; }

    [Column("pro_sgkpriminetabiisosyalyardim4")]
    public double? ProSgkpriminetabiisosyalyardim4 { get; set; }

    [Column("pro_sgkpriminetabiikazanc5")]
    public double? ProSgkpriminetabiikazanc5 { get; set; }

    [Column("pro_sgkpriminetabiiekkazanc5")]
    public double? ProSgkpriminetabiiekkazanc5 { get; set; }

    [Column("pro_sgkpriminetabiisosyalyardim5")]
    public double? ProSgkpriminetabiisosyalyardim5 { get; set; }

    [Column("pro_sgkpriminetabiikazanc6")]
    public double? ProSgkpriminetabiikazanc6 { get; set; }

    [Column("pro_sgkpriminetabiiekkazanc6")]
    public double? ProSgkpriminetabiiekkazanc6 { get; set; }

    [Column("pro_sgkpriminetabiisosyalyardim6")]
    public double? ProSgkpriminetabiisosyalyardim6 { get; set; }

    [Column("pro_sgkpriminetabiikazanc7")]
    public double? ProSgkpriminetabiikazanc7 { get; set; }

    [Column("pro_sgkpriminetabiiekkazanc7")]
    public double? ProSgkpriminetabiiekkazanc7 { get; set; }

    [Column("pro_sgkpriminetabiisosyalyardim7")]
    public double? ProSgkpriminetabiisosyalyardim7 { get; set; }

    [Column("pro_sgkpriminetabiikazanc8")]
    public double? ProSgkpriminetabiikazanc8 { get; set; }

    [Column("pro_sgkpriminetabiiekkazanc8")]
    public double? ProSgkpriminetabiiekkazanc8 { get; set; }

    [Column("pro_sgkpriminetabiisosyalyardim8")]
    public double? ProSgkpriminetabiisosyalyardim8 { get; set; }

    [Column("pro_sgkpriminetabiikazanc9")]
    public double? ProSgkpriminetabiikazanc9 { get; set; }

    [Column("pro_sgkpriminetabiiekkazanc9")]
    public double? ProSgkpriminetabiiekkazanc9 { get; set; }

    [Column("pro_sgkpriminetabiisosyalyardim9")]
    public double? ProSgkpriminetabiisosyalyardim9 { get; set; }

    [Column("pro_sgkpriminetabiikazanc10")]
    public double? ProSgkpriminetabiikazanc10 { get; set; }

    [Column("pro_sgkpriminetabiiekkazanc10")]
    public double? ProSgkpriminetabiiekkazanc10 { get; set; }

    [Column("pro_sgkpriminetabiisosyalyardim10")]
    public double? ProSgkpriminetabiisosyalyardim10 { get; set; }

    [Column("pro_sgkpriminetabiikazanc11")]
    public double? ProSgkpriminetabiikazanc11 { get; set; }

    [Column("pro_sgkpriminetabiiekkazanc11")]
    public double? ProSgkpriminetabiiekkazanc11 { get; set; }

    [Column("pro_sgkpriminetabiisosyalyardim11")]
    public double? ProSgkpriminetabiisosyalyardim11 { get; set; }

    [Column("pro_sgkpriminetabiikazanc12")]
    public double? ProSgkpriminetabiikazanc12 { get; set; }

    [Column("pro_sgkpriminetabiiekkazanc12")]
    public double? ProSgkpriminetabiiekkazanc12 { get; set; }

    [Column("pro_sgkpriminetabiisosyalyardim12")]
    public double? ProSgkpriminetabiisosyalyardim12 { get; set; }

    [Column("pro_hayatsig_isveren1")]
    public double? ProHayatsigIsveren1 { get; set; }

    [Column("pro_hayatsig_isveren2")]
    public double? ProHayatsigIsveren2 { get; set; }

    [Column("pro_hayatsig_isveren3")]
    public double? ProHayatsigIsveren3 { get; set; }

    [Column("pro_hayatsig_isveren4")]
    public double? ProHayatsigIsveren4 { get; set; }

    [Column("pro_hayatsig_isveren5")]
    public double? ProHayatsigIsveren5 { get; set; }

    [Column("pro_hayatsig_isveren6")]
    public double? ProHayatsigIsveren6 { get; set; }

    [Column("pro_hayatsig_isveren7")]
    public double? ProHayatsigIsveren7 { get; set; }

    [Column("pro_hayatsig_isveren8")]
    public double? ProHayatsigIsveren8 { get; set; }

    [Column("pro_hayatsig_isveren9")]
    public double? ProHayatsigIsveren9 { get; set; }

    [Column("pro_hayatsig_isveren10")]
    public double? ProHayatsigIsveren10 { get; set; }

    [Column("pro_hayatsig_isveren11")]
    public double? ProHayatsigIsveren11 { get; set; }

    [Column("pro_hayatsig_isveren12")]
    public double? ProHayatsigIsveren12 { get; set; }

    [Column("pro_hayatsig_calisan1")]
    public double? ProHayatsigCalisan1 { get; set; }

    [Column("pro_hayatsig_calisan2")]
    public double? ProHayatsigCalisan2 { get; set; }

    [Column("pro_hayatsig_calisan3")]
    public double? ProHayatsigCalisan3 { get; set; }

    [Column("pro_hayatsig_calisan4")]
    public double? ProHayatsigCalisan4 { get; set; }

    [Column("pro_hayatsig_calisan5")]
    public double? ProHayatsigCalisan5 { get; set; }

    [Column("pro_hayatsig_calisan6")]
    public double? ProHayatsigCalisan6 { get; set; }

    [Column("pro_hayatsig_calisan7")]
    public double? ProHayatsigCalisan7 { get; set; }

    [Column("pro_hayatsig_calisan8")]
    public double? ProHayatsigCalisan8 { get; set; }

    [Column("pro_hayatsig_calisan9")]
    public double? ProHayatsigCalisan9 { get; set; }

    [Column("pro_hayatsig_calisan10")]
    public double? ProHayatsigCalisan10 { get; set; }

    [Column("pro_hayatsig_calisan11")]
    public double? ProHayatsigCalisan11 { get; set; }

    [Column("pro_hayatsig_calisan12")]
    public double? ProHayatsigCalisan12 { get; set; }

    [Column("pro_devirhayatsigorta_isveren")]
    public double? ProDevirhayatsigortaIsveren { get; set; }

    [Column("pro_devirhayatsigorta_calisan")]
    public double? ProDevirhayatsigortaCalisan { get; set; }

    [Column("pro_otobes1")]
    public double? ProOtobes1 { get; set; }

    [Column("pro_otobes2")]
    public double? ProOtobes2 { get; set; }

    [Column("pro_otobes3")]
    public double? ProOtobes3 { get; set; }

    [Column("pro_otobes4")]
    public double? ProOtobes4 { get; set; }

    [Column("pro_otobes5")]
    public double? ProOtobes5 { get; set; }

    [Column("pro_otobes6")]
    public double? ProOtobes6 { get; set; }

    [Column("pro_otobes7")]
    public double? ProOtobes7 { get; set; }

    [Column("pro_otobes8")]
    public double? ProOtobes8 { get; set; }

    [Column("pro_otobes9")]
    public double? ProOtobes9 { get; set; }

    [Column("pro_otobes10")]
    public double? ProOtobes10 { get; set; }

    [Column("pro_otobes11")]
    public double? ProOtobes11 { get; set; }

    [Column("pro_otobes12")]
    public double? ProOtobes12 { get; set; }
}
