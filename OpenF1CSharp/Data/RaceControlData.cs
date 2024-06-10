using System;
using Newtonsoft.Json;

namespace OpenF1CSharp
{
	public struct RaceControlData
	{
		[JsonProperty("category")]
		public string? Category { get; set; }

		[JsonProperty("date")]
		public DateTime? Date { get; set; }

		[JsonProperty("driver_number")]
		public int? DriverNumber { get; set; }

		[JsonProperty("flag")]
		public string? Flag { get; set; }

		[JsonProperty("lap_number")]
		public string? LapNumber { get; set; }

		[JsonProperty("meeting_key")]
		public string? MeetingKey { get; set; }

		[JsonProperty("message")]
		public string? Message { get; set; }

		[JsonProperty("scope")]
		public string? Scope { get; set; }

		[JsonProperty("sector")]
		public int? Sector { get; set; }

		[JsonProperty("session_key")]
		public int? SessionKey { get; set; }
	}
}