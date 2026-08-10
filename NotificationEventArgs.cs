using System;

namespace CSharpLearning
{
    public class NotificationEventArgs : EventArgs
    {
        public string Message { get; set; } = "";
        public DateTime SentTime { get; set; }
    }
}