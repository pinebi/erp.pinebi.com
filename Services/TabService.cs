namespace MACHINEBISS_Web.Services;

public class TabItem
{
    public string Id { get; set; } = "";
    public string Title { get; set; } = "";
    public string Url { get; set; } = "";
    public string Icon { get; set; } = "";
}

public class TabService
{
    public List<TabItem> OpenTabs { get; private set; } = new();
    public string? ActiveTabId { get; private set; }

    public event Action? OnTabsChanged;

    public void OpenTab(string id, string title, string url, string icon = "")
    {
        var existing = OpenTabs.FirstOrDefault(t => t.Id == id);
        if (existing != null)
        {
            ActiveTabId = existing.Id;
        }
        else
        {
            var tab = new TabItem { Id = id, Title = title, Url = url, Icon = icon };
            OpenTabs.Add(tab);
            ActiveTabId = tab.Id;
        }
        OnTabsChanged?.Invoke();
    }

    public void CloseTab(string id)
    {
        var tab = OpenTabs.FirstOrDefault(t => t.Id == id);
        if (tab != null)
        {
            var index = OpenTabs.IndexOf(tab);
            OpenTabs.Remove(tab);
            if (ActiveTabId == id)
            {
                ActiveTabId = OpenTabs.Count > 0
                    ? OpenTabs[Math.Min(index, OpenTabs.Count - 1)].Id
                    : null;
            }
        }
        OnTabsChanged?.Invoke();
    }

    public void SetActiveTab(string id)
    {
        ActiveTabId = id;
        OnTabsChanged?.Invoke();
    }
}
