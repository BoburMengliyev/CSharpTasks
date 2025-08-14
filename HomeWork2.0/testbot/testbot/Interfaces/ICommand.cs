using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotService.Interfaces
{
    public interface ICommand
    {
        string Name { get; }
        string Description { get; } // Tavsif, hozircha ishlatilmaydi
        Task ExecuteAsync(ITelegramBotClient bot, Message message);
    }
}