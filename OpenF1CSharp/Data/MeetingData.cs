using Newtonsoft.Json;

namespace OpenF1CSharp;

public struct MeetingData
{
    [JsonProperty("circuit_key")]
    public int? CircuitKey { get; set; }

    [JsonProperty("circuit_short_name")]
    public string? CircuitShortName { get; set; }

    [JsonProperty("country_code")]
    public string? CountryCode { get; set; }

    [JsonProperty("country_key")]
    public int? CountryKey { get; set; }

    [JsonProperty("country_name")]
    public string? CountryName { get; set; }

    [JsonProperty("date_start")]
    public DateTime? DateStart { get; set; }

    [JsonProperty("gmt_offset")]
    public string? GmtOffset { get; set; }

    [JsonProperty("location")]
    public string? Location { get; set; }

    [JsonProperty("meeting_key")]
    public int? MeetingKey { get; set; }

    [JsonProperty("meeting_name")]
    public string? MeetingName { get; set; }

    [JsonProperty("meeting_official_name")]
    public string? MeetingOfficialName { get; set; }

    [JsonProperty("year")]
    public int? Year { get; set; }
}