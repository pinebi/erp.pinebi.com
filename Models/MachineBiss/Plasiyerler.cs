using System.ComponentModel.DataAnnotations.Schema;
namespace MACHINEBISS_Web.Models.MachineBiss;

public class Plasiyerler
{
    public int Id { get; set; }
    public string? Kodu { get; set; } = "";
    public string? Adi { get; set; } = "";
    public string? Telefon { get; set; } = "";
    public string? Email { get; set; } = "";
    public string? Bolge { get; set; } = "";
    public string? Aciklama { get; set; } = "";
    public bool Aktif { get; set; } = true;
    public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    public string? OlusturanKullanici { get; set; } = "";
    public DateTime? GuncellemeTarihi { get; set; }
    public string? GuncelleyenKullanici { get; set; } = "";
}

public class Projeler2
{
    public int Id { get; set; }
    public string? Kodu { get; set; } = "";
    public string? Adi { get; set; } = "";
    public string? Musteri { get; set; } = "";
    public string? Sorumlu { get; set; } = "";
    public DateTime? BaslangicTarihi { get; set; }
    public DateTime? BitisTarihi { get; set; }
    public string? Durumu { get; set; } = "Aktif";
    public double? Butce { get; set; }
    public string? Aciklama { get; set; } = "";
    public bool Aktif { get; set; } = true;
    public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    public string? OlusturanKullanici { get; set; } = "";
    public DateTime? GuncellemeTarihi { get; set; }
    public string? GuncelleyenKullanici { get; set; } = "";
}

public class SorumlulukMerkezleri
{
    public int Id { get; set; }
    public string? Kodu { get; set; } = "";
    public string? Adi { get; set; } = "";
    public string? UstMerkez { get; set; } = "";
    public string? Sorumlu { get; set; } = "";
    public string? Aciklama { get; set; } = "";
    public bool Aktif { get; set; } = true;
    public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    public string? OlusturanKullanici { get; set; } = "";
    public DateTime? GuncellemeTarihi { get; set; }
    public string? GuncelleyenKullanici { get; set; } = "";
}
