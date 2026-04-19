using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.PineERP.Ai;

[Table("pine_documents")]
public class PineDocument
{
    [Key] [Column("document_id")] public Guid DocumentId { get; set; } = Guid.NewGuid();
    [Column("ad")]                public string Ad { get; set; } = "";
    [Column("mime")]              public string? Mime { get; set; }
    [Column("boyut")]             public long Boyut { get; set; }
    [Column("icerik")]            public byte[]? Icerik { get; set; }
    [Column("disk_yol")]          public string? DiskYol { get; set; }
    [Column("hash_sha256")]       public byte[]? HashSha256 { get; set; }
    [Column("etiketler")]         public string? Etiketler { get; set; }
    [Column("icerik_ozeti")]      public string? IcerikOzeti { get; set; }
    [Column("baglanti_tip")]      public string? BaglantiTip { get; set; }
    [Column("baglanti_id")]       public string? BaglantiId { get; set; }
    [Column("yukleyen")]          public string? Yukleyen { get; set; }
    [Column("olusturulma")]       public DateTime Olusturulma { get; set; } = DateTime.UtcNow;
}

[Table("pine_roles")]
public class PineRole
{
    [Key] [Column("role_id")] public Guid RoleId { get; set; } = Guid.NewGuid();
    [Column("ad")]            public string Ad { get; set; } = "";
    [Column("aciklama")]      public string? Aciklama { get; set; }
    [Column("yetki_json")]    public string? YetkiJson { get; set; }
    [Column("olusturulma")]   public DateTime Olusturulma { get; set; } = DateTime.UtcNow;
}

[Table("pine_stok_tahmin")]
public class PineStokTahmin
{
    [Key] [Column("stok_kod")] public string StokKod { get; set; } = "";
    [Column("gunluk_hareket")] public decimal GunlukHareket { get; set; }
    [Column("kalan_gun")]      public int KalanGun { get; set; } = 999;
    [Column("son_hesap")]      public DateTime SonHesap { get; set; } = DateTime.UtcNow;
    [Column("oneri")]          public string? Oneri { get; set; }
}

[Table("pine_ai_log")]
public class PineAiLog
{
    [Key] [Column("log_id")] public Guid LogId { get; set; } = Guid.NewGuid();
    [Column("islem")]        public string Islem { get; set; } = "";
    [Column("giris_ozet")]   public string? GirisOzet { get; set; }
    [Column("cikis_ozet")]   public string? CikisOzet { get; set; }
    [Column("token_in")]     public int? TokenIn { get; set; }
    [Column("token_out")]    public int? TokenOut { get; set; }
    [Column("saglayici")]    public string? Saglayici { get; set; }
    [Column("kullanici")]    public string? Kullanici { get; set; }
    [Column("tarih")]        public DateTime Tarih { get; set; } = DateTime.UtcNow;
}

[Table("pine_bildirimler")]
public class PineBildirim
{
    [Key] [Column("bildirim_id")] public Guid BildirimId { get; set; } = Guid.NewGuid();
    [Column("user_id")]           public Guid? UserId { get; set; }
    [Column("tip")]               public string Tip { get; set; } = "sistem";
    [Column("baslik")]            public string Baslik { get; set; } = "";
    [Column("govde")]             public string? Govde { get; set; }
    [Column("url")]               public string? Url { get; set; }
    [Column("okundu")]            public bool Okundu { get; set; }
    [Column("onem")]              public string Onem { get; set; } = "info";
    [Column("tarih")]             public DateTime Tarih { get; set; } = DateTime.UtcNow;
}
