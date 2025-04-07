using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        int time = DateTime.Now.Hour;
        ViewBag.selamlama = time > 12 ? "İyi Günler" : "Günaydın";
        int UserCount = Repository.Users.Where(i => i.WillAttent == true).Count();

        var meetingInfo = new MeetingInfo()
        {
            Id = 1,
            Date = new DateTime(2024, 01,20,20,0,0),
            Location = "İstanbul",
            NumberOfPeople = UserCount
            
        };
        
        return View(meetingInfo);
    }
}