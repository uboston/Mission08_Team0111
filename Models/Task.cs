using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    
    public bool Completed { get; set; }
    
 
    [ForeignKey("CategoryID")]
    public int? CategoryID { get; set; } // Foreign Key

    // Navigation property
    public Category? Category { get; set; }
}
