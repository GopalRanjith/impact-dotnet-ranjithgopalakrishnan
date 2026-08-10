using System;

namespace CSharpLearning
{
    public class FileLogger : Logger
    {
        public new void Log()
        {
            Console.WriteLine("File Logger");
        }
    }
}