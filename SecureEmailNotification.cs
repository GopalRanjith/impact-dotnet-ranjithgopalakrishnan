using System;

namespace CSharpLearning
{
    public class SecureEmailNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("Sending Secure Email Notification");
        }
    }
}