using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class CariHareketler
    {
        public int Id { get; set; }
        public string? FisNo { get; set; }
        public DateTime Tarih { get; set; }
        [Column("TarihSaat")]
        public DateTime? Saat { get; set; }
        public int CariId { get; set; }
        public int? FisId { get; set; }
        public DateTime? BelgeTarihi { get; set; }
        public string? BelgeNo { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Aciklama2 { get; set; }
        public int IslemId { get; set; }
        public int OdemeId { get; set; }
        public decimal Tutar { get; set; }
        public string? DovizId { get; set; }
        public string? Doviz { get; set; }
        public bool? Iptal { get; set; }
        public string? IptalEden { get; set; }
        public string? Kaynak { get; set; }
        public int? VirmanCekId { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string? OlusturanKullanici { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenKullanici { get; set; }
    }

    public class CariHareketlerView
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string? FisNo { get; set; }
        [Column("TarihSaat")]
        public DateTime? Saat { get; set; }
        public int CariId { get; set; }
        public string? CariKodu { get; set; }
        public string? Unvani { get; set; }
        public int? FisId { get; set; }
        public DateTime? BelgeTarihi { get; set; }
        public string? BelgeNo { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Aciklama2 { get; set; }
        public int IslemId { get; set; }
        public int OdemeId { get; set; }
        [Column("OdemeTipi")]
        public string? HareketTipi { get; set; }
        public decimal Borc { get; set; }
        public decimal Alacak { get; set; }
        public string? DovizId { get; set; }
        public string? Doviz { get; set; }
        public bool? Iptal { get; set; }
        public string? IptalEden { get; set; }
        public string? Kaynak { get; set; }
        public int? VirmanCekId { get; set; }
    }

    public class CariHesapEkstresi
    {
        public int Id { get; set; }
        public int CariId { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime TarihSaat { get; set; }
        public int? FisId { get; set; }
        public string? FisNo { get; set; }
        public DateTime? BelgeTarihi { get; set; }
        public string? BelgeNo { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Aciklama2 { get; set; }
        public decimal Borc { get; set; }
        public decimal Alacak { get; set; }
        public decimal Bakiye { get; set; }
        public string? Doviz { get; set; }
        public string? Kaynak { get; set; }
    }

    public class CekSenetHareketleri
    {
        public int Id { get; set; }
        public int IslemId { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime VadeTarihi { get; set; }
        public string? Tip { get; set; }
        public string? Cs { get; set; }
        public int? FisId { get; set; }
        public string? FisNo { get; set; }
        public int? CariId { get; set; }
        public string? Banka { get; set; }
        public string? Ciro { get; set; }
        public string? SeriNo { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Aciklama2 { get; set; }
        public decimal Tutar { get; set; }
        public string? DovizId { get; set; }
        public string? Durumu { get; set; }
        public bool? Iptal { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string? OlusturanKullanici { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenKullanici { get; set; }
    }

    public class CekSenetHareketleriView
    {
        public int Id { get; set; }
        public int IslemId { get; set; }
        public DateTime Tarih { get; set; }
        public string? FisNo { get; set; }
        public DateTime VadeTarihi { get; set; }
        public string? Tip { get; set; }
        [Column("Cs")]
        public string? EvrakTipi { get; set; }
        public int? FisId { get; set; }
        public int? CariId { get; set; }
        public string? CariKodu { get; set; }
        [Column("Unvani")]
        public string? Unvan { get; set; }
        public string? Banka { get; set; }
        public string? Ciro { get; set; }
        public string? SeriNo { get; set; }
        [Column("Aciklama1")]
        public string? Aciklama1 { get; set; }
        [Column("Aciklama2")]
        public string? Aciklama2 { get; set; }
        [Column("AlinanCekSenet")]
        public double Alinan { get; set; }
        [Column("VerilenCekSenet")]
        public double Verilen { get; set; }
        public string? DovizId { get; set; }
        public string? Durumu { get; set; }
        public bool? Iptal { get; set; }
    }

    public class BankaHareketleri
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int? IslemTipi { get; set; }
        public int? FisId { get; set; }
        public string? FisNo { get; set; }
        public int IslemId { get; set; }
        public int? CariId { get; set; }
        public int BankaId { get; set; }
        public string? Aciklama1 { get; set; }
        public string? Aciklama2 { get; set; }
        public decimal Tutar { get; set; }
        public string? DovizId { get; set; }
        public bool? Iptal { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string? OlusturanKullanici { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenKullanici { get; set; }
    }

    public class BankaHareketleriView
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int? IslemTipi { get; set; }
        public int? FisId { get; set; }
        public string? FisNo { get; set; }
        public int IslemId { get; set; }
        public int? CariId { get; set; }
        public string? CariKodu { get; set; }
        [Column("Unvani")]
        public string? Unvan { get; set; }
        public int BankaId { get; set; }
        public string? Banka { get; set; }
        [Column("Aciklama1")]
        public string? Aciklama1 { get; set; }
        [Column("Aciklama2")]
        public string? Aciklama2 { get; set; }
        [Column("Giren")]
        public double Giren { get; set; }
        [Column("Cikan")]
        public double Cikan { get; set; }
        public string? DovizId { get; set; }
        public bool? Iptal { get; set; }
    }
}
