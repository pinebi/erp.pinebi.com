using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("kredi_sozlesmesi_tanimlari")]
public class KrediSozlesmesiTanimlari
{
    [Column("krsoz_Guid")]
    public Guid? KrsozGuid { get; set; }

    [Column("krsoz_DBCno")]
    public short? KrsozDBCno { get; set; }

    [Column("krsoz_Spec_Rec_no")]
    public int? KrsozSpecRecNo { get; set; }

    [Column("krsoz_iptal")]
    public bool? KrsozIptal { get; set; }

    [Column("krsoz_fileid")]
    public short? KrsozFileid { get; set; }

    [Column("krsoz_hidden")]
    public bool? KrsozHidden { get; set; }

    [Column("krsoz_kilitli")]
    public bool? KrsozKilitli { get; set; }

    [Column("krsoz_degisti")]
    public bool? KrsozDegisti { get; set; }

    [Column("krsoz_checksum")]
    public int? KrsozChecksum { get; set; }

    [Column("krsoz_create_user")]
    public short? KrsozCreateUser { get; set; }

    [Column("krsoz_create_date")]
    public DateTime? KrsozCreateDate { get; set; }

    [Column("krsoz_lastup_user")]
    public short? KrsozLastupUser { get; set; }

    [Column("krsoz_lastup_date")]
    public DateTime? KrsozLastupDate { get; set; }

    [Column("krsoz_special1")]
    [StringLength(4)]
    public string? KrsozSpecial1 { get; set; }

    [Column("krsoz_special2")]
    [StringLength(4)]
    public string? KrsozSpecial2 { get; set; }

    [Column("krsoz_special3")]
    [StringLength(4)]
    public string? KrsozSpecial3 { get; set; }

    [Column("krsoz_kodu")]
    [StringLength(25)]
    public string? KrsozKodu { get; set; }

    [Column("krsoz_aciklama")]
    [StringLength(50)]
    public string? KrsozAciklama { get; set; }

    [Column("krsoz_firmano")]
    public int? KrsozFirmano { get; set; }

    [Column("krsoz_subeno")]
    public int? KrsozSubeno { get; set; }

    [Column("krsoz_sozbankakodu")]
    [StringLength(25)]
    public string? KrsozSozbankakodu { get; set; }

    [Column("krsoz_dovizcinsi")]
    public byte? KrsozDovizcinsi { get; set; }

    [Column("krsoz_tipi")]
    public byte? KrsozTipi { get; set; }

    [Column("krsoz_kullanimtarihi")]
    public DateTime? KrsozKullanimtarihi { get; set; }

    [Column("krsoz_kreditutari")]
    public double? KrsozKreditutari { get; set; }

    [Column("krsoz_taksittipi")]
    public byte? KrsozTaksittipi { get; set; }

    [Column("krsoz_taksitaraligi")]
    public short? KrsozTaksitaraligi { get; set; }

    [Column("krsoz_taksitsayisi")]
    public short? KrsozTaksitsayisi { get; set; }

    [Column("krsoz_faiztipi")]
    public byte? KrsozFaiztipi { get; set; }

    [Column("krsoz_faizorani")]
    public double? KrsozFaizorani { get; set; }

    [Column("krsoz_bsmvorani")]
    public double? KrsozBsmvorani { get; set; }

    [Column("krsoz_kkdforani")]
    public double? KrsozKkdforani { get; set; }

    [Column("krsoz_alinanucret")]
    public double? KrsozAlinanucret { get; set; }

    [Column("krsoz_anaparamuhkodu")]
    [StringLength(40)]
    public string? KrsozAnaparamuhkodu { get; set; }

    [Column("krsoz_uvanaparamuhkodu")]
    [StringLength(40)]
    public string? KrsozUvanaparamuhkodu { get; set; }

    [Column("krsoz_kvtahakkukkodu")]
    [StringLength(40)]
    public string? KrsozKvtahakkukkodu { get; set; }

    [Column("krsoz_uvtahakkukkodu")]
    [StringLength(40)]
    public string? KrsozUvtahakkukkodu { get; set; }

    [Column("krsoz_faizmuhkodu")]
    [StringLength(40)]
    public string? KrsozFaizmuhkodu { get; set; }

    [Column("krsoz_bsmvmuhkodu")]
    [StringLength(40)]
    public string? KrsozBsmvmuhkodu { get; set; }

    [Column("krsoz_kkdfmuhkodu")]
    [StringLength(40)]
    public string? KrsozKkdfmuhkodu { get; set; }

    [Column("krsoz_ucretmuhkodu")]
    [StringLength(40)]
    public string? KrsozUcretmuhkodu { get; set; }

    [Column("krsoz_faiztutari")]
    public double? KrsozFaiztutari { get; set; }

    [Column("krsoz_giderhesaptipi")]
    public byte? KrsozGiderhesaptipi { get; set; }

    [Column("krsoz_gidertahakkuktipi")]
    public byte? KrsozGidertahakkuktipi { get; set; }

    [Column("krsoz_dagitimanahtari")]
    [StringLength(25)]
    public string? KrsozDagitimanahtari { get; set; }

