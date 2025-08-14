using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using TelegramBotService.Commands;
using TelegramBotService.Handlers;
using TelegramBotService.Interfaces;
using TelegramBotService.Service;

namespace TelegramBotService
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Bot tokenini o'rnating
            var botClient = new TelegramBotClient("8381407737:AAGJ-j-Y0sxvk-ow19CAX1fOUM5x8aqlRCA"); // Telegram Bot API kutubxonasini yaratish

            // Bot haqida ma'lumotlarni olish
            var me = await botClient.GetMe(); // Botning o'zini olish
            Console.WriteLine($"Bot ishga tushdi: @{me.Username}"); // Botning foydalanuvchi nomi


            var receiverOptions = new Telegram.Bot.Polling.ReceiverOptions // Qabul qilish sozlamalari
            {
                AllowedUpdates = Array.Empty<UpdateType>() // Barcha yangilanishlarni qabul qilish
            };

            using var cts = new CancellationTokenSource(); // Bekor qilish tokeni

            var commands = new List<ICommand>
            {
                new StartCommand(),
                new HelpCommand(),
                new AboutCommand()
            };

            IBotCommandService botCommandService = new BotCommandService(commands);
            // Yangilanishlarni boshqarish uchun UpdateHandler ni yaratish
            var updateHandler = new UpdateHandler();

            // Botni yangilanishlarni qabul qilishga tayyorlash
            await botClient.ReceiveAsync( 
                updateHandler.HandleUpdateAsync, // Yangilanishlarni boshqarish metodi
                updateHandler.HandleErrorAsync, // Xatoliklarni boshqarish metodi
                receiverOptions, // Qabul qilish sozlamalari
                cancellationToken: cts.Token // Bekor qilish tokeni
            );

            Console.WriteLine("Bot ishlayapti. To'xtatish uchun ENTER bosing...");
            Console.ReadLine();
        }
    }
}
