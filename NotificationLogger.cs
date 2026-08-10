using System;

namespace CSharpLearning
{
    public class NotificationLogger
    {
        public void LogNotification(object? sender, NotificationEventArgs e)
        {
            Console.WriteLine($"LOG: '{e.Message}' sent at {e.SentTime:T}");
        }
    }
}