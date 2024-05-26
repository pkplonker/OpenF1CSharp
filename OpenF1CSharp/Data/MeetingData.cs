using Newtonsoft.Json;

namespace OpenF1CSharp;

public struct MeetingData
{
	[JsonProperty("meeting_key")]
	public int? MeetingKey { get; set; }

	[JsonProperty("meeting_name")]
	public string? MeetingName { get; set; }

	[JsonProperty("circuit_key")]
	public int? CircuitKey { get; set; }

	[JsonProperty("year")]
	public int? Year { get; set; }

	[JsonProperty("session_keys")]
	public List<int>? SessionKeys { get; set; }
}