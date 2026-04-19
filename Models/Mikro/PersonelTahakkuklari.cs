using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("personel_tahakkuklari")]
public class PersonelTahakkuklari
{
    [Column("pt_Guid")]
    public Guid? PtGuid { get; set; }

    [Column("pt_DBCno")]
    public short? PtDBCno { get; set; }

    [Column("pt_SpecRECno")]
    public int? PtSpecRECno { get; set; }

    [Column("pt_iptal")]
    public bool? PtIptal { get; set; }

    [Column("pt_fileid")]
    public short? PtFileid { get; set; }

    [Column("pt_hidden")]
    public bool? PtHidden { get; set; }

    [Column("pt_kilitli")]
    public bool? PtKilitli { get; set; }

    [Column("pt_degisti")]
    public bool? PtDegisti { get; set; }

    [Column("pt_checksum")]
    public int? PtChecksum { get; set; }

    [Column("pt_create_user")]
    public short? PtCreateUser { get; set; }

    [Column("pt_create_date")]
    public DateTime? PtCreateDate { get; set; }

    [Column("pt_lastup_user")]
    public short? PtLastupUser { get; set; }

    [Column("pt_lastup_date")]
    public DateTime? PtLastupDate { get; set; }

    [Column("pt_special1")]
    [StringLength(4)]
    public string? PtSpecial1 { get; set; }

    [Column("pt_special2")]
    [StringLength(4)]
    public string? PtSpecial2 { get; set; }

    [Column("pt_special3")]
    [StringLength(4)]
    public string? PtSpecial3 { get; set; }

    [Column("pt_pkod")]
    [StringLength(25)]
    public string? PtPkod { get; set; }

    [Column("pt_maliyil")]
    public int? PtMaliyil { get; set; }

    [Column("pt_tah_ay")]
    public short? PtTahAy { get; set; }

    [Column("pt_tahno")]
    public short? PtTahno { get; set; }

    [Column("pt_kayit")]
    public short? PtKayit { get; set; }

    [Column("pt_kesin")]
    public bool? PtKesin { get; set; }

    [Column("pt_ucrettipi")]
    public byte? PtUcrettipi { get; set; }

    [Column("pt_brutucret")]
    public double? PtBrutucret { get; set; }

    [Column("pt_kazanc1_tkgun")]
    public short? PtKazanc1Tkgun { get; set; }

    [Column("pt_kazanc1_tksaat")]
    public double? PtKazanc1Tksaat { get; set; }

    [Column("pt_kazanc1_tkyarim_isgunu")]
    public short? PtKazanc1TkyarimIsgunu { get; set; }

    [Column("pt_kazanc1_tkyarim_isgun_saat")]
    public double? PtKazanc1TkyarimIsgunSaat { get; set; }

    [Column("pt_kazanc1_tktutar")]
    public double? PtKazanc1Tktutar { get; set; }

    [Column("pt_kazanc2_tkgun")]
    public short? PtKazanc2Tkgun { get; set; }

    [Column("pt_kazanc2_tksaat")]
    public double? PtKazanc2Tksaat { get; set; }

    [Column("pt_kazanc2_tkyarim_isgunu")]
    public short? PtKazanc2TkyarimIsgunu { get; set; }

    [Column("pt_kazanc2_tkyarim_isgun_saat")]
    public double? PtKazanc2TkyarimIsgunSaat { get; set; }

    [Column("pt_kazanc2_tktutar")]
    public double? PtKazanc2Tktutar { get; set; }

    [Column("pt_kazanc3_tkgun")]
    public short? PtKazanc3Tkgun { get; set; }

    [Column("pt_kazanc3_tksaat")]
    public double? PtKazanc3Tksaat { get; set; }

    [Column("pt_kazanc3_tkyarim_isgunu")]
    public short? PtKazanc3TkyarimIsgunu { get; set; }

    [Column("pt_kazanc3_tkyarim_isgun_saat")]
    public double? PtKazanc3TkyarimIsgunSaat { get; set; }

    [Column("pt_kazanc3_tktutar")]
    public double? PtKazanc3Tktutar { get; set; }

    [Column("pt_kazanc4_tkgun")]
    public short? PtKazanc4Tkgun { get; set; }

    [Column("pt_kazanc4_tksaat")]
    public double? PtKazanc4Tksaat { get; set; }

    [Column("pt_kazanc4_tkyarim_isgunu")]
    public short? PtKazanc4TkyarimIsgunu { get; set; }

    [Column("pt_kazanc4_tkyarim_isgun_saat")]
    public double? PtKazanc4TkyarimIsgunSaat { get; set; }

    [Column("pt_kazanc4_tktutar")]
    public double? PtKazanc4Tktutar { get; set; }

    [Column("pt_kazanc5_tkgun")]
    public short? PtKazanc5Tkgun { get; set; }

    [Column("pt_kazanc5_tksaat")]
    public double? PtKazanc5Tksaat { get; set; }

    [Column("pt_kazanc5_tkyarim_isgunu")]
    public short? PtKazanc5TkyarimIsgunu { get; set; }

