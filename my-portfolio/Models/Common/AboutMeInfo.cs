namespace MyPortfolio.Models.Common;

public class AboutMeInfo
{
	public required string Introduction { get; init; }
	public required Dictionary<string, string> PersonalDetails { get; init; }

	public static AboutMeInfo Default => new()
	{
		Introduction = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat voluptatum voluptas praesentium, odit reiciendis, doloremque magni aspernatur sequi inventore excepturi laudantium cupiditate tenetur id maxime at, iusto deleniti a illo.",
		PersonalDetails = new Dictionary<string, string>
		{
			{ "Name", "John Doe" },
			{ "Experience", "5 years" },
			{ "Nationality", "Global Citizen" },
			{ "Email", "john@example.com" },
			{ "Language", "English" },
			{ "Hobbies", "Reading, Traveling, Photography" },
		}
	};
}
