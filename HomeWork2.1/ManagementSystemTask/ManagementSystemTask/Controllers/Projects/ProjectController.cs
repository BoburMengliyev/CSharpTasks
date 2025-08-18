using ManagementSystemTask.Models.Projects;
using ManagementSystemTask.Services.Projects;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystemTask.Controllers.Projects
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService) =>
            _projectService = projectService;

        [HttpPost]
        public async Task<IActionResult> AddProject([FromBody] Project project) =>
            Ok(await _projectService.AddProjectAsync(project));

        [HttpPut]
        public async Task<IActionResult> UpdateProject([FromBody] Project project) =>
            Ok(await _projectService.UpdateProjectAsync(project));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(int id) =>
            Ok(await _projectService.DeleteProjectAsync(id));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject(int id) =>
            Ok(await _projectService.GetProjectAsync(id));

        [HttpGet("most-tasks")]
        public async Task<IActionResult> GetProjectsWithMostTasks([FromQuery] int count = 5) =>
            Ok(await _projectService.GetProjectsWithMostTasksAsync(count));
    }
}
