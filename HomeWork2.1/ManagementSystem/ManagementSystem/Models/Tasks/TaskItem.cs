using ManagementSystem.Models.Projects;
using ManagementSystem.Models.TaskAssignments;
using ManagementSystem.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Models.Tasks
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(2000)]
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public ICollection<TaskAssignment> TaskAssignments { get; set; } = 
            new List<TaskAssignment>();
    }
}
