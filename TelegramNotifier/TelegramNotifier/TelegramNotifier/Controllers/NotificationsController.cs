using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TelegramNotifier.Data;

namespace TelegramNotifier.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationRepository repository;

        public NotificationsController(INotificationRepository repository) =>
            this.repository = repository;

        [HttpGet("recent")]
        public async Task<IActionResult> GetRecentNotifications()
        {
            return Ok();
        }
    }
}
