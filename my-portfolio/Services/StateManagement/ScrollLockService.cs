using Microsoft.JSInterop;

namespace MyPortfolio.Services.StateManagement;

public class ScrollLockService(IJSRuntime js)
{
	private readonly IJSRuntime _js = js;
	private int _lockCount = 0;

	public async Task LockScrollAsync()
	{
		_lockCount++;

		if (_lockCount == 1)
		{
			await _js.InvokeVoidAsync("scrollLocker.disableScroll");
		}
	}

	public async Task UnlockScrollAsync()
	{
		if (_lockCount == 0) return;

		_lockCount = Math.Max(0, _lockCount - 1);

		if (_lockCount == 0)
		{
			await _js.InvokeVoidAsync("scrollLocker.enableScroll");
		}
	}

	public async Task ForceUnlockAsync()
	{
		if (_lockCount == 0) return;

		_lockCount = 0;
		await _js.InvokeVoidAsync("scrollLocker.forceUnlock");
	}
}
