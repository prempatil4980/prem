using Microsoft.AspNetCore.Mvc;
using HostelManagementMVC.Services;
namespace HostelManagementMVC.Controllers;
public class HomeController(HostelStore store) : Controller
{
    public IActionResult Index() { ViewBag.StudentCount=store.Students.Count; ViewBag.RoomCount=store.Rooms.Count; ViewBag.OccupiedRooms=store.Rooms.Count(r => store.Occupied(r.Number)>0); ViewBag.AvailableBeds=store.Rooms.Sum(r=>r.Capacity)-store.Students.Count; ViewBag.RecentStudents=store.Students.OrderByDescending(s=>s.Id).Take(5).ToList(); return View(); }
}
