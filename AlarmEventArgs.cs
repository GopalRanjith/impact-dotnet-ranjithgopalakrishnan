using System;

namespace CSharpLearning
{
    public class AlarmEventArgs : EventArgs
    {
        public DateTime AlarmTime { get; set; }
    }
}