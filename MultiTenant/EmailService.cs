using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

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

            var port = int.Parse(portStr ?? "587");

            var msg = new MimeMessage();
            msg.From.Add(new MailboxAddress(fromName, from));
            msg.To.Add(MailboxAddress.Parse(to));
            msg.Subject = subject;
            var body = new BodyBuilder { HtmlBody = htmlBody };
            msg.Body = body.ToMessageBody();

            using var client = new SmtpClient();
            // 465 -> SslOnConnect (implicit SSL), 587 -> StartTls
            var secureOption = port == 465 ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.StartTls;
            await client.ConnectAsync(host, port, secureOption, ct);

            if (!string.IsNullOrEmpty(user))
                await client.AuthenticateAsync(user, pass, ct);

            await client.SendAsync(msg, ct);
            await client.DisconnectAsync(true, ct);

            _log.LogInformation("Email gonderildi: To={To}", to);
            return true;
        }
        catch (Exception ex)
        {
            _log.LogError(ex, "Email gonderim hatasi: To={To}", to);
            return false;
        }
    }
}
