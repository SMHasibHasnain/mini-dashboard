namespace mini_dashboard.ViewModels;

public class DashboardViewModel
{
    public IEnumerable<Room>? Rooms { get; set; }
    public IEnumerable<Member>? Members { get; set; }
    public string DashboardMessage { get; set; } = string.Empty;
}
