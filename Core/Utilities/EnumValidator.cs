namespace MyPortfolio.Helpers.Utilities;

public static class EnumValidator
{
	public static TEnum ValidateOrDefault<TEnum>(TEnum value, TEnum fallback) where TEnum : struct, Enum
	{
		return Enum.IsDefined(value) ? value : fallback;
	}
}
