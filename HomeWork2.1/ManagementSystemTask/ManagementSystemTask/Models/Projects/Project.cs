using ManagementSystemTask.Models.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystemTask.Models.Projects
{
    public class Project
    {
        public int Id { get; set; }
        [Required, MaxLength(200)]
        public string Name { get; set; }
        [Required, MaxLength(2000)]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<TaskItem> Tasks { get; set; } = 
            new List<TaskItem>();
    }
}
