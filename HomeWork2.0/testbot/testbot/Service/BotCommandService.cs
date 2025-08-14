using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotService.Interfaces;

namespace TelegramBotService.Service
{
    public class BotCommandService(IEnumerable<ICommand> commands) : IBotCommandService
    {
        private readonly IEnumerable<ICommand> _commands = commands;

        public async Task SetBotCommandsAsync(ITelegramBotClient bot, CancellationToken ct)
        {
            var tgCommands = _commands.Select(c => new BotCommand
            {
                Command = c.Name.TrimStart('/'),
                Description = c.Description
            });

            await bot.SetMyCommands(tgCommands, cancellationToken: ct);
        }
    }
}
