using Microsoft.AspNetCore.Mvc;
using HostelManagementMVC.Services;
namespace HostelManagementMVC.Controllers;
public class RoomsController(HostelStore store) : Controller
{
    public IActionResult Index() { ViewBag.Occupied=store.Students.GroupBy(s=>s.RoomNumber).ToDictionary(g=>g.Key,g=>g.Count()); return View(store.Rooms); }
}
