using Newtonsoft.Json;

namespace OpenF1CSharp;

public struct TyreStint
{
	[JsonProperty("compound")]
	public string? Compound { get; set; }

	[JsonProperty("driver_number")]
	public int? DriverNumber { get; set; }

	[JsonProperty("lap_end")]
	public int? LapEnd { get; set; }

	[JsonProperty("lap_start")]
	public int? LapStart { get; set; }

	[JsonProperty("meeting_key")]
	public int? MeetingKey { get; set; }

	[JsonProperty("session_key")]
	public int? SessionKey { get; set; }

	[JsonProperty("stint_number")]
	public int? StintNumber { get; set; }

	[JsonProperty("tyre_age_at_start")]
	public int? TyreAgeAtStart { get; set; }
}
