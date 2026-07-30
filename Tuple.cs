class Tuple
{
    public static (int Min,int Max) GetMinMax(int[] numbers)
    {
        int min =numbers[0];
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }

            if (number > max)
            {
                max = number;
            }
        }

        return (Min: min, Max: max);
    }
}