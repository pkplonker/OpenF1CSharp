using System;
using Newtonsoft.Json;

namespace OpenF1CSharp
{
	public struct LocationData
	{
		[JsonProperty("date")]
		public DateTime? Date { get; set; }

		[JsonProperty("driver_number")]
		public string? DriverNumber { get; set; }

		[JsonProperty("meeting_key")]
		public string? MeetingKey { get; set; }

		[JsonProperty("session_key")]
		public int? SessionKey { get; set; }

		[JsonProperty("x")]
		public int? X { get; set; }

		[JsonProperty("y")]
		public int? Y { get; set; }

		[JsonProperty("z")]
		public int? Z { get; set; }
	}
}

