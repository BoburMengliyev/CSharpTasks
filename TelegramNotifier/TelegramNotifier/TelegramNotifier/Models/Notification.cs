using System;

namespace TelegramNotifier.Models
{
    public class Notification
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public DateTime SentAtUtc { get; set; }
    }
}
