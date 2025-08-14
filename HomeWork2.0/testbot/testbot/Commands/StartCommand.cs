using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotService.Interfaces;

namespace TelegramBotService.Commands
{
    public class StartCommand : ICommand
    {
        public string Name => "/start"; // Komanda nomi

        public string Description => throw new NotImplementedException(); // Komanda tavsifi (hozircha ishlatilmaydi)

        public async Task ExecuteAsync(ITelegramBotClient bot, Message message) 
        {
            await bot.SendMessage(
                chatId: message.Chat.Id, // Xabar yuboriladigan chat identifikatori
                text: "Salom! Bot ishga tushdi"); // Yuboriladigan xabar matni
        }
    }
}
