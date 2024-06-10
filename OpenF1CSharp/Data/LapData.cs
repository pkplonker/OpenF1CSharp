using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenF1CSharp
{
	
	public struct LapData
	{
		[JsonProperty("meeting_key")] public int? MeetingKey { get; set; }

		[JsonProperty("session_key")] public int? SessionKey { get; set; }

		[JsonProperty("driver_number")] public int? DriverNumber { get; set; }

		[JsonProperty("i1_speed")] public int? I1Speed { get; set; }

		[JsonProperty("i2_speed")] public int? I2Speed { get; set; }

		[JsonProperty("st_speed")] public int? StSpeed { get; set; }

		[JsonProperty("date_start")] public DateTime? DateStart { get; set; }

		[JsonProperty("lap_duration")] public double? LapDuration { get; set; }

		[JsonProperty("is_pit_out_lap")] public bool? IsPitOutLap { get; set; }

		[JsonProperty("duration_sector_1")] public double? DurationSector1 { get; set; }

		[JsonProperty("duration_sector_2")] public double? DurationSector2 { get; set; }

		[JsonProperty("duration_sector_3")] public double? DurationSector3 { get; set; }

		[JsonProperty("segments_sector_1")] public List<int?> SegmentsSector1 { get; set; }

		[JsonProperty("segments_sector_2")] public List<int?> SegmentsSector2 { get; set; }

		[JsonProperty("segments_sector_3")] public List<int?> SegmentsSector3 { get; set; }

		[JsonProperty("lap_number")] public int? LapNumber { get; set; }
	}
}
