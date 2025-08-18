using ManagementSystemTask.Data;
using ManagementSystemTask.Models.TaskAssignments;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystemTask.Repositories.TaskAssignments
{
    public class TaskAssignmentRepository : ITaskAssignmentRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskAssignmentRepository(ApplicationDbContext context) =>
            _context = context;

        public async Task<TaskAssignment> AssignTaskAsync(TaskAssignment assignment)
        {
            await _context.TaskAssignments.AddAsync(assignment);
            await _context.SaveChangesAsync();

            return assignment;
        }

        public async Task<TaskAssignment> UpdateAssignmentAsync(TaskAssignment assignment)
        {
            TaskAssignment existingAssignment = await _context.TaskAssignments.FindAsync(assignment.Id);

            if (existingAssignment is null)
                throw new KeyNotFoundException($"Assignment with ID {assignment.Id} not found.");

            existingAssignment.TaskId = assignment.TaskId;
            existingAssignment.UserId = assignment.UserId;

            await _context.SaveChangesAsync();

            return existingAssignment;
        }

        public async Task<bool> DeleteAssignmentAsync(int assignmentId)
        {
            TaskAssignment assignment = await _context.TaskAssignments.FindAsync(assignmentId);

            if (assignment is null)
                return false;

            _context.TaskAssignments.Remove(assignment);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<TaskAssignment?> GetAssignmentAsync(int assignmentId) =>
            await _context.TaskAssignments
                .AsNoTracking()
                .Include(a => a.Task)
                .Include(a => a.User)
                .FirstOrDefaultAsync(a => a.Id == assignmentId);

        public async Task<IEnumerable<TaskAssignment>> GetAssignmentsByUserAsync(int userId) =>
            await _context.TaskAssignments
                .AsNoTracking()
                .Include(a => a.Task)
                .Include(a => a.User)
                .Where(a => a.UserId == userId)
                .ToListAsync();

        public async Task<IEnumerable<TaskAssignment>> GetAssignmentsByTaskAsync(int taskId) =>
            await _context.TaskAssignments
                .AsNoTracking()
                .Include(a => a.Task)
                .Include(a => a.User)
                .Where(a => a.TaskId == taskId)
                .ToListAsync();
    }
}
