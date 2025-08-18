using ManagementSystem.Models.TaskAssignments;

namespace ManagementSystem.Services.TaskAssignmentServices
{
    public interface ITaskAssignmentService
    {
        Task<TaskAssignment> AssignTaskAsync(int taskId, int userId);
        Task<TaskAssignment> UpdateAssignmentAsync(int assignmentId, int taskId, int userId);
        Task<bool> DeleteAssignmentAsync(int assignmentId);
        Task<TaskAssignment> GetAssignmentAsync(int assignmentId);
        Task<IReadOnlyList<TaskAssignment>> GetAssignmentsByUserAsync(int userId);
        Task<IReadOnlyList<TaskAssignment>> GetAssignmentsByTaskAsync(int taskId);
    }
}
