using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0111.Models;

public class Task
{
    [Key]
    [Required]
    public int TaskID { get; set; }
 
    [Required]
    public string TaskName { get; set; }
    public DateTime DueDate { get; set; } 
    public int Quadrant { get; set; }
    [Required]
    public string Category { get; set; }
    public bool Completed { get; set; }

}
