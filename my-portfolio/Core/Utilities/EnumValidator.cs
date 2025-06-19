namespace MyPortfolio.Core.Utilities;

public static class EnumValidator
{
	public static TEnum ValidateOrDefault<TEnum>(TEnum value, TEnum fallback) where TEnum : struct, System.Enum
	{
		return System.Enum.IsDefined(value) ? value : fallback;
	}
}
