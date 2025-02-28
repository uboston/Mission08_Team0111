namespace Mission08_Team0111.Models;

public interface ITaskRepository
{
    List<Task> Tasks { get; }
    
    public void AddTask(Task task);
    public void UpdateTask(Task task);
    public void DeleteTask(Task task);
    
}