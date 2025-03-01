using Microsoft.EntityFrameworkCore;
namespace Mission08_Team0111.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

        // Task Db Set
        public DbSet<Task> Tasks { get; set; }
        
        // Category Db Set
        public DbSet<Category> Categories { get; set; } 

        // Seed category data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category {CategoryID = 1, Name = "Home"},
                    new Category {CategoryID = 2, Name = "School"},
                    new Category {CategoryID = 3, Name = "Work"},
                    new Category {CategoryID = 4, Name = "Church"}
                    );
        }
    }
}
