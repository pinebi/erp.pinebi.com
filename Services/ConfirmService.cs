namespace MACHINEBISS_Web.Services;

/// <summary>
/// Global confirm dialog servisi. Tek bir modal ile tum sayfalarda
/// onay ekrani gosterilir. Kullanim:
///   if (await Confirm.AskAsync("Kaydi silmek istediginize emin misiniz?")) { ... }
/// </summary>
public class ConfirmService
{
    public event Func<ConfirmRequest, Task>? OnShow;

    public async Task<bool> AskAsync(string message, string title = "Onay", string okText = "Evet", string cancelText = "Vazgec", bool danger = true)
    {
        if (OnShow == null) return true; // modal host yoksa default onay
        var req = new ConfirmRequest
        {
            Title = title, Message = message, OkText = okText, CancelText = cancelText, Danger = danger
        };
        await OnShow.Invoke(req);
        return await req.Tcs.Task;
    }
}

public class ConfirmRequest
{
    public string Title { get; set; } = "Onay";
    public string Message { get; set; } = "";
    public string OkText { get; set; } = "Evet";
    public string CancelText { get; set; } = "Vazgec";
    public bool Danger { get; set; } = true;
    public TaskCompletionSource<bool> Tcs { get; } = new();
}
