using System.Collections.Concurrent;

namespace ApKt01;

public static class DataProcessor
{
	public static void ProcessData(ConcurrentBag<int> bag)
	{
		var total = 0UL;
		var count = 0UL;

		// ConcurrentBag обычно применятся для thead safe добавления и удаления, а не для этого...
		Parallel.ForEach(bag, item =>
		{
			Interlocked.Add(ref total, (ulong)item);
			Interlocked.Increment(ref count);
		});

		Console.WriteLine($"total: {total}");
		Console.WriteLine($"count: {count}");
	}
}
