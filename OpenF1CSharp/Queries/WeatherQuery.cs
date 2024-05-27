namespace OpenF1CSharp;

public class WeatherQuery : BaseQuery<WeatherData>
{
	private static readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/weather?";

	public WeatherQuery() : base(DEFAULT_QUERY) { }
}