namespace ApKt01;

public static class Logic
{
	public static async Task RunLogic()
	{
		Console.WriteLine($"Download Manager...{Environment.NewLine}");

		using var httpClient = new HttpClient();
		var downloadManager = new DownloadManager(httpClient);

		await downloadManager.DownloadFilesAsync(
			"https://cachefly.cachefly.net/1mb.test",
			"https://cachefly.cachefly.net/10mb.test");

		Console.Write(Environment.NewLine);
		Console.WriteLine($"Array Processor...{Environment.NewLine}");
	}
}
