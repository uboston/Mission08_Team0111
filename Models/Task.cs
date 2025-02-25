namespace Mission08_Team0111.Models;

public class Task
{
    public int TaskID { get; set; }
    public string TaskName { get; set; }
    public DateTime DueDate { get; set; } 
    public int Quadrant { get; set; }
    public string Category { get; set; }
    public bool Completed { get; set; }

}
