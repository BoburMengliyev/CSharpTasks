using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TelegramBotService.Interfaces
{
    public interface IBotCommandService
    {
        Task SetBotCommandsAsync(ITelegramBotClient bot, CancellationToken ct);
    }
}
