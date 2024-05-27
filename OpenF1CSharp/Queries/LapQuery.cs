namespace OpenF1CSharp;

public class LocationQuery
{
	private readonly QueryBuilder<LocationData> queryBuilder;
	private readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/laps?";

	public LocationQuery()
	{
		queryBuilder =
			new QueryBuilder<LocationData>(DEFAULT_QUERY);
	}

	public void Reset()
	{
		queryBuilder.Reset(DEFAULT_QUERY);
	}

	public string GenerateQuery() => queryBuilder.Build();

	private LocationQuery Filter<T>(string propertyName, T value, ComparisonOperator op = ComparisonOperator.Equal)
	{
		queryBuilder.Filter(propertyName, value, op);
		return this;
	}

	public LocationQuery CircuitKey(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LocationData.CircuitKey), val, op);

	public LocationQuery CircuitName(string val) =>
		Filter(nameof(LocationData.CircuitName), val);

	public LocationQuery CountryCode(string val) =>
		Filter(nameof(LocationData.CountryCode), val);

	public LocationQuery CountryKey(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LocationData.CountryKey), val, op);

	public LocationQuery CountryName(string val) =>
		Filter(nameof(LocationData.CountryName), val);

	public LocationQuery Latitude(double val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LocationData.Latitude), val, op);

	public LocationQuery Longitude(double val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LocationData.Longitude), val, op);

	public LocationQuery Location(string val) =>
		Filter(nameof(LocationData.Location), val);
}