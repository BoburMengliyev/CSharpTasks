using ManagementSystemTask.Models.TaskAssignments;
using ManagementSystemTask.Repositories.TaskAssignments;

namespace ManagementSystemTask.Services.TaskAssignments
{
    public class TaskAssignmentService : ITaskAssignmentService
    {
        private readonly ITaskAssignmentRepository _repository;

        public TaskAssignmentService(ITaskAssignmentRepository repository) =>
            _repository = repository;

        public async Task<TaskAssignment> AssignTaskAsync(TaskAssignment assignment)
        {
            if (assignment is null)
                throw new ArgumentNullException(nameof(assignment), "Assignment cannot be null.");

            return await _repository.AssignTaskAsync(assignment);
        }

        public async Task<bool> DeleteAssignmentAsync(int assignmentId)
        {
            if (assignmentId <= 0)
                throw new ArgumentOutOfRangeException(nameof(assignmentId), "Assignment ID must be greater than zero.");

            return await _repository.DeleteAssignmentAsync(assignmentId);
        }

        public async Task<TaskAssignment> GetAssignmentAsync(int assignmentId)
        {
            if (assignmentId <= 0)
                throw new ArgumentOutOfRangeException(nameof(assignmentId), "Assignment ID must be greater than zero.");

            return await _repository.GetAssignmentAsync(assignmentId);
        }

        public async Task<IEnumerable<TaskAssignment>> GetAssignmentsByTaskAsync(int taskId)
        {
            if (taskId <= 0)
                throw new ArgumentOutOfRangeException(nameof(taskId), "Task ID must be greater than zero.");

            return await _repository.GetAssignmentsByTaskAsync(taskId);
        }

        public async Task<IEnumerable<TaskAssignment>> GetAssignmentsByUserAsync(int userId)
        {
            if (userId <= 0)
                throw new ArgumentOutOfRangeException(nameof(userId), "User ID must be greater than zero.");

            return await _repository.GetAssignmentsByUserAsync(userId);
        }

        public async Task<TaskAssignment> UpdateAssignmentAsync(TaskAssignment assignment)
        {
            if (assignment is null)
                throw new ArgumentNullException(nameof(assignment), "Assignment cannot be null.");

            return await _repository.UpdateAssignmentAsync(assignment);
        }
    }
}
