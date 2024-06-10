using System;
using Newtonsoft.Json;

namespace OpenF1CSharp
{
	public struct PitStopData
	{
		[JsonProperty("date")]
		public DateTime? Date { get; set; }

		[JsonProperty("driver_number")]
		public int? DriverNumber { get; set; }

		[JsonProperty("lap_number")]
		public int? LapNumber { get; set; }

		[JsonProperty("meeting_key")]
		public int? MeetingKey { get; set; }

		[JsonProperty("pit_duration")]
		public double? PitDuration { get; set; }

		[JsonProperty("session_key")]
		public int? SessionKey { get; set; }
	}
}

