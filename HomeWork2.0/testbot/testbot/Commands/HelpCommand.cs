using Telegram.Bot; // Telegram Bot API kutubxonasi
using Telegram.Bot.Types; // Telegram Bot API kutubxonasi
using TelegramBotService.Interfaces;

namespace TelegramBotService.Commands
{
    public class HelpCommand : ICommand
    {
        public string Name => "/help"; // Komanda nomi

        public string Description => throw new NotImplementedException();

        public async Task ExecuteAsync(ITelegramBotClient bot, Message message)
        {
            var helpText = "Bu bot quyidagi komandalarni qo'llab-quvvatlaydi:\n" +
                           "/start - Botni ishga tushirish\n" +
                           "/help - Yordam matni" +
                           "/about -  Bot haqida ma'lumot olish";

            await bot.SendMessage( // Xabar yuborish uchun metod
                chatId: message.Chat.Id, // Xabar yuboriladigan chat identifikatori
                text: helpText); // Yuboriladigan xabar matni
        }
    }
}
