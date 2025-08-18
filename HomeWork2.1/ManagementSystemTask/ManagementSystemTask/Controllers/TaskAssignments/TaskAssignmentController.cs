using ManagementSystemTask.Models.TaskAssignments;
using ManagementSystemTask.Services.TaskAssignments;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystemTask.Controllers.TaskAssignments
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskAssignmentsController : ControllerBase
    {
        private readonly ITaskAssignmentService _taskAssignmentService;

        public TaskAssignmentsController(ITaskAssignmentService taskAssignmentService) =>
            _taskAssignmentService = taskAssignmentService;

        [HttpPost]
        public async Task<IActionResult> AssignTask(TaskAssignment assignment) =>
            Ok(await _taskAssignmentService.AssignTaskAsync(assignment));

        [HttpPut]
        public async Task<IActionResult> UpdateAssignment(TaskAssignment assignment) =>
            Ok(await _taskAssignmentService.UpdateAssignmentAsync(assignment));

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAssignment(int id) =>
            Ok(await _taskAssignmentService.DeleteAssignmentAsync(id));

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAssignment(int id) =>
            Ok(await _taskAssignmentService.GetAssignmentAsync(id));

        [HttpGet("by-user/{userId:int}")]
        public async Task<IActionResult> GetAssignmentsByUser(int userId) =>
            Ok(await _taskAssignmentService.GetAssignmentsByUserAsync(userId));

        [HttpGet("by-task/{taskId:int}")]
        public async Task<IActionResult> GetAssignmentsByTask(int taskId) =>
            Ok(await _taskAssignmentService.GetAssignmentsByTaskAsync(taskId));
    }
}
