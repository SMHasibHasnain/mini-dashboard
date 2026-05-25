using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mini_dashboard.Models;
using mini_dashboard.ViewModels;

namespace mini_dashboard.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var rooms = new List<Room>
        {
            new Room { RoomNumber = 101, RoomType = "AC", IsAvailable = true},
            new Room { RoomNumber = 102, RoomType = "Non AC", IsAvailable = false},
            new Room { RoomNumber = 103, RoomType = "Non AC", IsAvailable = true},
            new Room { RoomNumber = 104, RoomType = "AC", IsAvailable = true},
            new Room { RoomNumber = 105, RoomType = "Non AC", IsAvailable = true},
            new Room { RoomNumber = 106, RoomType = "AC", IsAvailable = true},
            new Room { RoomNumber = 107, RoomType = "AC", IsAvailable = true},                
            new Room { RoomNumber = 108, RoomType = "Non AC", IsAvailable = false}
        };

        var members = new List<Member>
        {
            new Member { Id = 1, Name = "Rohim", DueAmount = 500m, Phone = "013434343"},
            new Member { Id = 2, Name = "Korim", DueAmount = 400m, Phone = "017434344"}
        };

        var viewModel = new DashboardViewModel
        {
            Rooms = rooms,
            Members = members,
            DashboardMessage = "Everything is working Fine!"
        };

        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
