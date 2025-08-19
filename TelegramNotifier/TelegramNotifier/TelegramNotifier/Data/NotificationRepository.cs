using Dapper;
using Npgsql;
using System;
using System.Threading.Tasks;
using TelegramNotifier.Models;

namespace TelegramNotifier.Data
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly string connectionString;

        public NotificationRepository(string connectionString) =>
            this.connectionString = connectionString;

        public async Task InsertAsync(Notification notification)
        {
            using NpgsqlConnection connection = new NpgsqlConnection(this.connectionString);
            string sql = "INSERT INTO notifications (content, sentatutc) VALUES (@Content, @SentAtUtc)";

            await connection.ExecuteAsync(sql, notification);
        }

        public async Task<int> DeleteOlderThan(DateTime cutoffUtc)
        {
            using NpgsqlConnection connection = new NpgsqlConnection(this.connectionString);
            string sql = "DELETE FROM notifications WHERE SentAtUtc < @cutoffUtc";
            
            return await connection.ExecuteAsync(sql, new { cutoffUtc });
        }
    }
}