    [Column("pt_kazanc5_tkyarim_isgun_saat")]
    public double? PtKazanc5TkyarimIsgunSaat { get; set; }

    [Column("pt_kazanc5_tktutar")]
    public double? PtKazanc5Tktutar { get; set; }

    [Column("pt_kazanc6_tkgun")]
    public short? PtKazanc6Tkgun { get; set; }

    [Column("pt_kazanc6_tksaat")]
    public double? PtKazanc6Tksaat { get; set; }

    [Column("pt_kazanc6_tkyarim_isgunu")]
    public short? PtKazanc6TkyarimIsgunu { get; set; }

    [Column("pt_kazanc6_tkyarim_isgun_saat")]
    public double? PtKazanc6TkyarimIsgunSaat { get; set; }

    [Column("pt_kazanc6_tktutar")]
    public double? PtKazanc6Tktutar { get; set; }

    [Column("pt_KazancBNCarpan")]
    public double? PtKazancBNCarpan { get; set; }

    [Column("pt_ekkazanc1_tkgun")]
    public short? PtEkkazanc1Tkgun { get; set; }

    [Column("pt_ekkazanc1_tksaat")]
    public double? PtEkkazanc1Tksaat { get; set; }

    [Column("pt_ekkazanc1_tktutar")]
    public double? PtEkkazanc1Tktutar { get; set; }

    [Column("pt_ekkazanc2_tkgun")]
    public short? PtEkkazanc2Tkgun { get; set; }

    [Column("pt_ekkazanc2_tksaat")]
    public double? PtEkkazanc2Tksaat { get; set; }

    [Column("pt_ekkazanc2_tktutar")]
    public double? PtEkkazanc2Tktutar { get; set; }

    [Column("pt_ekkazanc3_tkgun")]
    public short? PtEkkazanc3Tkgun { get; set; }

    [Column("pt_ekkazanc3_tksaat")]
    public double? PtEkkazanc3Tksaat { get; set; }

    [Column("pt_ekkazanc3_tktutar")]
    public double? PtEkkazanc3Tktutar { get; set; }

    [Column("pt_ekkazanc4_tkgun")]
    public short? PtEkkazanc4Tkgun { get; set; }

    [Column("pt_ekkazanc4_tksaat")]
    public double? PtEkkazanc4Tksaat { get; set; }

    [Column("pt_ekkazanc4_tktutar")]
    public double? PtEkkazanc4Tktutar { get; set; }

    [Column("pt_ekkazanc5_tkgun")]
    public short? PtEkkazanc5Tkgun { get; set; }

    [Column("pt_ekkazanc5_tksaat")]
    public double? PtEkkazanc5Tksaat { get; set; }

    [Column("pt_ekkazanc5_tktutar")]
    public double? PtEkkazanc5Tktutar { get; set; }

    [Column("pt_ekkazanc6_tkgun")]
    public short? PtEkkazanc6Tkgun { get; set; }

    [Column("pt_ekkazanc6_tksaat")]
    public double? PtEkkazanc6Tksaat { get; set; }

    [Column("pt_ekkazanc6_tktutar")]
    public double? PtEkkazanc6Tktutar { get; set; }

    [Column("pt_ekkazanc7_tkgun")]
    public short? PtEkkazanc7Tkgun { get; set; }

    [Column("pt_ekkazanc7_tksaat")]
    public double? PtEkkazanc7Tksaat { get; set; }

    [Column("pt_ekkazanc7_tktutar")]
    public double? PtEkkazanc7Tktutar { get; set; }

    [Column("pt_ekkazanc8_tkgun")]
    public short? PtEkkazanc8Tkgun { get; set; }

    [Column("pt_ekkazanc8_tksaat")]
    public double? PtEkkazanc8Tksaat { get; set; }

    [Column("pt_ekkazanc8_tktutar")]
    public double? PtEkkazanc8Tktutar { get; set; }

    [Column("pt_ekkazanc9_tkgun")]
    public short? PtEkkazanc9Tkgun { get; set; }

    [Column("pt_ekkazanc9_tksaat")]
    public double? PtEkkazanc9Tksaat { get; set; }

    [Column("pt_ekkazanc9_tktutar")]
    public double? PtEkkazanc9Tktutar { get; set; }

    [Column("pt_ekkazanc10_tkgun")]
    public short? PtEkkazanc10Tkgun { get; set; }

    [Column("pt_ekkazanc10_tksaat")]
    public double? PtEkkazanc10Tksaat { get; set; }

    [Column("pt_ekkazanc10_tktutar")]
    public double? PtEkkazanc10Tktutar { get; set; }

    [Column("pt_ekkazanc11_tkgun")]
    public short? PtEkkazanc11Tkgun { get; set; }

    [Column("pt_ekkazanc11_tksaat")]
    public double? PtEkkazanc11Tksaat { get; set; }

    [Column("pt_ekkazanc11_tktutar")]
    public double? PtEkkazanc11Tktutar { get; set; }

    [Column("pt_EkKazancBNCarpan1")]
    public double? PtEkKazancBNCarpan1 { get; set; }

