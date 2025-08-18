using ManagementSystem.Models.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Models.Projects
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(2000)]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ICollection<TaskItem> TaskItems { get; set; } = new List<TaskItem>();
    }
}
