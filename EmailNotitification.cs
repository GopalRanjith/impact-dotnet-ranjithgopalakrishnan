using System;

namespace CSharpLearning
{
    public class EmailNotification : Notification
    {
        public sealed override void Send()
        {
            Console.WriteLine("Sending Email Notification");
        }
    }
}