namespace OpenF1CSharp;

public class DriverQuery
{
	private readonly QueryBuilder<DriverData> queryBuilder;
	private readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/drivers?";

	public DriverQuery()
	{
		queryBuilder =
			new QueryBuilder<DriverData>(DEFAULT_QUERY);
	}

	public void Reset()
	{
		queryBuilder.Reset(DEFAULT_QUERY);
	}

	public string GenerateQuery() => queryBuilder.Build();

	private DriverQuery Filter<T>(string propertyName, T value, ComparisonOperator op = ComparisonOperator.Equal)
	{
		queryBuilder.Filter(propertyName, value, op);
		return this;
	}

	public DriverQuery BroadcastName(string val) =>
		Filter(nameof(DriverData.BroadcastName), val);

	public DriverQuery CountryCode(string val) =>
		Filter(nameof(DriverData.CountryCode), val);

	public DriverQuery DriverNumber(string val) =>
		Filter(nameof(DriverData.DriverNumber), val);

	public DriverQuery FirstName(string val) =>
		Filter(nameof(DriverData.FirstName), val);

	public DriverQuery FullName(string val) =>
		Filter(nameof(DriverData.FullName), val);

	public DriverQuery HeadshotUrl(string val) =>
		Filter(nameof(DriverData.HeadshotUrl), val);

	public DriverQuery LastName(string val) =>
		Filter(nameof(DriverData.LastName), val);

	public DriverQuery MeetingKey(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(DriverData.MeetingKey), val, op);

	public DriverQuery NameAcronym(string val) =>
		Filter(nameof(DriverData.NameAcronym), val);

	public DriverQuery SessionKey(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(DriverData.SessionKey), val, op);

	public DriverQuery TeamColour(string val) =>
		Filter(nameof(DriverData.TeamColour), val);

	public DriverQuery TeamName(string val) =>
		Filter(nameof(DriverData.TeamName), val);
}