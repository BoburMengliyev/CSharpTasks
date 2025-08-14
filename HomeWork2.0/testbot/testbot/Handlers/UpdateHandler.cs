using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramBotService.Commands;
using TelegramBotService.Interfaces;

namespace TelegramBotService.Handlers
{
    public class UpdateHandler // Yangilanishlarni boshqaruvchi klass
    {
        private readonly List<ICommand> _comands; // Komandalar ro'yhati

        // Konstruktor
        public UpdateHandler() // Konstruktor
        {
            _comands = new List<ICommand> // Komandalar ro'yhati
            {
                new StartCommand(), // Botni ishga tushirish komandasi
                new HelpCommand(), // Yordam komandasi
                new AboutCommand() // Bot haqida ma'lumot komandasi
            };
        }

        // Yangilanishlarni boshqarish metodi
        public async Task HandleUpdateAsync(ITelegramBotClient bot, Update update, CancellationToken cancellationToken) // Yangilanishlarni boshqarish metodi
        {
            if (update.Type != UpdateType.Message) // Agar yangilanish xabar bo'lmasa
                return; // Hech narsa qilmasin

            if (update.Message?.Text is null) // Agar xabar matni bo'lmasa
                return; // Hech narsa qilmasin

            string messageText = update.Message.Text.Trim().ToLower(); // Xabar matnini kichik harflarga o'tkazish

            var command = _comands.FirstOrDefault(c => c.Name == messageText); // Komanda topish
            if (command != null) // Agar komanda topilgan bo'lsa
            {
                try 
                {
                    await command.ExecuteAsync(bot, update.Message); // Komandani bajarish
                }
                catch (Exception ex) // Agar xatolik yuz bersa
                {
                    await bot.SendMessage( // Xatolik haqida xabar yuborish
                        chatId: update.Message.Chat.Id, // Xabar yuboriladigan chat identifikatori
                        text: $"Xatolik yuz berdi: {ex.Message}", // Xatolik matni
                        cancellationToken: cancellationToken); // Bekor qilish tokeni
                }
            }
            else // Agar komanda topilmasa
            {
                await bot.SendMessage( // Foydalanuvchiga yordam xabarini yuborish
                    chatId: update.Message.Chat.Id,
                    text: "Bu komanda tanimaydi. /help orqali yordam olishingiz mumkin.", // Yordam xabari
                    cancellationToken: cancellationToken);
            }
        }

        // Xatoliklarni boshqarish metodi
        public Task HandleErrorAsync(ITelegramBotClient bot, Exception exception, CancellationToken cancellationToken)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Xatolik: {exception.Message}");
            Console.ResetColor();
            return Task.CompletedTask;
        }
    }
}
