using ManagementSystem.Models.Projects;

namespace ManagementSystem.Services.ProjectServices
{
    public interface IProjectService
    {
        Task<Project> AddProjectAsync(Project project);
        Task<Project> UpdateProjectAsync(Project project);
        Task<bool> DeleteProjectAsync(int projectId);
        Task<Project> GetProjectAsync(int projectId);
        Task<IReadOnlyList<Project>> GetProjectsWithMostTasksAsync(int count);
    }
}
