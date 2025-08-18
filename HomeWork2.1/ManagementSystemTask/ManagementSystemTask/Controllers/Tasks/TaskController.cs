using ManagementSystemTask.Models.Tasks;
using ManagementSystemTask.Services.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystemTask.Controllers.Tasks
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskItemController : ControllerBase
    {
        private readonly ITaskService taskService;

        public TaskItemController(ITaskService taskItemService) =>
            this.taskService = taskItemService;

        [HttpPost]
        public async Task<IActionResult> AddTask([FromBody] TaskItem task) =>
            Ok(await taskService.AddTaskAsync(task));

        [HttpPut]
        public async Task<IActionResult> UpdateTask([FromBody] TaskItem task) =>
            Ok(await taskService.UpdateTaskAsync(task));

        [HttpDelete("{taskId}")]
        public async Task<IActionResult> DeleteTask(int taskId) =>
            Ok(await taskService.DeleteTaskAsync(taskId));

        [HttpGet("{taskId}")]
        public async Task<IActionResult> GetTask(int taskId) =>
            Ok(await taskService.GetTaskAsync(taskId));

        [HttpGet("project/{projectId}")]
        public async Task<IActionResult> GetTasksByProject(int projectId) =>
            Ok(await taskService.GetTasksByProjectAsync(projectId));

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetTasksByUser(int userId) =>
            Ok(await taskService.GetTasksByUserAsync(userId));

        [HttpGet("due/{days}")]
        public async Task<IActionResult> GetTasksDueSoon(int days) =>
            Ok(await taskService.GetTasksDueSoonAsync(days));
    }
}
