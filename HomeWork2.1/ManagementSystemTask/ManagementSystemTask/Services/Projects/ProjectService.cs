using ManagementSystemTask.Models.Projects;
using ManagementSystemTask.Repositories.Projects;

namespace ManagementSystemTask.Services.Projects
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository) =>
            _projectRepository = projectRepository;

        public async Task<Project> AddProjectAsync(Project project)
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project), "Project cannot be null.");

            if (string.IsNullOrWhiteSpace(project.Name))
                throw new ArgumentException("Project name cannot be empty.", nameof(project.Name));

            return await _projectRepository.AddProjectAsync(project);
        }

        public async Task<bool> DeleteProjectAsync(int projectId)
        {
            if (projectId <= 0)
                throw new ArgumentOutOfRangeException(nameof(projectId), "Project ID must be greater than zero.");

            return await _projectRepository.DeleteProjectAsync(projectId);
        }

        public async Task<Project> GetProjectAsync(int projectId)
        {
            if (projectId <= 0)
                throw new ArgumentOutOfRangeException(nameof(projectId), "Project ID must be greater than zero.");

            return await _projectRepository.GetProjectAsync(projectId);
        }

        public async Task<IEnumerable<Project>> GetProjectsWithMostTasksAsync(int count = 5)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count must be greater than zero.");

            return await _projectRepository.GetProjectsWithMostTasksAsync(count);
        }

        public async Task<Project> UpdateProjectAsync(Project project)
        {
            if (project is null)
                throw new ArgumentNullException(nameof(project), "Project cannot be null.");

            return await _projectRepository.UpdateProjectAsync(project);
        }
    }
}