    [Column("pt_EkKazancBNCarpan2")]
    public double? PtEkKazancBNCarpan2 { get; set; }

    [Column("pt_EkKazancBNCarpan3")]
    public double? PtEkKazancBNCarpan3 { get; set; }

    [Column("pt_EkKazancBNCarpan4")]
    public double? PtEkKazancBNCarpan4 { get; set; }

    [Column("pt_EkKazancBNCarpan5")]
    public double? PtEkKazancBNCarpan5 { get; set; }

    [Column("pt_EkKazancBNCarpan6")]
    public double? PtEkKazancBNCarpan6 { get; set; }

    [Column("pt_EkKazancBNCarpan7")]
    public double? PtEkKazancBNCarpan7 { get; set; }

    [Column("pt_EkKazancBNCarpan8")]
    public double? PtEkKazancBNCarpan8 { get; set; }

    [Column("pt_EkKazancBNCarpan9")]
    public double? PtEkKazancBNCarpan9 { get; set; }

    [Column("pt_EkKazancBNCarpan10")]
    public double? PtEkKazancBNCarpan10 { get; set; }

    [Column("pt_EkKazancBNCarpan11")]
    public double? PtEkKazancBNCarpan11 { get; set; }

    [Column("pt_sosyolgun")]
    public short? PtSosyolgun { get; set; }

    [Column("pt_sosyemekgun")]
    public short? PtSosyemekgun { get; set; }

    [Column("pt_sosyrdm1")]
    public double? PtSosyrdm1 { get; set; }

    [Column("pt_sosyrdm2")]
    public double? PtSosyrdm2 { get; set; }

    [Column("pt_sosyrdm3")]
    public double? PtSosyrdm3 { get; set; }

    [Column("pt_sosyrdm4")]
    public double? PtSosyrdm4 { get; set; }

    [Column("pt_sosyrdm5")]
    public double? PtSosyrdm5 { get; set; }

    [Column("pt_sosyrdm6")]
    public double? PtSosyrdm6 { get; set; }

    [Column("pt_sosyrdm7")]
    public double? PtSosyrdm7 { get; set; }

    [Column("pt_sosyrdm8")]
    public double? PtSosyrdm8 { get; set; }

    [Column("pt_sosyrdm9")]
    public double? PtSosyrdm9 { get; set; }

    [Column("pt_sosyrdm10")]
    public double? PtSosyrdm10 { get; set; }

    [Column("pt_sosyrdm11")]
    public double? PtSosyrdm11 { get; set; }

    [Column("pt_sosyrdm12")]
    public double? PtSosyrdm12 { get; set; }

    [Column("pt_sosyrdm13")]
    public double? PtSosyrdm13 { get; set; }

    [Column("pt_sosyrdm14")]
    public double? PtSosyrdm14 { get; set; }

    [Column("pt_sosyrdm15")]
    public double? PtSosyrdm15 { get; set; }

    [Column("pt_sosyrdm16")]
    public double? PtSosyrdm16 { get; set; }

    [Column("pt_sosyrdm17")]
    public double? PtSosyrdm17 { get; set; }

    [Column("pt_sosyrdm18")]
    public double? PtSosyrdm18 { get; set; }

    [Column("pt_sosyrdm19")]
    public double? PtSosyrdm19 { get; set; }

    [Column("pt_sosyrdm20")]
    public double? PtSosyrdm20 { get; set; }

    [Column("pt_sosyrdm21")]
    public double? PtSosyrdm21 { get; set; }

    [Column("pt_sosyrdm22")]
    public double? PtSosyrdm22 { get; set; }

    [Column("pt_sosyrdm23")]
    public double? PtSosyrdm23 { get; set; }

    [Column("pt_sosyrdm24")]
    public double? PtSosyrdm24 { get; set; }

    [Column("pt_sosyrdm25")]
    public double? PtSosyrdm25 { get; set; }

    [Column("pt_sosyrdm26")]
    public double? PtSosyrdm26 { get; set; }

    [Column("pt_sosyrdm27")]
    public double? PtSosyrdm27 { get; set; }

    [Column("pt_sosyrdm28")]
    public double? PtSosyrdm28 { get; set; }

    [Column("pt_sosyrdm29")]
    public double? PtSosyrdm29 { get; set; }

    [Column("pt_sosyrdm30")]
    public double? PtSosyrdm30 { get; set; }

    [Column("pt_sosyrdm31")]
    public double? PtSosyrdm31 { get; set; }

    [Column("pt_sosyrdm32")]
    public double? PtSosyrdm32 { get; set; }

    [Column("pt_SosYardBNCarpan1")]
    public double? PtSosYardBNCarpan1 { get; set; }

    [Column("pt_SosYardBNCarpan2")]
    public double? PtSosYardBNCarpan2 { get; set; }

    [Column("pt_SosYardBNCarpan3")]
    public double? PtSosYardBNCarpan3 { get; set; }

    [Column("pt_SosYardBNCarpan4")]
    public double? PtSosYardBNCarpan4 { get; set; }

    [Column("pt_SosYardBNCarpan5")]
    public double? PtSosYardBNCarpan5 { get; set; }

