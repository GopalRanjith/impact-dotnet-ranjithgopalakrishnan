using System.Collections.Generic;

namespace CSharpLearning
{
    public static class NumberGenerator
    {
        public static IEnumerable<int> GetEvenNumbers(int max)
        {
            for (int i = 2; i <= max; i += 2)
            {
                yield return i;
            }
        }
    }
}