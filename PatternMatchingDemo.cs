using System;
public class PatternMatchingDemo
{
    // Type Pattern Matching
    public static void Display(object value)
    {
        switch (value)
        {
            case int number:
                Console.WriteLine($"Integer : {number}");
                break;

            case string text:
                Console.WriteLine($"String : {text}");
                break;

            case double marks:
                Console.WriteLine($"Double : {marks}");
                break;

            case null:
                Console.WriteLine("Value is Null");
                break;

            default:
                Console.WriteLine("Unknown Type");
                break;
        }
    }

    // Switch Expression
    public static string GetGrade(int marks)
    {
        return marks switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "Fail"
        };
    }

    // Property Pattern
    public static int GetDiscount(Order order)
    {
        return order switch
        {
            { Status: "Completed", Amount: >= 1000 } => 20,
            { Status: "Completed", Amount: >= 500 } => 10,
            { Status: "Pending" } => 5,
            _ => 0
        };
    }
}
