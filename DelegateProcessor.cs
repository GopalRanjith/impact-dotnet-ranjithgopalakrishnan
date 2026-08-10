using System;
using System.Collections.Generic;

namespace CSharpLearning
{
    public static class DelegateProcessor
    {
        // Action<string> - Print in uppercase
        public static void PrintUpperCase(string text)
        {
            Console.WriteLine(text.ToUpper());
        }

        // Predicate<int> - Check if even
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Func<int,int,int> - Multiply
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        // ProcessList: filter -> transform -> output
        public static void ProcessList(
            List<int> numbers,
            Predicate<int> filter,
            Func<int, int> transform,
            Action<int> output)
        {
            foreach (int number in numbers)
            {
                if (filter(number))
                {
                    int result = transform(number);
                    output(result);
                }
            }
        }
    }
}