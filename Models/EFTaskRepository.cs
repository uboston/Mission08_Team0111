using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0111.Models;

public class EFTaskRepository : ITaskRepository
{
    private TaskContext context;
    
    public EFTaskRepository(TaskContext temp)
    {
        context = temp;
    }

    public List<Task> Tasks => context.Tasks.ToList();
    public List<Category> Categories => context.Categories.OrderBy(x=>x.Name).ToList();

    public void AddTask(Task task)
    {
        context.Tasks.Add(task);
        context.SaveChanges();
    }

    public void UpdateTask(Task task)
    {
        context.Tasks.Update(task);
        context.SaveChanges();
    }

    public void DeleteTask(Task task)
    {
        context.Tasks.Remove(task);
        context.SaveChanges();
    }
}