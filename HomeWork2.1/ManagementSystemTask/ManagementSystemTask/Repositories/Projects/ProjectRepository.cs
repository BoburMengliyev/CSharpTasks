using ManagementSystemTask.Data;
using ManagementSystemTask.Models.Projects;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystemTask.Repositories.Projects
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _context;

        public ProjectRepository(ApplicationDbContext context) =>
            _context = context;

        public async Task<Project> AddProjectAsync(Project project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            return project;
        }

        public async Task<Project> UpdateProjectAsync(Project project)
        {
            var existingProject = await _context.Projects.FindAsync(project.Id);

            if (existingProject is null)
                throw new KeyNotFoundException($"Project with ID {project.Id} not found.");

            existingProject.Name = project.Name;
            existingProject.Description = project.Description;
            existingProject.StartDate = project.StartDate;
            existingProject.EndDate = project.EndDate;

            await _context.SaveChangesAsync();

            return project;
        }

        public async Task<bool> DeleteProjectAsync(int projectId)
        {
            Project project = await _context.Projects.FindAsync(projectId);

            if (project is null)
                return false;

            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Project> GetProjectAsync(int projectId) =>
            await _context.Projects
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == projectId);

        public async Task<IEnumerable<Project>> GetProjectsWithMostTasksAsync(int count = 5)
        {
            return await _context.Projects
                .AsNoTracking()
                .Include(p => p.Tasks)
                .OrderByDescending(p => p.Tasks.Count)
                .Take(count)
                .ToListAsync();
        }
    }
}
