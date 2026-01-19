using Microsoft.JSInterop;

namespace MyPortfolio.Services.StateManagement;

public sealed class ResizeEventListenerService<TComponent>(IJSRuntime jsRuntime) : IAsyncDisposable where TComponent : class
{
	private readonly IJSRuntime _jsRuntime = jsRuntime;
	private DotNetObjectReference<TComponent>? _dotNetRef;

	public async Task RegisterResizeCallbackAsync(TComponent component)
	{
		if (_dotNetRef is not null) return;

		_dotNetRef = DotNetObjectReference.Create(component);
		await _jsRuntime.InvokeVoidAsync("resizeNotifier.registerResizeCallback", _dotNetRef);
	}

	public async Task UnregisterResizeCallbackAsync()
	{
		await _jsRuntime.InvokeVoidAsync("resizeNotifier.unregisterResizeCallback");
		_dotNetRef?.Dispose();
		_dotNetRef = null;
	}

	public async ValueTask DisposeAsync()
	{
		await UnregisterResizeCallbackAsync();
	}
}