    [Column("pt_SosYardBNCarpan6")]
    public double? PtSosYardBNCarpan6 { get; set; }

    [Column("pt_SosYardBNCarpan7")]
    public double? PtSosYardBNCarpan7 { get; set; }

    [Column("pt_SosYardBNCarpan8")]
    public double? PtSosYardBNCarpan8 { get; set; }

    [Column("pt_SosYardBNCarpan9")]
    public double? PtSosYardBNCarpan9 { get; set; }

    [Column("pt_SosYardBNCarpan10")]
    public double? PtSosYardBNCarpan10 { get; set; }

    [Column("pt_SosYardBNCarpan11")]
    public double? PtSosYardBNCarpan11 { get; set; }

    [Column("pt_SosYardBNCarpan12")]
    public double? PtSosYardBNCarpan12 { get; set; }

    [Column("pt_SosYardBNCarpan13")]
    public double? PtSosYardBNCarpan13 { get; set; }

    [Column("pt_SosYardBNCarpan14")]
    public double? PtSosYardBNCarpan14 { get; set; }

    [Column("pt_SosYardBNCarpan15")]
    public double? PtSosYardBNCarpan15 { get; set; }

    [Column("pt_SosYardBNCarpan16")]
    public double? PtSosYardBNCarpan16 { get; set; }

    [Column("pt_SosYardBNCarpan17")]
    public double? PtSosYardBNCarpan17 { get; set; }

    [Column("pt_SosYardBNCarpan18")]
    public double? PtSosYardBNCarpan18 { get; set; }

    [Column("pt_SosYardBNCarpan19")]
    public double? PtSosYardBNCarpan19 { get; set; }

    [Column("pt_SosYardBNCarpan20")]
    public double? PtSosYardBNCarpan20 { get; set; }

    [Column("pt_SosYardBNCarpan21")]
    public double? PtSosYardBNCarpan21 { get; set; }

    [Column("pt_SosYardBNCarpan22")]
    public double? PtSosYardBNCarpan22 { get; set; }

    [Column("pt_SosYardBNCarpan23")]
    public double? PtSosYardBNCarpan23 { get; set; }

    [Column("pt_SosYardBNCarpan24")]
    public double? PtSosYardBNCarpan24 { get; set; }

    [Column("pt_SosYardBNCarpan25")]
    public double? PtSosYardBNCarpan25 { get; set; }

    [Column("pt_SosYardBNCarpan26")]
    public double? PtSosYardBNCarpan26 { get; set; }

    [Column("pt_SosYardBNCarpan27")]
    public double? PtSosYardBNCarpan27 { get; set; }

    [Column("pt_SosYardBNCarpan28")]
    public double? PtSosYardBNCarpan28 { get; set; }

    [Column("pt_SosYardBNCarpan29")]
    public double? PtSosYardBNCarpan29 { get; set; }

    [Column("pt_SosYardBNCarpan30")]
    public double? PtSosYardBNCarpan30 { get; set; }

    [Column("pt_SosYardBNCarpan31")]
    public double? PtSosYardBNCarpan31 { get; set; }

    [Column("pt_SosYardBNCarpan32")]
    public double? PtSosYardBNCarpan32 { get; set; }

    [Column("pt_ozksnt1")]
    public double? PtOzksnt1 { get; set; }

    [Column("pt_ozksnt2")]
    public double? PtOzksnt2 { get; set; }

    [Column("pt_ozksnt3")]
    public double? PtOzksnt3 { get; set; }

    [Column("pt_ozksnt4")]
    public double? PtOzksnt4 { get; set; }

    [Column("pt_ozksnt5")]
    public double? PtOzksnt5 { get; set; }

    [Column("pt_ozksnt6")]
    public double? PtOzksnt6 { get; set; }

    [Column("pt_ozksnt7")]
    public double? PtOzksnt7 { get; set; }

    [Column("pt_ozksnt8")]
    public double? PtOzksnt8 { get; set; }

    [Column("pt_ozksnt9")]
    public double? PtOzksnt9 { get; set; }

    [Column("pt_ozksnt10")]
    public double? PtOzksnt10 { get; set; }

    [Column("pt_ozksnt11")]
    public double? PtOzksnt11 { get; set; }

    [Column("pt_ozksnt12")]
    public double? PtOzksnt12 { get; set; }

    [Column("pt_ozksnt13")]
    public double? PtOzksnt13 { get; set; }

    [Column("pt_ozksnt14")]
    public double? PtOzksnt14 { get; set; }

    [Column("pt_ozksnt15")]
    public double? PtOzksnt15 { get; set; }

    [Column("pt_ozksnt16")]
    public double? PtOzksnt16 { get; set; }

    [Column("pt_ozksnt17")]
    public double? PtOzksnt17 { get; set; }

    [Column("pt_ozksnt18")]
    public double? PtOzksnt18 { get; set; }

    [Column("pt_ozksnt19")]
    public double? PtOzksnt19 { get; set; }

    [Column("pt_ozksnt20")]
    public double? PtOzksnt20 { get; set; }

    [Column("pt_ozksnt21")]
    public double? PtOzksnt21 { get; set; }

