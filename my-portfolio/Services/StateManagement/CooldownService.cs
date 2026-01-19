using System.Net.Http.Json;
using MyPortfolio.Models.DTOs;
using MyPortfolio.Services.Config;
using SystemTimer = System.Timers.Timer;

namespace MyPortfolio.Services.StateManagement;

public class CooldownService(ILogger<CooldownService> logger)
{
	private const int DefaultCooldownSeconds = 30;
	private readonly ILogger<CooldownService> _logger = logger;

	private DateTimeOffset? _startTime;
	private int _cooldownSeconds;
	private int _fetchedCooldownSeconds;
	private bool _fetched;
	private SystemTimer? _timer;
	public event Action? OnTick;
	public bool IsCoolingDown => _startTime is not null && RemainingSeconds > 0;

	public int RemainingSeconds
	{
		get
		{
			if (!_startTime.HasValue) return 0;

			int elapsed = (int)(DateTimeOffset.UtcNow - _startTime.Value).TotalSeconds;
			return Math.Max(0, _cooldownSeconds - elapsed);
		}
	}

	public int LastFetchedCooldown => _fetchedCooldownSeconds;

	public void TriggerCooldown()
	{
		int duration = _fetchedCooldownSeconds > 0 ? _fetchedCooldownSeconds : DefaultCooldownSeconds;
		TriggerCooldown(duration);
	}

	public void TriggerCooldown(int seconds)
	{
		if (seconds <= 0) return;

		_startTime = DateTimeOffset.UtcNow;
		_cooldownSeconds = seconds;
		StartTimer();
	}

	public void Reset()
	{
		ResetActiveCooldown();
		_fetched = false;
		_fetchedCooldownSeconds = 0;
	}

	public void ResetAll()
	{
		Reset();
		_fetchedCooldownSeconds = 0;
		_fetched = false;
	}

	public void ResetActiveCooldown()
	{
		_startTime = null;
		_cooldownSeconds = 0;
		StopTimer();
		OnTick?.Invoke();
	}

	public async Task TryFetchOnceAsync(HttpClient http)
	{
		if (_fetched) return;

		try
		{
			var response = await http.GetFromJsonAsync<ApiResponse<CooldownDataResponse>>(ApiRoutes.Cooldown.Info);

			if (response?.Success == true && response.Data?.CooldownSeconds > 0)
			{
				_fetchedCooldownSeconds = response.Data.CooldownSeconds;
			}
			else
			{
				UseFallbackCooldown();
			}
		}
		catch
		{
			UseFallbackCooldown();
		}
		finally
		{
			_fetched = true;
		}
	}

	private void UseFallbackCooldown()
	{
		_fetchedCooldownSeconds = DefaultCooldownSeconds;
		ShowUserFallbackNotice();
	}

	private void ShowUserFallbackNotice()
	{
		_logger.LogWarning("Cooldown info fetch failed. Falling back to default cooldown ({Cooldown}s).", DefaultCooldownSeconds);
	}

	private void StartTimer()
	{
		StopTimer();

		_timer = new SystemTimer(1000)
		{
			AutoReset = true
		};

		_timer.Elapsed += (_, _) =>
		{
			OnTick?.Invoke();

			if (!IsCoolingDown)
			{
				ResetActiveCooldown();
			}
		};

		_timer.Start();
	}

	private void StopTimer()
	{
		if (_timer is null) return;

		_timer.Stop();
		_timer.Dispose();
		_timer = null;
	}
}
