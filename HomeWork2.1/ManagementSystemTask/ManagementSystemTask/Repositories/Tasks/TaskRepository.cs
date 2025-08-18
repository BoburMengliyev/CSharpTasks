using ManagementSystemTask.Data;
using ManagementSystemTask.Models.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystemTask.Repositories.Tasks
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskRepository(ApplicationDbContext context) =>
            _context = context;

        public async Task<TaskItem> AddTaskAsync(TaskItem task)
        {
            await _context.TaskItems.AddAsync(task);
            await _context.SaveChangesAsync();

            return task;
        }

        public async Task<TaskItem> UpdateTaskAsync(TaskItem task)
        {
            TaskItem existingTask = await _context.TaskItems.FindAsync(task.Id);

            if (existingTask is null)
                throw new KeyNotFoundException($"Task with ID {task.Id} not found.");

            existingTask.Title = task.Title;
            existingTask.Description = task.Description;
            existingTask.DueDate = task.DueDate;
            existingTask.ProjectId = task.ProjectId;
            existingTask.UserId = task.UserId;

            await _context.SaveChangesAsync();
            return existingTask;
        }

        public async Task<bool> DeleteTaskAsync(int taskId)
        {
            TaskItem task = await _context.TaskItems.FirstOrDefaultAsync(t => t.Id == taskId);

            if (task is null)
                return false;

            _context.TaskItems.Remove(task);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<TaskItem?> GetTaskAsync(int taskId) =>
            await _context.TaskItems
                .FindAsync(taskId);

        public async Task<IEnumerable<TaskItem>> GetTasksByProjectAsync(int projectId) =>
            await _context.TaskItems
                .Include(t => t.Project)
                .AsNoTracking()
                .Where(t => t.ProjectId == projectId)
                .ToListAsync();

        public async Task<IEnumerable<TaskItem>> GetTasksByUserAsync(int userId) =>
            await _context.TaskItems
                .Include(t => t.User)
                .AsNoTracking()
                .Where(t => t.UserId == userId)
                .ToListAsync();

        public async Task<IEnumerable<TaskItem>> GetTasksDueSoonAsync(int days) =>
            await _context.TaskItems
                .AsNoTracking()
                .Where(t => t.DueDate >= DateTime.UtcNow && 
                            t.DueDate <= DateTime.UtcNow.AddDays(days))
                .OrderBy(t => t.DueDate)
                .ToListAsync();
    }
}