    [Column("pt_ozksnt22")]
    public double? PtOzksnt22 { get; set; }

    [Column("pt_ozksnt23")]
    public double? PtOzksnt23 { get; set; }

    [Column("pt_ozksnt24")]
    public double? PtOzksnt24 { get; set; }

    [Column("pt_sskprimi")]
    public double? PtSskprimi { get; set; }

    [Column("pt_gv")]
    public double? PtGv { get; set; }

    [Column("pt_dv")]
    public double? PtDv { get; set; }

    [Column("pt_normalkazanc")]
    public double? PtNormalkazanc { get; set; }

    [Column("pt_ekkazanc")]
    public double? PtEkkazanc { get; set; }

    [Column("pt_sosyrdm")]
    public double? PtSosyrdm { get; set; }

    [Column("pt_yasksnt")]
    public double? PtYasksnt { get; set; }

    [Column("pt_ozksnt")]
    public double? PtOzksnt { get; set; }

    [Column("pt_kazanc")]
    public double? PtKazanc { get; set; }

    [Column("pt_kesinti")]
    public double? PtKesinti { get; set; }

    [Column("pt_net")]
    public double? PtNet { get; set; }

    [Column("pt_sskgunu")]
    public short? PtSskgunu { get; set; }

    [Column("pt_sskbrut")]
    public double? PtSskbrut { get; set; }

    [Column("pt_izingunu")]
    public short? PtIzingunu { get; set; }

    [Column("pt_izinmatrah")]
    public double? PtIzinmatrah { get; set; }

    [Column("pt_tersbakiye")]
    public double? PtTersbakiye { get; set; }

    [Column("pt_yuvfarki")]
    public double? PtYuvfarki { get; set; }

    [Column("pt_sskisvhis")]
    public double? PtSskisvhis { get; set; }

    [Column("pt_sskkonfon")]
    public double? PtSskkonfon { get; set; }

    [Column("pt_gayrisafikaz")]
    public short? PtGayrisafikaz { get; set; }

    [Column("pt_gs")]
    public double? PtGs { get; set; }

    [Column("pt_verind")]
    public double? PtVerind { get; set; }

    [Column("pt_gocverind")]
    public double? PtGocverind { get; set; }

    [Column("pt_sakverind")]
    public double? PtSakverind { get; set; }

    [Column("pt_digverindgv")]
    public double? PtDigverindgv { get; set; }

    [Column("pt_digverindssk")]
    public double? PtDigverindssk { get; set; }

    [Column("pt_toplamind")]
    public double? PtToplamind { get; set; }

    [Column("pt_devsskmatrah")]
    public double? PtDevsskmatrah { get; set; }

    [Column("pt_devgvmatrah")]
    public double? PtDevgvmatrah { get; set; }

    [Column("pt_sskbrutmatrah")]
    public double? PtSskbrutmatrah { get; set; }

    [Column("pt_gvmatrah")]
    public double? PtGvmatrah { get; set; }

    [Column("pt_gvbrut")]
    public double? PtGvbrut { get; set; }

    [Column("pt_arge5746gvmuafiyeti")]
    public double? PtArge5746gvmuafiyeti { get; set; }

    [Column("pt_vergi_iadesi")]
    public double? PtVergiIadesi { get; set; }

    [Column("pt_digverinddv")]
    public double? PtDigverinddv { get; set; }

    [Column("pt_dsiz")]
    public short? PtDsiz { get; set; }

    [Column("pt_vidv")]
    public double? PtVidv { get; set; }

    [Column("pt_netvergiiadesi")]
    public double? PtNetvergiiadesi { get; set; }

    [Column("pt_dvmatrah")]
    public double? PtDvmatrah { get; set; }

    [Column("pt_tahakkuklog")]
    public byte? PtTahakkuklog { get; set; }

    [Column("pt_sskkonutfonukad")]
    public byte? PtSskkonutfonukad { get; set; }

    [Column("pt_hayatsigortasi")]
    public double? PtHayatsigortasi { get; set; }

    [Column("pt_ssdfonu")]
    public double? PtSsdfonu { get; set; }

    [Column("pt_HesapTipi")]
    public byte? PtHesapTipi { get; set; }

    [Column("pt_iszlksigperpayi")]
    public double? PtIszlksigperpayi { get; set; }

    [Column("pt_iszlksigisvpayi")]
    public double? PtIszlksigisvpayi { get; set; }

    [Column("pt_iszlksigmatrah")]
    public double? PtIszlksigmatrah { get; set; }

    [Column("pt_iszlksigbrut")]
    public double? PtIszlksigbrut { get; set; }

    [Column("pt_digersigorta_isveren")]
    public double? PtDigersigortaIsveren { get; set; }

    [Column("pt_digersigorta_calisan")]
    public double? PtDigersigortaCalisan { get; set; }

    [Column("pt_bireyselsigorta_isveren")]
    public double? PtBireyselsigortaIsveren { get; set; }

    [Column("pt_bireyselsigorta_calisan")]
    public double? PtBireyselsigortaCalisan { get; set; }

