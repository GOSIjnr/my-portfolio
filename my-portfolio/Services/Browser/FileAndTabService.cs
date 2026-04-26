using Microsoft.JSInterop;

namespace MyPortfolio.Services.Browser;

public class FileAndTabService(IJSRuntime js)
{
	private readonly IJSRuntime _js = js;
	private const string GoogleDriveBaseUrl = "https://drive.google.com/uc?export=download&id=";

	public async Task DownloadFileFromGoogleDriveAsync(string fileId, string filename = "")
	{
		if (string.IsNullOrWhiteSpace(fileId)) return;

		string url = $"{GoogleDriveBaseUrl}{fileId}";
		await _js.InvokeVoidAsync("fileAndTab.downloadFile", url, filename);
	}

	public async Task OpenInNewTabAsync(string url)
	{
		if (string.IsNullOrWhiteSpace(url)) return;

		await _js.InvokeVoidAsync("fileAndTab.openFileInNewTab", url);
	}
}
