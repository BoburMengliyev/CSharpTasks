using System;
using System.Threading.Tasks;
using TelegramNotifier.Models;

namespace TelegramNotifier.Data
{
    public interface INotificationRepository
    {
        Task InsertAsync (Notification notification);
        Task <int> DeleteOlderThan (DateTime date);
    }
}