    [Column("pt_EksikCalismaNedeni")]
    [StringLength(25)]
    public string? PtEksikCalismaNedeni { get; set; }

    [Column("pt_eksikcalismanedenisecimli")]
    public byte? PtEksikcalismanedenisecimli { get; set; }

    [Column("pt_AskerBorclanmasi")]
    public double? PtAskerBorclanmasi { get; set; }

    [Column("pt_IsvHisTesvInd")]
    public double? PtIsvHisTesvInd { get; set; }

    [Column("pt_KurTarihi")]
    public DateTime? PtKurTarihi { get; set; }

    [Column("pt_DepartmanKodu")]
    [StringLength(25)]
    public string? PtDepartmanKodu { get; set; }

    [Column("pt_GorevKodu")]
    [StringLength(25)]
    public string? PtGorevKodu { get; set; }

    [Column("pt_BolgeKodu")]
    [StringLength(25)]
    public string? PtBolgeKodu { get; set; }

    [Column("pt_asgarigecimindirimi")]
    public double? PtAsgarigecimindirimi { get; set; }

    [Column("pt_sonrayadevredensskmatrahi")]
    public double? PtSonrayadevredensskmatrahi { get; set; }

    [Column("pt_gecenaylardankullanilanssk")]
    public double? PtGecenaylardankullanilanssk { get; set; }

    [Column("pt_sgkyatabiitopkazanc")]
    public double? PtSgkyatabiitopkazanc { get; set; }

    [Column("pt_sgkyatabiitopekkazanc")]
    public double? PtSgkyatabiitopekkazanc { get; set; }

    [Column("pt_sgkyatabiitopsosyalyardim")]
    public double? PtSgkyatabiitopsosyalyardim { get; set; }

    [Column("pt_sgkpriminetabiikazanc")]
    public double? PtSgkpriminetabiikazanc { get; set; }

    [Column("pt_sgkpriminetabiiekkazanc")]
    public double? PtSgkpriminetabiiekkazanc { get; set; }

    [Column("pt_sgkpriminetabiisosyalyardim")]
    public double? PtSgkpriminetabiisosyalyardim { get; set; }

    [Column("pt_sgkprimikazanctan")]
    public double? PtSgkprimikazanctan { get; set; }

    [Column("pt_sgkprimiekkazanctan")]
    public double? PtSgkprimiekkazanctan { get; set; }

    [Column("pt_sgkprimisosyalyardimdan")]
    public double? PtSgkprimisosyalyardimdan { get; set; }

    [Column("pt_tabiioldugukanun")]
    public byte? PtTabiioldugukanun { get; set; }

    [Column("pt_tabiioldugukanun2")]
    public byte? PtTabiioldugukanun2 { get; set; }

    [Column("pt_kultur5225gvmuafiyeti")]
    public double? PtKultur5225gvmuafiyeti { get; set; }

    [Column("pt_hazinekanunugvindirimi")]
    public double? PtHazinekanunugvindirimi { get; set; }

    [Column("pt_dovizcins")]
    public byte? PtDovizcins { get; set; }

    [Column("pt_dovizkur")]
    public double? PtDovizkur { get; set; }

    [Column("pt_altdovizkur")]
    public double? PtAltdovizkur { get; set; }

    [Column("pt_bagkurprimi")]
    public double? PtBagkurprimi { get; set; }

    [Column("pt_tabiioldugubelgeturu")]
    public byte? PtTabiioldugubelgeturu { get; set; }

    [Column("pt_tabiioldugukanun3")]
    public byte? PtTabiioldugukanun3 { get; set; }

    [Column("pt_Az102KanunVergiIndirimi")]
    public double? PtAz102KanunVergiIndirimi { get; set; }

    [Column("pt_AzHastalikUcretFarki")]
    public double? PtAzHastalikUcretFarki { get; set; }

    [Column("pt_AzHastalikUcretFarkVergisi")]
    public double? PtAzHastalikUcretFarkVergisi { get; set; }

    [Column("pt_brutlesmeyenodeme")]
    public double? PtBrutlesmeyenodeme { get; set; }

    [Column("pt_sanalgvmatrah")]
    public double? PtSanalgvmatrah { get; set; }

    [Column("pt_sanalgv")]
    public double? PtSanalgv { get; set; }

    [Column("pt_sanaldvmatrah")]
    public double? PtSanaldvmatrah { get; set; }

    [Column("pt_sanaldv")]
    public double? PtSanaldv { get; set; }

    [Column("pt_perskgtesvikind")]
    public double? PtPerskgtesvikind { get; set; }

    [Column("pt_perisssigtesvikind")]
    public double? PtPerisssigtesvikind { get; set; }

    [Column("pt_izin1_tkgun")]
    public short? PtIzin1Tkgun { get; set; }

    [Column("pt_izin1_tksaat")]
    public double? PtIzin1Tksaat { get; set; }

    [Column("pt_izin1_tkyarim_isgunu")]
    public short? PtIzin1TkyarimIsgunu { get; set; }

    [Column("pt_izin1_tkyarim_isgun_saat")]
    public double? PtIzin1TkyarimIsgunSaat { get; set; }

