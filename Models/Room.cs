using System.Diagnostics.Eventing.Reader;

namespace mini_dashboard;

public class Room
{
    public int RoomNumber { get; set; }
    public string RoomType { get; set; } = string.Empty;
    public bool IsAvailable { get; set; }
}
