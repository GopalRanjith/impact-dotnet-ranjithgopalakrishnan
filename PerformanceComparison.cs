using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

public class PerformanceComparison
{
    private const int OperationCount = 100;
    private const int DelayMilliseconds = 100;

    private static void SimulateOperation(int number)
    {
        Thread.Sleep(DelayMilliseconds);
    }

    public static async Task Run()
    {
        Stopwatch stopwatch = new Stopwatch();

        // ==========================================
        // 1. Sequential foreach
        // ==========================================

        stopwatch.Start();

        foreach (int number in Enumerable.Range(1, OperationCount))
        {
            SimulateOperation(number);
        }

        stopwatch.Stop();

        Console.WriteLine(
            $"Sequential foreach: {stopwatch.ElapsedMilliseconds} ms");


        // ==========================================
        // 2. Task.Run
        // ==========================================

        stopwatch.Restart();

        Task[] tasks = new Task[OperationCount];

        for (int i = 0; i < OperationCount; i++)
        {
            int number = i;

            tasks[i] = Task.Run(() =>
            {
                SimulateOperation(number);
            });
        }

        await Task.WhenAll(tasks);

        stopwatch.Stop();

        Console.WriteLine(
            $"Task.Run: {stopwatch.ElapsedMilliseconds} ms");


        // ==========================================
        // 3. Parallel.ForEach
        // ==========================================

        stopwatch.Restart();

        Parallel.ForEach(
            Enumerable.Range(1, OperationCount),
            number =>
            {
                SimulateOperation(number);
            });

        stopwatch.Stop();

        Console.WriteLine(
            $"Parallel.ForEach: {stopwatch.ElapsedMilliseconds} ms");
    }
}