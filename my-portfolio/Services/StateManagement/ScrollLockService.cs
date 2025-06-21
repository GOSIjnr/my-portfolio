using Microsoft.JSInterop;

namespace MyPortfolio.Services.StateManagement;

public class ScrollLockService(IJSRuntime js)
{
	private readonly IJSRuntime _js = js ?? throw new ArgumentNullException(nameof(js));
	private int _lockCount = 0;

	public async Task LockScrollAsync()
	{
		_lockCount++;
		Console.WriteLine($"[ScrollLockService] Lock count now: {_lockCount}");

		if (_lockCount == 1)
			await _js.InvokeVoidAsync("scrollLocker.disableScroll");
	}

	public async Task UnlockScrollAsync()
	{
		if (_lockCount == 0)
		{
			Console.WriteLine($"[ScrollLockService] Unlock called but already at 0 → skipping JS call");
			return; // ❗ prevent redundant JS call
		}

		_lockCount = Math.Max(0, _lockCount - 1);
		Console.WriteLine($"[ScrollLockService] Lock count now: {_lockCount}");

		if (_lockCount == 0)
			await _js.InvokeVoidAsync("scrollLocker.enableScroll");
	}

	public async Task ForceUnlockAsync()
	{
		if (_lockCount == 0)
		{
			Console.WriteLine($"[ScrollLockService] ForceUnlock called but already at 0 → skipping JS call");
			return; // ❗ prevent redundant JS call
		}

		_lockCount = 0;
		Console.WriteLine($"[ScrollLockService] Force unlock");

		await _js.InvokeVoidAsync("scrollLocker.forceUnlock");
	}
}