    [Column("pt_izin1_tktutar")]
    public double? PtIzin1Tktutar { get; set; }

    [Column("pt_izin2_tkgun")]
    public short? PtIzin2Tkgun { get; set; }

    [Column("pt_izin2_tksaat")]
    public double? PtIzin2Tksaat { get; set; }

    [Column("pt_izin2_tkyarim_isgunu")]
    public short? PtIzin2TkyarimIsgunu { get; set; }

    [Column("pt_izin2_tkyarim_isgun_saat")]
    public double? PtIzin2TkyarimIsgunSaat { get; set; }

    [Column("pt_izin2_tktutar")]
    public double? PtIzin2Tktutar { get; set; }

    [Column("pt_izin3_tkgun")]
    public short? PtIzin3Tkgun { get; set; }

    [Column("pt_izin3_tksaat")]
    public double? PtIzin3Tksaat { get; set; }

    [Column("pt_izin3_tkyarim_isgunu")]
    public short? PtIzin3TkyarimIsgunu { get; set; }

    [Column("pt_izin3_tkyarim_isgun_saat")]
    public double? PtIzin3TkyarimIsgunSaat { get; set; }

    [Column("pt_izin3_tktutar")]
    public double? PtIzin3Tktutar { get; set; }

    [Column("pt_izin4_tkgun")]
    public short? PtIzin4Tkgun { get; set; }

    [Column("pt_izin4_tksaat")]
    public double? PtIzin4Tksaat { get; set; }

    [Column("pt_izin4_tkyarim_isgunu")]
    public short? PtIzin4TkyarimIsgunu { get; set; }

    [Column("pt_izin4_tkyarim_isgun_saat")]
    public double? PtIzin4TkyarimIsgunSaat { get; set; }

    [Column("pt_izin4_tktutar")]
    public double? PtIzin4Tktutar { get; set; }

    [Column("pt_izin5_tkgun")]
    public short? PtIzin5Tkgun { get; set; }

    [Column("pt_izin5_tksaat")]
    public double? PtIzin5Tksaat { get; set; }

    [Column("pt_izin5_tkyarim_isgunu")]
    public short? PtIzin5TkyarimIsgunu { get; set; }

    [Column("pt_izin5_tkyarim_isgun_saat")]
    public double? PtIzin5TkyarimIsgunSaat { get; set; }

    [Column("pt_izin5_tktutar")]
    public double? PtIzin5Tktutar { get; set; }

    [Column("pt_izin6_tkgun")]
    public short? PtIzin6Tkgun { get; set; }

    [Column("pt_izin6_tksaat")]
    public double? PtIzin6Tksaat { get; set; }

    [Column("pt_izin6_tkyarim_isgunu")]
    public short? PtIzin6TkyarimIsgunu { get; set; }

    [Column("pt_izin6_tkyarim_isgun_saat")]
    public double? PtIzin6TkyarimIsgunSaat { get; set; }

    [Column("pt_izin6_tktutar")]
    public double? PtIzin6Tktutar { get; set; }

    [Column("pt_izin7_tkgun")]
    public short? PtIzin7Tkgun { get; set; }

    [Column("pt_izin7_tksaat")]
    public double? PtIzin7Tksaat { get; set; }

    [Column("pt_izin7_tkyarim_isgunu")]
    public short? PtIzin7TkyarimIsgunu { get; set; }

    [Column("pt_izin7_tkyarim_isgun_saat")]
    public double? PtIzin7TkyarimIsgunSaat { get; set; }

    [Column("pt_izin7_tktutar")]
    public double? PtIzin7Tktutar { get; set; }

    [Column("pt_izin8_tkgun")]
    public short? PtIzin8Tkgun { get; set; }

    [Column("pt_izin8_tksaat")]
    public double? PtIzin8Tksaat { get; set; }

    [Column("pt_izin8_tkyarim_isgunu")]
    public short? PtIzin8TkyarimIsgunu { get; set; }

    [Column("pt_izin8_tkyarim_isgun_saat")]
    public double? PtIzin8TkyarimIsgunSaat { get; set; }

    [Column("pt_izin8_tktutar")]
    public double? PtIzin8Tktutar { get; set; }

    [Column("pt_izin9_tkgun")]
    public short? PtIzin9Tkgun { get; set; }

    [Column("pt_izin9_tksaat")]
    public double? PtIzin9Tksaat { get; set; }

    [Column("pt_izin9_tkyarim_isgunu")]
    public short? PtIzin9TkyarimIsgunu { get; set; }

    [Column("pt_izin9_tkyarim_isgun_saat")]
    public double? PtIzin9TkyarimIsgunSaat { get; set; }

    [Column("pt_izin9_tktutar")]
    public double? PtIzin9Tktutar { get; set; }

    [Column("pt_izin10_tkgun")]
    public short? PtIzin10Tkgun { get; set; }

    [Column("pt_izin10_tksaat")]
    public double? PtIzin10Tksaat { get; set; }

    [Column("pt_izin10_tkyarim_isgunu")]
    public short? PtIzin10TkyarimIsgunu { get; set; }

