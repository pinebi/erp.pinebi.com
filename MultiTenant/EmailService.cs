using System.Net;
using System.Net.Mail;

namespace MACHINEBISS_Web.MultiTenant;

public interface IEmailService
{
    Task<bool> SendAsync(string to, string subject, string htmlBody, CancellationToken ct = default);
}

public sealed class SmtpEmailService : IEmailService
{
    private readonly IConfiguration _config;
    private readonly ILogger<SmtpEmailService> _log;

    public SmtpEmailService(IConfiguration config, ILogger<SmtpEmailService> log)
    {
        _config = config; _log = log;
    }

    public async Task<bool> SendAsync(string to, string subject, string htmlBody, CancellationToken ct = default)
    {
        try
        {
            var host = _config["Email:Host"];
            var portStr = _config["Email:Port"];
            var user = _config["Email:User"];
            var pass = _config["Email:Pass"];
            var from = _config["Email:From"];
            var fromName = _config["Email:FromName"] ?? "Pinebi ERP";

            if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(from))
            {
                _log.LogWarning("Email gonderilemedi: Email:Host / Email:From appsettings'te yok. To={To}", to);
                return false;
            }

            using var smtp = new SmtpClient(host, int.Parse(portStr ?? "587"))
            {
                EnableSsl = true,
                Credentials = string.IsNullOrEmpty(user) ? null : new NetworkCredential(user, pass),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };

            using var msg = new MailMessage
            {
                From = new MailAddress(from, fromName),
                Subject = subject,
                Body = htmlBody,
                IsBodyHtml = true
            };
            msg.To.Add(to);
            await smtp.SendMailAsync(msg, ct);
            return true;
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "Email gonderim hatasi: To={To}", to);
            return false;
        }
    }
}
