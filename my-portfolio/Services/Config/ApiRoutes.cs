namespace MyPortfolio.Services.Config;

public static class ApiRoutes
{
	public const string Base = "https://my-portfolio-backend-10vn.onrender.com";

	public static class Email
	{
		public const string Send = $"{Base}/send-email";
	}

	public static class Cooldown
	{
		public const string Info = $"{Base}/cooldown-info";
	}
}
