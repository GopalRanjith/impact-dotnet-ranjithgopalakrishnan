using System;

namespace CSharpLearning
{
    public class Notification
    {
        public virtual void Send()
        {
            Console.WriteLine("Sending Notification");
        }
    }
}