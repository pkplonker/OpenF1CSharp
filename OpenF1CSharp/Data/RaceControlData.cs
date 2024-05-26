using Newtonsoft.Json;

namespace OpenF1CSharp;

public struct RaceControlData
{
	[JsonProperty("message")]
	public string? Message { get; set; }

	[JsonProperty("date")]
	public DateTime? Date { get; set; }

	[JsonProperty("meeting_key")]
	public int? MeetingKey { get; set; }

	[JsonProperty("session_key")]
	public int? SessionKey { get; set; }

	[JsonProperty("message_type")]
	public string? MessageType { get; set; }
}