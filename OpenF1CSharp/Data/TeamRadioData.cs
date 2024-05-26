using Newtonsoft.Json;

namespace OpenF1CSharp;

public struct TeamRadio
{
	[JsonProperty("date")]
	public DateTime? Date { get; set; }

	[JsonProperty("driver_number")]
	public int? DriverNumber { get; set; }

	[JsonProperty("meeting_key")]
	public int? MeetingKey { get; set; }

	[JsonProperty("recording_url")]
	public string? RecordingUrl { get; set; }

	[JsonProperty("session_key")]
	public int? SessionKey { get; set; }
}