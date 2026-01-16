using MyPortfolio.Core.Enums;

namespace MyPortfolio.Models.DTOs;

public class EmailSubmissionResponse<T>
{
	public required ApiResponse<T> Response { get; init; }
	public required ToastLevel ToastLevel { get; init; }
}
