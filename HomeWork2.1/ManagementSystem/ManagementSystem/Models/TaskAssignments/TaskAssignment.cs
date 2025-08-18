using ManagementSystem.Models.Tasks;
using ManagementSystem.Models.Users;

namespace ManagementSystem.Models.TaskAssignments
{
    public class TaskAssignment
    {
        public int Id { get; set; }
        public TaskItem TaskItem { get; set; }
        public int TaskItemId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public DateTime AssignedDate { get; set; }
    }
}
