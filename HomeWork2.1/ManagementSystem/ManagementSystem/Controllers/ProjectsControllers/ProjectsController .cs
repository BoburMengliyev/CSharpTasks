using ManagementSystem.Models.Projects;
using ManagementSystem.Services.ProjectServices;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projects;

        public ProjectsController(IProjectService projects)
        {
            _projects = projects;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Project project)
        {
            if (!ModelState.IsValid) return ValidationProblem(ModelState);
            var created = await _projects.AddProjectAsync(project);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] Project project)
        {
            if (id != project.Id) return BadRequest("Route id and body id differ.");
            if (!ModelState.IsValid) return ValidationProblem(ModelState);

            var updated = await _projects.UpdateProjectAsync(project);
            if (updated is null) return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var ok = await _projects.DeleteProjectAsync(id);
            if (!ok) return Conflict("Project has related tasks or not found.");
            return NoContent();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var project = await _projects.GetProjectAsync(id);
            if (project is null) return NotFound();
            return Ok(project);
        }

        [HttpGet("most-tasks")]
        public async Task<IActionResult> GetWithMostTasks([FromQuery] int count = 5)
        {
            var list = await _projects.GetProjectsWithMostTasksAsync(count);
            return Ok(list);
        }
    }
}
