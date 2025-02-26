using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0111.Models;

namespace Mission08_Team0111.Controllers;

// Main controller
public class HomeController : Controller
{
        private TaskContext _context;
    
        public HomeController (TaskContext temp)
        {
            _context = temp;
        }
    public IActionResult Index()
    {
        return View();
    }
    
}