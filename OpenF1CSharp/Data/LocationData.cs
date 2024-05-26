using Newtonsoft.Json;

namespace OpenF1CSharp;


public struct LocationData
{
	[JsonProperty("circuit_key")]
	public int? CircuitKey { get; set; }

	[JsonProperty("circuit_name")]
	public string? CircuitName { get; set; }

	[JsonProperty("country_code")]
	public string? CountryCode { get; set; }

	[JsonProperty("country_key")]
	public int? CountryKey { get; set; }

	[JsonProperty("country_name")]
	public string? CountryName { get; set; }

	[JsonProperty("latitude")]
	public double? Latitude { get; set; }

	[JsonProperty("longitude")]
	public double? Longitude { get; set; }

	[JsonProperty("location")]
	public string? Location { get; set; }
}