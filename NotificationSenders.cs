using System;

namespace CSharpLearning
{
    public static class NotificationSenders
    {
        public static void SendEmail(string message)
        {
            Console.WriteLine($"Email Sent: {message}");
        }

        public static void SendSms(string message)
        {
            Console.WriteLine($"SMS Sent: {message}");
        }

        public static void SendPush(string message)
        {
            Console.WriteLine($"Push Notification Sent: {message}");
        }
    }
}