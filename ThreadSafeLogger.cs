using System;

public sealed class ThreadSafeLogger
{
	private static readonly Lazy<ThreadSafeLogger> instance =
		new Lazy<ThreadSafeLogger>(() => new ThreadSafeLogger());

	private ThreadSafeLogger()
	{
	}

	public static ThreadSafeLogger Instance
	{
		get { return instance.Value; }
	}

	public void Log(string message)
	{
		Console.WriteLine(
			$"Thread: {Environment.CurrentManagedThreadId}, " +
			$"HashCode: {GetHashCode()}, Message: {message}");
	}
}