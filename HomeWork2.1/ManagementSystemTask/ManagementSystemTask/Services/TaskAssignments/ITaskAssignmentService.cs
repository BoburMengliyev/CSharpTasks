using ManagementSystemTask.Models.TaskAssignments;

namespace ManagementSystemTask.Services.TaskAssignments
{
    public interface ITaskAssignmentService
    {
        Task<TaskAssignment> AssignTaskAsync(TaskAssignment assignment);
        Task<TaskAssignment> UpdateAssignmentAsync(TaskAssignment assignment);
        Task<bool> DeleteAssignmentAsync(int assignmentId);
        Task<TaskAssignment?> GetAssignmentAsync(int assignmentId);
        Task<IEnumerable<TaskAssignment>> GetAssignmentsByUserAsync(int userId);
        Task<IEnumerable<TaskAssignment>> GetAssignmentsByTaskAsync(int taskId);
    }
}
