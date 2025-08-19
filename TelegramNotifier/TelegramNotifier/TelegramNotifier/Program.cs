using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Scalar.AspNetCore;
using Telegram.Bot;
using TelegramNotifier.Data;
using TelegramNotifier.Models;
using TelegramNotifier.Services;

namespace TelegramNotifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Services.Configure<TelegramSettings>(
                builder.Configuration.GetSection("TelegramSettings"));

            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddSingleton<INotificationRepository>(new NotificationRepository(connectionString));

            string botToken = builder.Configuration.GetSection("TelegramSettings:BotToken").Value;
            builder.Services.AddSingleton<ITelegramBotClient>(new TelegramBotClient(botToken));

            builder.Services.AddHostedService<TelegramNotifierService>();
            builder.Services.AddHostedService<CleanupService>();

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            WebApplication app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
