namespace MyPortfolio.Services.Config;

public static class ApiRoutes
{
	public const string Base = "http://localhost:5009";

	public static class Email
	{
		public const string Send = $"{Base}/send-email";
	}

	public static class Cooldown
	{
		public const string Info = $"{Base}/cooldown-info";
	}
}
