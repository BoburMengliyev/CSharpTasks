using ManagementSystem.Services.TaskAssignmentServices;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskAssignmentsController : ControllerBase
    {
        private readonly ITaskAssignmentService _assignments;

        public TaskAssignmentsController(ITaskAssignmentService assignments)
        {
            _assignments = assignments;
        }

        public record AssignRequest(int TaskItemId, int UserId);
        public record UpdateAssignmentRequest(int TaskItemId, int UserId);

        [HttpPost]
        public async Task<IActionResult> Assign([FromBody] AssignRequest req)
        {
            await _assignments.AssignTaskAsync(req.TaskItemId, req.UserId);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateAssignmentRequest req)
        {
            await _assignments.UpdateAssignmentAsync(id, req.TaskItemId, req.UserId);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var ok = await _assignments.DeleteAssignmentAsync(id);
            if (!ok) return NotFound();
            return NoContent();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var assignment = await _assignments.GetAssignmentAsync(id);
            if (assignment is null) return NotFound();
            return Ok(assignment);
        }

        [HttpGet("by-user/{userId:int}")]
        public async Task<IActionResult> GetByUser(int userId)
        {
            var list = await _assignments.GetAssignmentsByUserAsync(userId);
            return Ok(list);
        }

        [HttpGet("by-task/{taskItemId:int}")]
        public async Task<IActionResult> GetByTask(int taskItemId)
        {
            var list = await _assignments.GetAssignmentsByTaskAsync(taskItemId);
            return Ok(list);
        }
    }
}
