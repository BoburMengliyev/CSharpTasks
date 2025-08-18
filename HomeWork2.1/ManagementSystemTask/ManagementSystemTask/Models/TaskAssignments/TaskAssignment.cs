using ManagementSystemTask.Models.Tasks;
using ManagementSystemTask.Models.Users;

namespace ManagementSystemTask.Models.TaskAssignments
{
    public class TaskAssignment
    {
        public int Id { get; set; }

        public int TaskId { get; set; }
        public TaskItem Task { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime AssignedDate { get; set; }
        public virtual ICollection<TaskItem> Tasks { get; set; } = 
            new List<TaskItem>();
    }
}
