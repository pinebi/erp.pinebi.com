using MACHINEBISS_Web.MultiTenant;
using Microsoft.AspNetCore.Mvc;

namespace MACHINEBISS_Web.Controllers.Api;

[ApiController]
[Route("api/platform/auth")]
public class PlatformAuthController : ControllerBase
{
    private readonly IPlatformAuthService _auth;
    private readonly IAuditLogger _audit;

    public PlatformAuthController(IPlatformAuthService auth, IAuditLogger audit)
    {
        _auth = auth; _audit = audit;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto dto)
    {
        if (dto == null || string.IsNullOrWhiteSpace(dto.Email) || string.IsNullOrWhiteSpace(dto.Password))
            return BadRequest(new { error = "EMAIL_VE_PASSWORD_ZORUNLU" });

        var user = await _auth.LoginAsync(dto.Email, dto.Password);
        if (user == null)
        {
            await _audit.LogAsync("platform.login_failed", new { email = dto.Email },
                ipAddress: HttpContext?.Connection?.RemoteIpAddress?.ToString());
            return Unauthorized(new { error = "GECERSIZ_KIMLIK" });
        }

        var cookieVal = _auth.IssueCookie(user);
        Response.Cookies.Append("pinebi_platform", cookieVal, new CookieOptions
        {
            HttpOnly = true,
            Secure = Request.IsHttps,
            SameSite = SameSiteMode.Lax,
            Expires = DateTimeOffset.UtcNow.AddHours(12),
            Path = "/"
        });

        await _audit.LogAsync("platform.login", new { email = user.Email, role = user.Role },
            actorType: "platform_user", actorId: user.UserId,
            ipAddress: HttpContext?.Connection?.RemoteIpAddress?.ToString());

        return Ok(new { user.Email, user.FullName, user.Role });
    }

    [HttpPost("logout")]
    public IActionResult Logout()
    {
        Response.Cookies.Delete("pinebi_platform");
        return Ok(new { loggedOut = true });
    }

    [HttpGet("me")]
    public IActionResult Me()
    {
        if (HttpContext.Items["PlatformUser"] is not PlatformUser u)
            return Unauthorized();
        return Ok(new { u.Email, u.Role });
    }
}

public sealed class LoginDto
{
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
}
