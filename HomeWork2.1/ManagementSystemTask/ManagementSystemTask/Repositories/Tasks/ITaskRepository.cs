using ManagementSystemTask.Models.Tasks;

namespace ManagementSystemTask.Repositories.Tasks
{
    public interface ITaskRepository
    {
        Task<TaskItem> AddTaskAsync(TaskItem task);
        Task<TaskItem> UpdateTaskAsync(TaskItem task);
        Task<bool> DeleteTaskAsync(int taskId);
        Task<TaskItem?> GetTaskAsync(int taskId);
        Task<IEnumerable<TaskItem>> GetTasksByProjectAsync(int projectId);
        Task<IEnumerable<TaskItem>> GetTasksByUserAsync(int userId);
        Task<IEnumerable<TaskItem>> GetTasksDueSoonAsync(int days);
    }
}
