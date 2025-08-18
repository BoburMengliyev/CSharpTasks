using ManagementSystem.Models.Tasks;
using ManagementSystem.Services.TaskServices;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _tasks;

        public TasksController(ITaskService tasks)
        {
            _tasks = tasks;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TaskItem task)
        {
            if (!ModelState.IsValid) return ValidationProblem(ModelState);
            var created = await _tasks.AddTaskAsync(task);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] TaskItem task)
        {
            if (id != task.Id) return BadRequest("Route id and body id differ.");
            if (!ModelState.IsValid) return ValidationProblem(ModelState);

            var updated = await _tasks.UpdateTaskAsync(task);
            if (updated is null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var ok = await _tasks.DeleteTaskAsync(id);
            if (!ok) return NotFound();
            return NoContent();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var task = await _tasks.GetTaskAsync(id);
            if (task is null) return NotFound();
            return Ok(task);
        }

        [HttpGet("by-project/{projectId:int}")]
        public async Task<IActionResult> GetByProject(int projectId)
        {
            var list = await _tasks.GetTasksByProjectAsync(projectId);
            return Ok(list);
        }

        [HttpGet("by-user/{userId:int}")]
        public async Task<IActionResult> GetByUser(int userId)
        {
            var list = await _tasks.GetTasksByUserAsync(userId);
            return Ok(list);
        }

        [HttpGet("due-soon")]
        public async Task<IActionResult> GetDueSoon([FromQuery] int days = 7)
        {
            var list = await _tasks.GetTasksDueSoonAsync(days);
            return Ok(list);
        }
    }
}
