using Microsoft.AspNetCore.Mvc;

namespace MACHINEBISS_Web.Controllers.Api;

/// <summary>
/// Tum PineERP API controller'larinin temel sinifi.
/// Route: /api/[controller]
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public abstract class BaseApiController : ControllerBase
{
    /// <summary>Basarili sonuc dondur</summary>
    protected IActionResult Ok<T>(T data, string message = "Basarili") =>
        base.Ok(new ApiResponse<T> { Success = true, Message = message, Data = data });

    /// <summary>Basarili sonuc (data olmadan)</summary>
    protected IActionResult OkMessage(string message = "Basarili") =>
        base.Ok(new ApiResponse<object> { Success = true, Message = message });

    /// <summary>Hata sonuc dondur</summary>
    protected IActionResult Error(string message, int statusCode = 400) =>
        StatusCode(statusCode, new ApiResponse<object> { Success = false, Message = message });

    /// <summary>Sayfali liste dondur</summary>
    protected IActionResult OkPaged<T>(List<T> data, int toplam, int sayfa, int sayfaBoyutu) =>
        base.Ok(new PagedApiResponse<T>
        {
            Success = true,
            Message = "Basarili",
            Data = data,
            Toplam = toplam,
            Sayfa = sayfa,
            SayfaBoyutu = sayfaBoyutu,
            ToplamSayfa = (int)Math.Ceiling(toplam / (double)sayfaBoyutu)
        });
}

/// <summary>Standart API yanit modeli</summary>
public class ApiResponse<T>
{
    public bool Success { get; set; }
    public string Message { get; set; } = "";
    public T? Data { get; set; }
}

/// <summary>Sayfali API yanit modeli</summary>
public class PagedApiResponse<T> : ApiResponse<List<T>>
{
    public int Toplam { get; set; }
    public int Sayfa { get; set; }
    public int SayfaBoyutu { get; set; }
    public int ToplamSayfa { get; set; }
}
