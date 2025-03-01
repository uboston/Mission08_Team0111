using Microsoft.AspNetCore.Mvc;
using Mission08_Team0111.Models;
using Task = Mission08_Team0111.Models.Task;

namespace Mission08_Team0111.Controllers;

public class HomeController : Controller
{
    private ITaskRepository _repo;

    public HomeController(ITaskRepository temp)
    {
        _repo = temp;
    }

    public IActionResult Index()
    {
        var allTasks = _repo.Tasks
            .Where(x => !x.Completed)
            .OrderBy(x => x.DueDate)
            .ToList();
        
        return View(allTasks);
    }

    [HttpGet]
    public IActionResult CreateTask()
    {
        return View(new Task());
    }

    [HttpPost]
    public IActionResult CreateTask(Task task)
    {
        if (ModelState.IsValid)
        {
            _repo.AddTask(task);
            return RedirectToAction("Index");
        }
        else
        {
            return View("CreateTask", task);
        }
    }

    [HttpGet]
    public IActionResult EditTask(int id)
    {
        var task2Edit = _repo.Tasks
            .Single(x=>x.TaskID == id);
        
        return View(task2Edit);
    }

    [HttpPost]
    public IActionResult EditTask(Task updatedtask)
    {
        if (ModelState.IsValid)
        {
            _repo.UpdateTask(updatedtask);
            return RedirectToAction("Index");
        }
        else
        {
            return View("EditTask", updatedtask);
        }
    }

    public IActionResult DeleteTask(int id)
    {
        var deletedTask = _repo.Tasks
            .Single(x => x.TaskID == id);
        
        _repo.DeleteTask(deletedTask);
        
        return RedirectToAction("Index");
    } 
}
