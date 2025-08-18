using ManagementSystemTask.Models.Projects;

namespace ManagementSystemTask.Repositories.Projects
{
    public interface IProjectRepository
    {
        Task<Project> AddProjectAsync(Project project);
        Task<Project> UpdateProjectAsync(Project project);
        Task<bool> DeleteProjectAsync(int projectId);
        Task<Project> GetProjectAsync(int projectId);
        Task<IEnumerable<Project>> GetProjectsWithMostTasksAsync(int count = 5);
    }
}
