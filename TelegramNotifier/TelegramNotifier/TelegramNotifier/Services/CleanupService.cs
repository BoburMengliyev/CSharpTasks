using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;
using TelegramNotifier.Data;

namespace TelegramNotifier.Services
{
    public class CleanupService : BackgroundService
    {
        private readonly INotificationRepository notificationRepository;
        private readonly ILogger<CleanupService> logger;

        public CleanupService(INotificationRepository notificationRepository, ILogger<CleanupService> logger)
        {
            this.notificationRepository = notificationRepository;
            this.logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            this.logger.LogInformation("Tozalash xizmati boshlandi.");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    DateTime cutoffUtc = DateTime.UtcNow.AddMinutes(-2);
                    int deleted = await notificationRepository.DeleteOlderThan(cutoffUtc);

                    this.logger.LogInformation("{Count} dan katta xabarnomalar {Cutoff} o'chirildi.",
                        deleted, cutoffUtc);
                }
                catch (Exception ex)
                {
                    this.logger.LogError(ex, "Bildirishnomalarni tozalashda xato.");
                }

                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
            this.logger.LogInformation("Tozalash xizmati to'xtatildi.");
        }
    }
}
