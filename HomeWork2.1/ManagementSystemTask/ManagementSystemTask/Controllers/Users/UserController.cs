using ManagementSystemTask.Models.Users;
using ManagementSystemTask.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystemTask.Controllers.Users
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService) =>
            this.userService = userService;

        [HttpPost]
        public async Task<ActionResult<User>> AddUser(User user)
        {
            var createdUser = await userService.AddUserAsync(user);
            return CreatedAtAction(nameof(GetUser), new { userId = createdUser.Id }, createdUser);
        }

        [HttpPut("{userId}")]
        public async Task<ActionResult<User>> UpdateUser(int userId, User user)
        {
            if (userId != user.Id)
                return BadRequest("User ID does not match");

            var updatedUser = await userService.UpdateUserAsync(user);
            return Ok(updatedUser);
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUser(int userId) =>
            Ok(await userService.DeleteUserAsync(userId));

        [HttpGet("{userId}")]
        public async Task<ActionResult<User>> GetUser(int userId) =>
            Ok(await userService.GetUserAsync(userId));

        [HttpGet("most-tasks")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsersWithMostTasks([FromQuery] int count = 5) =>
            Ok(await userService.GetUsersWithMostTasksAsync(count));
    }
}
