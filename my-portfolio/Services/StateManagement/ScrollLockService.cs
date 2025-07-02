using Microsoft.JSInterop;

namespace MyPortfolio.Services.StateManagement;

public class ScrollLockService(IJSRuntime js, ILogger<ScrollLockService> logger)
{
	private readonly IJSRuntime _js = js;
	private readonly ILogger<ScrollLockService> _logger = logger;
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
		if (_lockCount == 0)
		{
			_logger.LogWarning("Unlock called but already at 0 → skipping JS call");
			return;
		}

		_lockCount = Math.Max(0, _lockCount - 1);

		if (_lockCount == 0)
		{
			await _js.InvokeVoidAsync("scrollLocker.enableScroll");
		}
	}

	public async Task ForceUnlockAsync()
	{
		if (_lockCount == 0)
		{
			_logger.LogWarning("ForceUnlock called but already at 0 → skipping JS call");
			return;
		}

		_lockCount = 0;
		await _js.InvokeVoidAsync("scrollLocker.forceUnlock");
	}
}
