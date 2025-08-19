using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using TelegramNotifier.Data;
using TelegramNotifier.Models;

namespace TelegramNotifier.Services
{
    public class TelegramNotifierService : BackgroundService
    {
        private readonly ILogger<TelegramNotifierService> logger;
        private readonly ITelegramBotClient telegramBotClient;
        private readonly INotificationRepository notificationRepository;
        private readonly string chatId;

        public TelegramNotifierService(
            ILogger<TelegramNotifierService> logger,
            ITelegramBotClient telegramBotClient,
            INotificationRepository notificationRepository,
            IOptions<TelegramSettings> options)
        {
            this.logger = logger;
            this.telegramBotClient = telegramBotClient;
            this.notificationRepository = notificationRepository;
            this.chatId = options.Value.ChatId.ToString();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            this.logger.LogInformation("TelegramNotifierService boshlandi.");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    string message = $"Ping: {DateTime.UtcNow}";

                    await this.telegramBotClient.SendMessage(
                        chatId: this.chatId,
                        text: message,
                        cancellationToken: stoppingToken);

                    await this.notificationRepository.InsertAsync(new Notification
                    {
                        Content = message,
                        SentAtUtc = DateTime.UtcNow
                    });

                    this.logger.LogInformation("Xabarnoma muvaffaqiyatli yuborildi: {xabar}", message);
                }
                catch (Exception ex)
                {
                    this.logger.LogError(ex, "Bildirishnoma yuborishda xato.");
                }

                await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
            }

            this.logger.LogInformation("TelegramNotifierService to'xtadi.");
        }
    }
}
