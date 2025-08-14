using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotService.Interfaces;

namespace TelegramBotService.Commands
{
    public class AboutCommand : ICommand
    {
        public string Name => "/about"; // Komanda nomi

        public string Description => throw new NotImplementedException();

        public async Task ExecuteAsync(ITelegramBotClient bot, Message message)
        {
            var aboutText = "Bu bot Telegram orqali ishlaydi va foydalanuvchilarga yordam beradi.\n" +
                            "Ishlab chiquvchi: [Ismingiz]\n" +
                            "Versiya: 1.0.0";
            await bot.SendMessage( // Xabar yuborish uchun metod
                chatId: message.Chat.Id, // Xabar yuboriladigan chat identifikatori
                text: aboutText); // Yuboriladigan xabar matni
        }
    }
}
