using Newtonsoft.Json;

namespace OpenF1CSharp;


public struct RaceData
{
	[JsonProperty("date")]
	public DateTime? Date { get; set; }

	[JsonProperty("driver_number")]
	public int? DriverNumber { get; set; }

	[JsonProperty("gap_to_leader")]
	public double? GapToLeader { get; set; }

	[JsonProperty("interval")]
	public double? Interval { get; set; }

	[JsonProperty("meeting_key")]
	public int? MeetingKey { get; set; }

	[JsonProperty("session_key")]
	public int? SessionKey { get; set; }
}