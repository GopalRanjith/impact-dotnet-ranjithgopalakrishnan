using System;

namespace CSharpLearning
{
    public class AlarmClock
    {
        public event EventHandler<AlarmEventArgs>? OnAlarmRing;

        public void RingAlarm()
        {
            Console.WriteLine("Alarm is ringing...");

            OnAlarmRing?.Invoke(this, new AlarmEventArgs
            {
                AlarmTime = DateTime.Now
            });
        }
    }
}