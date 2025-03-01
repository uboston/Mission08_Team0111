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
        // Get all tasks that have not been completed. 
        var allTasks = _repo.GetTaskswithCat()
            .Where(x => !x.Completed)
            .OrderBy(x => x.DueDate)
            .ToList();
        
        // Pass them to the view
        return View(allTasks);
    }

    // Get method, just passing category viewbag
    [HttpGet]
    public IActionResult CreateTask()
    {
        ViewBag.Categories = _repo.Categories;

        return View(new Task());
    }

    // Post method with model validation
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
            // Send them back if input is wrong
            ViewBag.Categories = _repo.Categories;

            return View("CreateTask", task);
        }
    }

    
    // Get method sending the task record based on the TaskID
    [HttpGet]
    public IActionResult EditTask(int id)
    {
        var task2Edit = _repo.GetTaskswithCat()
            .Single(x=>x.TaskID == id);

        ViewBag.Categories = _repo.Categories;

        return View(task2Edit);
    }

    // Updates task, checking for model validation
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
            ViewBag.Categories = _repo.Categories;

            return View("EditTask", updatedtask);
        }
    }

    // Deletes task from Database based on TaskID
    public IActionResult DeleteTask(int id)
    {
        var deletedTask = _repo.GetTaskswithCat()
            .Single(x => x.TaskID == id);
        
        _repo.DeleteTask(deletedTask);
        
        return RedirectToAction("Index");
    } 
}
