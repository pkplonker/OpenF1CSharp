using System;
using Newtonsoft.Json;

namespace OpenF1CSharp
{
	
	public struct PitPositionData
	{
		[JsonProperty("meeting_key")]
		public int? MeetingKey { get; set; }

		[JsonProperty("session_key")]
		public int? SessionKey { get; set; }

		[JsonProperty("driver_number")]
		public int? DriverNumber { get; set; }

		[JsonProperty("position")]
		public int? Position { get; set; }

		[JsonProperty("time")]
		public DateTime? Time { get; set; }

		[JsonProperty("lap_number")]
		public int? LapNumber { get; set; }
	}
}
