using System;
using System.Diagnostics;
using System.Threading.Tasks;

public class AsyncDemo
{
    public static async Task<string> FetchUserDataAsync(string user)
    {
        Console.WriteLine($"{user}: Before await");

        await Task.Delay(3000);

        Console.WriteLine($"{user}: After await");

        return $"{user} data received";
    }

    public static async Task RunDemoAsync()
    {
        // -------------------------------
        // Sequential execution
        // -------------------------------

        Stopwatch stopwatch = Stopwatch.StartNew();

        string user1 = await FetchUserDataAsync("User 1");
        string user2 = await FetchUserDataAsync("User 2");
        string user3 = await FetchUserDataAsync("User 3");

        stopwatch.Stop();

        Console.WriteLine("\nSequential Results:");
        Console.WriteLine(user1);
        Console.WriteLine(user2);
        Console.WriteLine(user3);

        Console.WriteLine(
            $"Sequential time: {stopwatch.ElapsedMilliseconds} ms");


        // -------------------------------
        // Concurrent execution
        // -------------------------------

        stopwatch.Restart();

        Task<string> task1 = FetchUserDataAsync("User 1");
        Task<string> task2 = FetchUserDataAsync("User 2");
        Task<string> task3 = FetchUserDataAsync("User 3");

        string[] results = await Task.WhenAll(task1, task2, task3);

        stopwatch.Stop();

        Console.WriteLine("\nConcurrent Results:");

        foreach (string result in results)
        {
            Console.WriteLine(result);
        }

        Console.WriteLine(
            $"Concurrent time: {stopwatch.ElapsedMilliseconds} ms");
    }
}