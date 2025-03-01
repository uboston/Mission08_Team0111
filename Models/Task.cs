using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_Team0111.Models;

public class Task
{
    [Key]
    [Required]
    public int TaskID { get; set; }

    // Require Task Name
    [Required]
    public string TaskName { get; set; }
    
    // Validation for date
    [DataType(DataType.Date)]
    [Range(typeof(DateTime), "2025-01-01", "2026-01-01", ErrorMessage = "Due date must be between Jan 1, 2025, and Jan 1, 2026.")]
    public DateTime DueDate { get; set; }
    public int Quadrant { get; set; }
    public bool Completed { get; set; }
    
    // Foreign Key
    [Required]
    [ForeignKey("CategoryID")]
    public int? CategoryID { get; set; } 
    public Category? Category { get; set; }
}
