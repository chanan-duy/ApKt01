namespace ApKt01;

public class DownloadManager
{
	private readonly HttpClient _client;

	public DownloadManager(HttpClient client)
	{
		_client = client;
	}

	public async Task DownloadFilesAsync(params string[] urls)
	{
		var tasks = new Task[urls.Length];
		for (var i = 0; i < urls.Length; i++)
		{
			var url = urls[i];
			var task = DownloadFileAsync(url);
			tasks[i] = task;
		}

		await Task.WhenAll(tasks);
	}

	private async Task DownloadFileAsync(string url)
	{
		Console.WriteLine($"Downloading from: {url}");

		var uri = new Uri(url);

		var result = await _client.GetByteArrayAsync(uri);

		Console.WriteLine($"Done. Downloaded: {result.Length} bytes");
	}
}
