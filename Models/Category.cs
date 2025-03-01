using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0111.Models
{
    // Category Model
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        
        public string Name { get; set; }

        // Navigation property for related Tasks
        public ICollection<Task> Tasks { get; set; }
    }

}
