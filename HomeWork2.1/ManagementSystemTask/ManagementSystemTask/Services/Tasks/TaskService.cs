using ManagementSystemTask.Models.Tasks;
using ManagementSystemTask.Repositories.Tasks;

namespace ManagementSystemTask.Services.Tasks
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repository;

        public TaskService(ITaskRepository repository) =>
            _repository = repository;

        public async Task<TaskItem> AddTaskAsync(TaskItem task)
        {
            if (task is null)
                throw new ArgumentNullException(nameof(task), "Task cannot be null.");

            return await _repository.AddTaskAsync(task);
        }

        public async Task<bool> DeleteTaskAsync(int taskId)
        {
            if (taskId <= 0)
                throw new ArgumentOutOfRangeException(nameof(taskId), "Task ID must be greater than zero.");

            return await _repository.DeleteTaskAsync(taskId);
        }

        public async Task<TaskItem> GetTaskAsync(int taskId)
        {
            if (taskId <= 0)
                throw new ArgumentOutOfRangeException(nameof(taskId), "Task ID must be greater than zero.");

            return await _repository.GetTaskAsync(taskId);
        }

        public async Task<IEnumerable<TaskItem>> GetTasksByProjectAsync(int projectId)
        {
            if (projectId <= 0)
                throw new ArgumentOutOfRangeException(nameof(projectId), "Project ID must be greater than zero.");

            return await _repository.GetTasksByProjectAsync(projectId);
        }

        public async Task<IEnumerable<TaskItem>> GetTasksByUserAsync(int userId)
        {
            if (userId <= 0)
                throw new ArgumentOutOfRangeException(nameof(userId), "User ID must be greater than zero.");

            return await _repository.GetTasksByUserAsync(userId);
        }

        public async Task<IEnumerable<TaskItem>> GetTasksDueSoonAsync(int days)
        {
            if (days <= 0)
                throw new ArgumentOutOfRangeException(nameof(days), "Days must be greater than zero.");

            return await _repository.GetTasksDueSoonAsync(days);
        }

        public async Task<TaskItem> UpdateTaskAsync(TaskItem task)
        {
            if (task is null)
                throw new ArgumentNullException(nameof(task), "Task cannot be null.");

            return await _repository.UpdateTaskAsync(task);
        }
    }
}
