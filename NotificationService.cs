using System;

namespace CSharpLearning
{
    public class NotificationService
    {
        public event EventHandler<NotificationEventArgs>? OnNotificationSent;

        public void Send(string message, NotificationSender sender)
        {
            sender(message);

            OnNotificationSent?.Invoke(this, new NotificationEventArgs
            {
                Message = message,
                SentTime = DateTime.Now
            });
        }
    }
}