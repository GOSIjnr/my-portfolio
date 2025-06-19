namespace MyPortfolio.Models.Common;

public class AboutMeInfo(string introduction, Dictionary<string, string> introDetails)
{
	private string _introduction = introduction ?? string.Empty;
	private Dictionary<string, string> _introDetails = introDetails ?? [];

	public string Introduction
	{
		get => _introduction;
		set => _introduction = value ?? string.Empty;
	}

	public Dictionary<string, string> IntroDetails
	{
		get => _introDetails
			.Where(kv => !string.IsNullOrWhiteSpace(kv.Value))
			.ToDictionary(kv => kv.Key, kv => kv.Value);

		set => _introDetails = (value ?? [])
			.Where(kv => !string.IsNullOrWhiteSpace(kv.Key))
			.ToDictionary(kv => kv.Key, kv => kv.Value ?? string.Empty);
	}

	public AboutMeInfo() : this(
		"Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat voluptatum voluptas praesentium, odit reiciendis, doloremque magni aspernatur sequi inventore excepturi laudantium cupiditate tenetur id maxime at, iusto deleniti a illo.",
		new()
		{
			{ "Name", "Lorem ispum" },
			{ "Nationality", "Lorem ispum" },
			{ "Age", "Lorem ispum" },
			{ "Hobbies", "Lorem ispum" },
		}
	)
	{ }
}
