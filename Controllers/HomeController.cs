using Microsoft.AspNetCore.Mvc;
using Mission08_Team0111.Models;

namespace Mission08_Team0111.Controllers;

public class HomeController : Controller
{
    private readonly TaskContext _context;

    public HomeController(TaskContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }
}