    [Column("pt_izin10_tkyarim_isgun_saat")]
    public double? PtIzin10TkyarimIsgunSaat { get; set; }

    [Column("pt_izin10_tktutar")]
    public double? PtIzin10Tktutar { get; set; }

    [Column("pt_izin11_tkgun")]
    public short? PtIzin11Tkgun { get; set; }

    [Column("pt_izin11_tksaat")]
    public double? PtIzin11Tksaat { get; set; }

    [Column("pt_izin11_tkyarim_isgunu")]
    public short? PtIzin11TkyarimIsgunu { get; set; }

    [Column("pt_izin11_tkyarim_isgun_saat")]
    public double? PtIzin11TkyarimIsgunSaat { get; set; }

    [Column("pt_izin11_tktutar")]
    public double? PtIzin11Tktutar { get; set; }

    [Column("pt_izin12_tkgun")]
    public short? PtIzin12Tkgun { get; set; }

    [Column("pt_izin12_tksaat")]
    public double? PtIzin12Tksaat { get; set; }

    [Column("pt_izin12_tkyarim_isgunu")]
    public short? PtIzin12TkyarimIsgunu { get; set; }

    [Column("pt_izin12_tkyarim_isgun_saat")]
    public double? PtIzin12TkyarimIsgunSaat { get; set; }

    [Column("pt_izin12_tktutar")]
    public double? PtIzin12Tktutar { get; set; }

    [Column("pt_izin13_tkgun")]
    public short? PtIzin13Tkgun { get; set; }

    [Column("pt_izin13_tksaat")]
    public double? PtIzin13Tksaat { get; set; }

    [Column("pt_izin13_tkyarim_isgunu")]
    public short? PtIzin13TkyarimIsgunu { get; set; }

    [Column("pt_izin13_tkyarim_isgun_saat")]
    public double? PtIzin13TkyarimIsgunSaat { get; set; }

    [Column("pt_izin13_tktutar")]
    public double? PtIzin13Tktutar { get; set; }

    [Column("pt_izin14_tkgun")]
    public short? PtIzin14Tkgun { get; set; }

    [Column("pt_izin14_tksaat")]
    public double? PtIzin14Tksaat { get; set; }

    [Column("pt_izin14_tkyarim_isgunu")]
    public short? PtIzin14TkyarimIsgunu { get; set; }

    [Column("pt_izin14_tkyarim_isgun_saat")]
    public double? PtIzin14TkyarimIsgunSaat { get; set; }

    [Column("pt_izin14_tktutar")]
    public double? PtIzin14Tktutar { get; set; }

    [Column("pt_izin15_tkgun")]
    public short? PtIzin15Tkgun { get; set; }

    [Column("pt_izin15_tksaat")]
    public double? PtIzin15Tksaat { get; set; }

    [Column("pt_izin15_tkyarim_isgunu")]
    public short? PtIzin15TkyarimIsgunu { get; set; }

    [Column("pt_izin15_tkyarim_isgun_saat")]
    public double? PtIzin15TkyarimIsgunSaat { get; set; }

    [Column("pt_izin15_tktutar")]
    public double? PtIzin15Tktutar { get; set; }

    [Column("pt_izin16_tkgun")]
    public short? PtIzin16Tkgun { get; set; }

    [Column("pt_izin16_tksaat")]
    public double? PtIzin16Tksaat { get; set; }

    [Column("pt_izin16_tkyarim_isgunu")]
    public short? PtIzin16TkyarimIsgunu { get; set; }

    [Column("pt_izin16_tkyarim_isgun_saat")]
    public double? PtIzin16TkyarimIsgunSaat { get; set; }

    [Column("pt_izin16_tktutar")]
    public double? PtIzin16Tktutar { get; set; }

    [Column("pt_hayatsigorta_isveren")]
    public double? PtHayatsigortaIsveren { get; set; }

    [Column("pt_hayatsigorta_calisan")]
    public double? PtHayatsigortaCalisan { get; set; }

    [Column("pt_kanungvindirimi")]
    public double? PtKanungvindirimi { get; set; }

    [Column("pt_kanundvindirimi")]
    public double? PtKanundvindirimi { get; set; }

    [Column("pt_isssigisvpayi_tesvind")]
    public double? PtIsssigisvpayiTesvind { get; set; }

    [Column("pt_hazine_destegine_tabi_fl")]
    public bool? PtHazineDestegineTabiFl { get; set; }

    [Column("pt_hazine_destegi_gunu")]
    public int? PtHazineDestegiGunu { get; set; }

    [Column("pt_ilave_agi")]
    public double? PtIlaveAgi { get; set; }

    [Column("pt_saatlik_izin_suresi")]
    public double? PtSaatlikIzinSuresi { get; set; }

    [Column("pt_saatlik_izin_tutari")]
    public double? PtSaatlikIzinTutari { get; set; }

    [Column("pt_otobes_tutari")]
    public double? PtOtobesTutari { get; set; }

    [Column("pt_gecici17_18e_tabi_fl")]
    public bool? PtGecici1718eTabiFl { get; set; }
}
