using ManagementSystemTask.Models.Projects;
using ManagementSystemTask.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystemTask.Models.Tasks
{
    public class TaskItem
    {
        public int Id { get; set; }
        
        [Required, MaxLength(200)]
        public string Title { get; set; }
        
        [Required, MaxLength(2000)]
        public string Description { get; set; }
        
        public DateTime DueDate { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
