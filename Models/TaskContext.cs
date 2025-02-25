using Microsoft.EntityFrameworkCore;
namespace Mission08_Team0111.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { } //Constructor
        
        public DbSet<Task> Tasks { get; set; } //Property
    }
}
