using ManagementSystem.Data;
using ManagementSystem.Models.TaskAssignments;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Services.TaskAssignmentServices
{
    public class TaskAssignmentService : ITaskAssignmentService
    {
        private readonly ManagementSystemDbContext _context;

        public TaskAssignmentService(ManagementSystemDbContext context) =>
            _context = context;

        public async Task<TaskAssignment> AssignTaskAsync(int taskItemId, int userId)
        {
            if (taskItemId <= 0) throw new ArgumentException("Invalid taskItemId.", nameof(taskItemId));
            if (userId <= 0) throw new ArgumentException("Invalid userId.", nameof(userId));

            var taskExists = await _context.TaskItems
                                           .AsNoTracking()
                                           .AnyAsync(t => t.Id == taskItemId);
            if (!taskExists) throw new KeyNotFoundException("TaskItem not found.");

            var userExists = await _context.Users
                                           .AsNoTracking()
                                           .AnyAsync(u => u.Id == userId);
            if (!userExists) throw new KeyNotFoundException("User not found.");

            var duplicate = await _context.TaskAssignments
                                          .AsNoTracking()
                                          .AnyAsync(ta => ta.TaskItemId == taskItemId && ta.UserId == userId);
            if (duplicate) throw new InvalidOperationException("This user is already assigned to the task.");

            var assignment = new TaskAssignment
            {
                TaskItemId = taskItemId,
                UserId = userId,
                AssignedDate = DateTime.UtcNow
            };

            await _context.TaskAssignments.AddAsync(assignment);
            await _context.SaveChangesAsync();

            return assignment;
        }

        public async Task<TaskAssignment> UpdateAssignmentAsync(int assignmentId, int taskItemId, int userId)
        {
            if (assignmentId <= 0) throw new ArgumentException("Invalid assignmentId.", nameof(assignmentId));
            if (taskItemId <= 0) throw new ArgumentException("Invalid taskItemId.", nameof(taskItemId));
            if (userId <= 0) throw new ArgumentException("Invalid userId.", nameof(userId));

            var assignment = await _context.TaskAssignments
                                           .FirstOrDefaultAsync(a => a.Id == assignmentId);
            if (assignment is null) throw new KeyNotFoundException("Assignment not found.");

            var taskExists = await _context.TaskItems
                                           .AsNoTracking()
                                           .AnyAsync(t => t.Id == taskItemId);
            if (!taskExists) throw new KeyNotFoundException("TaskItem not found.");

            var userExists = await _context.Users
                                           .AsNoTracking()
                                           .AnyAsync(u => u.Id == userId);
            if (!userExists) throw new KeyNotFoundException("User not found.");

            var duplicate = await _context.TaskAssignments
                                          .AsNoTracking()
                                          .AnyAsync(ta =>
                                              ta.TaskItemId == taskItemId &&
                                              ta.UserId == userId &&
                                              ta.Id != assignmentId);
            if (duplicate) throw new InvalidOperationException("This user is already assigned to the task.");

            assignment.TaskItemId = taskItemId;
            assignment.UserId = userId;

            await _context.SaveChangesAsync();

            return assignment;
        }

        public async Task<bool> DeleteAssignmentAsync(int assignmentId)
        {
            if (assignmentId <= 0) throw new ArgumentException("Invalid assignmentId.", nameof(assignmentId));

            var assignment = await _context.TaskAssignments
                                           .FirstOrDefaultAsync(a => a.Id == assignmentId);
            if (assignment is null) return false;

            _context.TaskAssignments.Remove(assignment);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<TaskAssignment> GetAssignmentAsync(int assignmentId)
        {
            if (assignmentId <= 0) throw new ArgumentException("Invalid assignmentId.", nameof(assignmentId));

            return await _context.TaskAssignments
                                 .AsNoTracking()
                                 .FirstOrDefaultAsync(a => a.Id == assignmentId);
        }

        public async Task<IReadOnlyList<TaskAssignment>> GetAssignmentsByUserAsync(int userId)
        {
            if (userId <= 0) throw new ArgumentException("Invalid userId.", nameof(userId));

            return await _context.TaskAssignments
                                 .AsNoTracking()
                                 .Where(ta => ta.UserId == userId)
                                 .OrderByDescending(ta => ta.AssignedDate)
                                 .ToListAsync();
        }

        public async Task<IReadOnlyList<TaskAssignment>> GetAssignmentsByTaskAsync(int taskItemId)
        {
            if (taskItemId <= 0) throw new ArgumentException("Invalid taskItemId.", nameof(taskItemId));

            return await _context.TaskAssignments
                                 .AsNoTracking()
                                 .Where(ta => ta.TaskItemId == taskItemId)
                                 .OrderByDescending(ta => ta.AssignedDate)
                                 .ToListAsync();
        }
    }
}
