namespace MyPortfolio.Models.DTOs;

public class ApiResponse<T>
{
	public bool Success { get; set; }
	public string Message { get; set; } = string.Empty;
	public DateTime Timestamp { get; set; } = DateTime.UtcNow;
	public T? Data { get; set; }

	public static ApiResponse<T> Ok(T data, string? message = null) => new()
	{
		Success = true,
		Message = string.IsNullOrWhiteSpace(message) ? "Request succeeded." : message,
		Timestamp = DateTime.UtcNow,
		Data = data,
	};

	public static ApiResponse<T> Fail(T? data = default, string? message = null) => new()
	{
		Success = false,
		Message = string.IsNullOrWhiteSpace(message) ? "Request failed." : message,
		Timestamp = DateTime.UtcNow,
		Data = data,
	};
}