using ManagementSystem.Data;
using ManagementSystem.Models.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Services.TaskServices
{
    public class TaskService : ITaskService
    {
        private readonly ManagementSystemDbContext _context;

        public TaskService(ManagementSystemDbContext context)
        {
            _context = context;
        }

        public async Task<TaskItem> AddTaskAsync(TaskItem task)
        {
            if (string.IsNullOrWhiteSpace(task.Title))
                throw new ArgumentException("Task title is required.", nameof(task.Title));
            if (task.ProjectId <= 0)
                throw new ArgumentException("Invalid ProjectId.", nameof(task.ProjectId));
            await _context.TaskItems.AddAsync(task);
            await _context.SaveChangesAsync();

            return task;
        }

        public async Task<TaskItem> UpdateTaskAsync(TaskItem task)
        {
            var existing = await _context.TaskItems
                                         .FirstOrDefaultAsync(t => t.Id == task.Id);
            if (existing is null) return null;
            if (string.IsNullOrWhiteSpace(task.Title))
                throw new ArgumentException("Task title is required.", nameof(task.Title));
            if (task.ProjectId <= 0)
                throw new ArgumentException("Invalid ProjectId.", nameof(task.ProjectId));
            existing.Title = task.Title;
            existing.Description = task.Description;
            existing.DueDate = task.DueDate;
            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteTaskAsync(int taskId)
        {
            var task = await _context.TaskItems
                                     .FirstOrDefaultAsync(t => t.Id == taskId);
            if (task is null) return false;
            _context.TaskItems.Remove(task);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<TaskItem> GetTaskAsync(int taskId)
        {
            var task = await _context.TaskItems
                                     .FirstOrDefaultAsync(t => t.Id == taskId);
            if (task is null) throw new KeyNotFoundException("Task not found.");

            return task;
        }

        public async Task<IReadOnlyList<TaskItem>> GetTasksByProjectAsync(int projectId)
        {
            if (projectId <= 0) throw new ArgumentException("Invalid ProjectId.", nameof(projectId));
            return await _context.TaskItems
                                 .Where(t => t.ProjectId == projectId)
                                 .ToListAsync();
        }

        public async Task<IReadOnlyList<TaskItem>> GetTasksByUserAsync(int userId)
        {
            if (userId <= 0) throw new ArgumentException("Invalid UserId.", nameof(userId));
            return await _context.TaskItems
                                 .Where(t => t.ProjectId == userId)
                                 .ToListAsync();
        }

        public async Task<IReadOnlyList<TaskItem>> GetTasksDueSoonAsync(int days)
        {
            if (days <= 0) throw new ArgumentException("Days must be greater than zero.", nameof(days));

            var now = DateTime.UtcNow;
            var dueDate = now.AddDays(days);

            return await _context.TaskItems
                .AsNoTracking()
                .Where(t => t.DueDate >= now && t.DueDate <= dueDate)
                .OrderBy(t => t.DueDate)
                .ToListAsync();
        }

    }
}
