using ManagementSystem.Models.TaskAssignments;
using ManagementSystem.Models.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Models.Users
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(320)]
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
        public ICollection<TaskItem> TaskItems { get; set; } = new List<TaskItem>();
        public ICollection<TaskAssignment> TaskAssignments { get; set; } = 
            new List<TaskAssignment>();
    }
}
