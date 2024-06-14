using System;
using Newtonsoft.Json;

namespace OpenF1CSharp
{
	
	public struct PositionData
	{
		[JsonProperty("date")]
		public DateTime? Date { get; set; }
		
		[JsonProperty("driver_number")]
		public int? DriverNumber { get; set; }
		
		[JsonProperty("meeting_key")]
		public int? MeetingKey { get; set; }
		
		[JsonProperty("position")]
		public int? Position { get; set; }
		
		[JsonProperty("session_key")]
		public int? SessionKey { get; set; }
		
	}
}
