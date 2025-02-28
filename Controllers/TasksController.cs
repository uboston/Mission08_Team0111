using Microsoft.AspNetCore.Mvc;
using Mission08_Team0111.Models;

namespace Mission08_Team0111.Controllers;

public class TasksController : Controller
{
    private readonly TaskContext _context;

    public TasksController(TaskContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult CreateTask()
    {
        return View(); // Must match Views/Tasks/CreateTask.cshtml
    }
}
