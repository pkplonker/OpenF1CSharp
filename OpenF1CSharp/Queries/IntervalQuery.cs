namespace OpenF1CSharp;

public class IntervalQuery
{
	private readonly QueryBuilder<IntervalData> queryBuilder;
	private readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/intervals?";

	public IntervalQuery()
	{
		queryBuilder =
			new QueryBuilder<IntervalData>(DEFAULT_QUERY);
	}

	public void Reset()
	{
		queryBuilder.Reset(DEFAULT_QUERY);
	}

	public string GenerateQuery() => queryBuilder.Build();

	private IntervalQuery Filter<T>(string propertyName, T value, ComparisonOperator op = ComparisonOperator.Equal)
	{
		queryBuilder.Filter(propertyName, value, op);
		return this;
	}

	public IntervalQuery Date(DateTime val, ComparisonOperator op = ComparisonOperator.GreaterThanOrEqual) =>
		Filter(nameof(CarData.Date), Utils.FormatDateTime(val), op);

	public IntervalQuery DriverNumber(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.DriverNumber), val, op);

	public IntervalQuery GapToLeader(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.DriverNumber), val, op);

	public IntervalQuery Interval(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.DriverNumber), val, op);

	public IntervalQuery MeetingKey(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.DriverNumber), val, op);

	public IntervalQuery SessionKey(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.DriverNumber), val, op);
}