using System.ComponentModel.DataAnnotations;

namespace MACHINEBISS_Web.Models.MachineBiss;

public class GridKolonAyar
{
    public int Id { get; set; }
    public string? SirketKodu { get; set; } = "";
    public int KullaniciId { get; set; }
    public string? FormAdi { get; set; } = "";  // "fatura", "irsaliye", "siparis"
    public string? KolonId { get; set; } = "";
    public bool Gorunur { get; set; } = true;
}
