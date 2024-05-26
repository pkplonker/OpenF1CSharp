using Newtonsoft.Json;

namespace OpenF1CSharp;

public struct CarData
{
	[JsonProperty("brake")]
	public int? Brake { get; set; }

	[JsonProperty("date")]
	public DateTime? Date { get; set; }

	[JsonProperty("driver_number")]
	public int? DriverNumber { get; set; }

	[JsonProperty("drs")]
	public int? Drs { get; set; }

	[JsonProperty("meeting_key")]
	public int? MeetingKey { get; set; }

	[JsonProperty("n_gear")]
	public int? NGear { get; set; }

	[JsonProperty("rpm")]
	public int? Rpm { get; set; }

	[JsonProperty("session_key")]
	public int? SessionKey { get; set; }

	[JsonProperty("speed")]
	public int? Speed { get; set; }

	[JsonProperty("throttle")]
	public int? Throttle { get; set; }
}
