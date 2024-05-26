using Newtonsoft.Json;

namespace OpenF1CSharp;

public struct DriverData
{
	[JsonProperty("broadcast_name")]
	public string? BroadcastName { get; set; }

	[JsonProperty("country_code")]
	public string? CountryCode { get; set; }

	[JsonProperty("driver_number")]
	public int? DriverNumber { get; set; }

	[JsonProperty("first_name")]
	public string? FirstName { get; set; }

	[JsonProperty("full_name")]
	public string? FullName { get; set; }

	[JsonProperty("headshot_url")]
	public string? HeadshotUrl { get; set; }

	[JsonProperty("last_name")]
	public string? LastName { get; set; }

	[JsonProperty("meeting_key")]
	public int? MeetingKey { get; set; }

	[JsonProperty("name_acronym")]
	public string? NameAcronym { get; set; }

	[JsonProperty("session_key")]
	public int? SessionKey { get; set; }

	[JsonProperty("team_colour")]
	public string? TeamColour { get; set; }

	[JsonProperty("team_name")]
	public string? TeamName { get; set; }
}