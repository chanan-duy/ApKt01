namespace ApKt01;

public static class Logic
{
	public static async Task RunLogic()
	{
		await RunDownloadManager();

		Console.Write(Environment.NewLine);

		RunArrayProcessor();

		Console.Write(Environment.NewLine);
	}

	private static async Task RunDownloadManager()
	{
		Console.WriteLine($"Download Manager...{Environment.NewLine}");

		using var httpClient = new HttpClient();
		var downloadManager = new DownloadManager(httpClient);

		await downloadManager.DownloadFilesAsync(
			"https://cachefly.cachefly.net/1mb.test",
			"https://cachefly.cachefly.net/10mb.test");
	}

	private static void RunArrayProcessor()
	{
		Console.WriteLine($"Array Processor...{Environment.NewLine}");

		var bigArray = Enumerable.Range(0, 1024 * 1024 * 10).ToArray();
		for (var i = 0; i < bigArray.Length; i++)
		{
			bigArray[i] = i;
		}

		Console.WriteLine($"5th el: {bigArray[6]}");
		ArrayProcessor.IncrementListElements(bigArray);
		Console.WriteLine($"5th el (after): {bigArray[6]}");
	}

	private static void DataProcessor()
	{
		Console.WriteLine($"Data Processor...{Environment.NewLine}");
	}
}
