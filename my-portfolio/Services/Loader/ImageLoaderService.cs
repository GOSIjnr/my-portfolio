using Microsoft.JSInterop;
using MyPortfolio.Core.Options;

namespace MyPortfolio.Services.Loader;

public class ImageLoaderService(IJSRuntime js)
{
	private readonly IJSRuntime _js = js;

	public async Task ApplyCssImageWithFallbackAsync(ImageLoaderOptions options)
	{
		await _js.InvokeVoidAsync("imageLoader.applyCssImageWithFallback", options);
	}

	public async Task ApplyImgSrcWithFallbackAsync(ImageLoaderOptions options)
	{
		await _js.InvokeVoidAsync("imageLoader.applyImgSrcWithFallback", options);
	}
}
