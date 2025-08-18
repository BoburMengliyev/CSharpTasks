using ManagementSystem.Models.Users;
using ManagementSystem.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _users;

        public UsersController(IUserService users)
        {
            _users = users;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] User user)
        {
            if (!ModelState.IsValid) return ValidationProblem(ModelState);
            var created = await _users.AddUserAsync(user);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] User user)
        {
            if (id != user.Id) return BadRequest("Route id and body id differ.");
            if (!ModelState.IsValid) return ValidationProblem(ModelState);

            var updated = await _users.UpdateUserAsync(user);
            if (updated is null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var ok = await _users.DeleteUserAsync(id);
            if (!ok) return NotFound();
            return NoContent();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _users.GetUserAsync(id);
            if (user is null) return NotFound();
            return Ok(user);
        }

        [HttpGet("most-tasks")]
        public async Task<IActionResult> GetWithMostTasks([FromQuery] int topCount = 5)
        {
            var list = await _users.GetUsersWithMostTasksAsync(topCount);
            return Ok(list);
        }
    }
}
