using ManagementSystem.Models.Tasks;

namespace ManagementSystem.Services.TaskServices
{
    public interface ITaskService
    {
        Task<TaskItem> AddTaskAsync(TaskItem task);
        Task<TaskItem> UpdateTaskAsync(TaskItem task);
        Task<bool> DeleteTaskAsync(int taskId);
        Task<TaskItem> GetTaskAsync(int taskId);
        Task<IReadOnlyList<TaskItem>> GetTasksByProjectAsync(int projectId);
        Task<IReadOnlyList<TaskItem>> GetTasksByUserAsync(int userId);
        Task<IReadOnlyList<TaskItem>> GetTasksDueSoonAsync(int days);
    }
}
