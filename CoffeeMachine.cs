using System;

namespace CSharpLearning
{
    public class CoffeeMachine
    {
        public void StartBrewing(object? sender, AlarmEventArgs e)
        {
            Console.WriteLine($"Coffee machine started brewing at {e.AlarmTime:T}");
        }
    }
}