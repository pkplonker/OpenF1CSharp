using System;
using Newtonsoft.Json;

namespace OpenF1CSharp
{
	
	public struct WeatherData
	{
		[JsonProperty("air_temperature")]
		public double? AirTemperature { get; set; }

		[JsonProperty("date")]
		public DateTime? Date { get; set; }

		[JsonProperty("humidity")]
		public int? Humidity { get; set; }

		[JsonProperty("meeting_key")]
		public int? MeetingKey { get; set; }

		[JsonProperty("pressure")]
		public double? Pressure { get; set; }

		[JsonProperty("rainfall")]
		public double? Rainfall { get; set; }

		[JsonProperty("session_key")]
		public int? SessionKey { get; set; }

		[JsonProperty("track_temperature")]
		public double? TrackTemperature { get; set; }

		[JsonProperty("wind_direction")]
		public int? WindDirection { get; set; }

		[JsonProperty("wind_speed")]
		public double? WindSpeed { get; set; }
	}
}