    [Column("krsoz_kapanistarihi")]
    public DateTime? KrsozKapanistarihi { get; set; }

    [Column("krsoz_ftgecerliliktarihi1")]
    public DateTime? KrsozFtgecerliliktarihi1 { get; set; }

    [Column("krsoz_ftfaizorani1")]
    public double? KrsozFtfaizorani1 { get; set; }

    [Column("krsoz_ftgecerliliktarihi2")]
    public DateTime? KrsozFtgecerliliktarihi2 { get; set; }

    [Column("krsoz_ftfaizorani2")]
    public double? KrsozFtfaizorani2 { get; set; }

    [Column("krsoz_ftgecerliliktarihi3")]
    public DateTime? KrsozFtgecerliliktarihi3 { get; set; }

    [Column("krsoz_ftfaizorani3")]
    public double? KrsozFtfaizorani3 { get; set; }

    [Column("krsoz_ftgecerliliktarihi4")]
    public DateTime? KrsozFtgecerliliktarihi4 { get; set; }

    [Column("krsoz_ftfaizorani4")]
    public double? KrsozFtfaizorani4 { get; set; }

    [Column("krsoz_ftgecerliliktarihi5")]
    public DateTime? KrsozFtgecerliliktarihi5 { get; set; }

    [Column("krsoz_ftfaizorani5")]
    public double? KrsozFtfaizorani5 { get; set; }

    [Column("krsoz_ftgecerliliktarihi6")]
    public DateTime? KrsozFtgecerliliktarihi6 { get; set; }

    [Column("krsoz_ftfaizorani6")]
    public double? KrsozFtfaizorani6 { get; set; }

    [Column("krsoz_ftgecerliliktarihi7")]
    public DateTime? KrsozFtgecerliliktarihi7 { get; set; }

    [Column("krsoz_ftfaizorani7")]
    public double? KrsozFtfaizorani7 { get; set; }

    [Column("krsoz_ftgecerliliktarihi8")]
    public DateTime? KrsozFtgecerliliktarihi8 { get; set; }

    [Column("krsoz_ftfaizorani8")]
    public double? KrsozFtfaizorani8 { get; set; }

    [Column("krsoz_ftgecerliliktarihi9")]
    public DateTime? KrsozFtgecerliliktarihi9 { get; set; }

    [Column("krsoz_ftfaizorani9")]
    public double? KrsozFtfaizorani9 { get; set; }

    [Column("krsoz_ftgecerliliktarihi10")]
    public DateTime? KrsozFtgecerliliktarihi10 { get; set; }

    [Column("krsoz_ftfaizorani10")]
    public double? KrsozFtfaizorani10 { get; set; }

    [Column("krsoz_ftgecerliliktarihi11")]
    public DateTime? KrsozFtgecerliliktarihi11 { get; set; }

    [Column("krsoz_ftfaizorani11")]
    public double? KrsozFtfaizorani11 { get; set; }

    [Column("krsoz_ftgecerliliktarihi12")]
    public DateTime? KrsozFtgecerliliktarihi12 { get; set; }

    [Column("krsoz_ftfaizorani12")]
    public double? KrsozFtfaizorani12 { get; set; }

    [Column("krsoz_ftgecerliliktarihi13")]
    public DateTime? KrsozFtgecerliliktarihi13 { get; set; }

    [Column("krsoz_ftfaizorani13")]
    public double? KrsozFtfaizorani13 { get; set; }

    [Column("krsoz_ftgecerliliktarihi14")]
    public DateTime? KrsozFtgecerliliktarihi14 { get; set; }

    [Column("krsoz_ftfaizorani14")]
    public double? KrsozFtfaizorani14 { get; set; }

    [Column("krsoz_ftgecerliliktarihi15")]
    public DateTime? KrsozFtgecerliliktarihi15 { get; set; }

    [Column("krsoz_ftfaizorani15")]
    public double? KrsozFtfaizorani15 { get; set; }

    [Column("krsoz_ftgecerliliktarihi16")]
    public DateTime? KrsozFtgecerliliktarihi16 { get; set; }

    [Column("krsoz_ftfaizorani16")]
    public double? KrsozFtfaizorani16 { get; set; }

    [Column("krsoz_ftgecerliliktarihi17")]
    public DateTime? KrsozFtgecerliliktarihi17 { get; set; }

    [Column("krsoz_ftfaizorani17")]
    public double? KrsozFtfaizorani17 { get; set; }

    [Column("krsoz_ftgecerliliktarihi18")]
    public DateTime? KrsozFtgecerliliktarihi18 { get; set; }

    [Column("krsoz_ftfaizorani18")]
    public double? KrsozFtfaizorani18 { get; set; }

    [Column("krsoz_ftgecerliliktarihi19")]
    public DateTime? KrsozFtgecerliliktarihi19 { get; set; }

    [Column("krsoz_ftfaizorani19")]
    public double? KrsozFtfaizorani19 { get; set; }

    [Column("krsoz_ftgecerliliktarihi20")]
    public DateTime? KrsozFtgecerliliktarihi20 { get; set; }

    [Column("krsoz_ftfaizorani20")]
    public double? KrsozFtfaizorani20 { get; set; }
}
