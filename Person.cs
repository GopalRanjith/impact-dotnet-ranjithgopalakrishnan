using System;

namespace CSharpLearning
{
    public class Person
    {
        public void WakeUp(object? sender, AlarmEventArgs e)
        {
            Console.WriteLine($"Person woke up at {e.AlarmTime:T}");
        }
    }
}