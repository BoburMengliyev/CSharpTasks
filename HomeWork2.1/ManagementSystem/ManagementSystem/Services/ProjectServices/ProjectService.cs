using ManagementSystem.Data;
using ManagementSystem.Models.Projects;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Services.ProjectServices
{
    public class ProjectService : IProjectService
    {
        private readonly ManagementSystemDbContext _context;

        public ProjectService(ManagementSystemDbContext context) =>
            _context = context;

        public async Task<Project> AddProjectAsync(Project project)
        {
            if (string.IsNullOrWhiteSpace(project.Name))
                throw new ArgumentException("Project name is required.", nameof(project.Name));

            if (project.EndDate.HasValue && project.EndDate < project.StartDate)
                throw new ArgumentException("EndDate cannot be earlier than StartDate.", nameof(project.EndDate));

            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();

            return project;
        }

        public async Task<Project> UpdateProjectAsync(Project project)
        {
            Project existing = await _context.Projects
                                         .FirstOrDefaultAsync(p => p.Id == project.Id);

            if (existing is null) return null;

            if (string.IsNullOrWhiteSpace(project.Name))
                throw new ArgumentException("Project name is required.", nameof(project.Name));

            if (project.EndDate.HasValue && project.EndDate < project.StartDate)
                throw new ArgumentException("EndDate cannot be earlier than StartDate.", nameof(project.EndDate));

            existing.Name = project.Name;
            existing.Description = project.Description;
            existing.StartDate = project.StartDate;
            existing.EndDate = project.EndDate;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteProjectAsync(int projectId)
        {
            bool hasTasks = await _context.TaskItems
                                         .AsNoTracking()
                                         .AnyAsync(t => t.ProjectId == projectId);
            if (hasTasks)
            {
                return false;
            }

            var project = await _context.Projects.FindAsync(new object[] { projectId });
            if (project is null) return false;

            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Project?> GetProjectAsync(int projectId)
        {
            return await _context.Projects
                                 .AsNoTracking()
                                 .Include(p => p.TaskItems)
                                 .FirstOrDefaultAsync(p => p.Id == projectId);
        }

        public async Task<IReadOnlyList<Project>> GetProjectsWithMostTasksAsync(int count)
        {
            if (count <= 0) return Array.Empty<Project>();

            var projects = await _context.Projects
                                         .AsNoTracking()
                                         .OrderByDescending(p => p.TaskItems.Count)
                                         .Take(count)
                                         .ToListAsync();

            return projects;
        }
    }
}
