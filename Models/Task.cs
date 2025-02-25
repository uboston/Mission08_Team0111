using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0111.Models;

public class Task
{
    [Key]
    [Required]
    public int TaskID { get; set; }
 
    public required string TaskName { get; set; }
    public DateTime DueDate { get; set; } 
    public int Quadrant { get; set; }
    public required string Category { get; set; }
    public bool Completed { get; set; }

}
