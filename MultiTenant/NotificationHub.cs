using Microsoft.AspNetCore.SignalR;

namespace MACHINEBISS_Web.MultiTenant;

public class NotificationHub : Hub
{
    public async Task JoinGroup(string group) => await Groups.AddToGroupAsync(Context.ConnectionId, group);
}

public interface INotifier { Task SendAsync(string tip, string baslik, string? govde = null, string? url = null, string onem = "info"); }

public class NotifierService : INotifier
{
    private readonly IHubContext<NotificationHub> _hub;
    public NotifierService(IHubContext<NotificationHub> hub) => _hub = hub;
    public async Task SendAsync(string tip, string baslik, string? govde = null, string? url = null, string onem = "info")
    {
        await _hub.Clients.All.SendAsync("Bildirim", new { tip, baslik, govde, url, onem, tarih = DateTime.UtcNow });
    }
}
