namespace OpenF1CSharp;

public class LapQuery
{
	private readonly QueryBuilder<LapData> queryBuilder;
	private readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/laps?";

	public LapQuery()
	{
		queryBuilder =
			new QueryBuilder<LapData>(DEFAULT_QUERY);
	}

	public void Reset()
	{
		queryBuilder.Reset(DEFAULT_QUERY);
	}

	public string GenerateQuery() => queryBuilder.Build();

	private LapQuery Filter<T>(string propertyName, T value, ComparisonOperator op = ComparisonOperator.Equal)
	{
		queryBuilder.Filter(propertyName, value, op);
		return this;
	}

	public LapQuery MeetingKey(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LapData.DriverNumber), val, op);

	public LapQuery SessionKey(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LapData.DriverNumber), val, op);

	public LapQuery DriverNumber(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LapData.DriverNumber), val, op);

	public LapQuery I1Speed(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LapData.I1Speed), val, op);

	public LapQuery I2Speed(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LapData.I2Speed), val, op);

	public LapQuery StSpeed(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LapData.StSpeed), val, op);

	public LapQuery DateStart(DateTime val, ComparisonOperator op = ComparisonOperator.GreaterThanOrEqual) =>
		Filter(nameof(LapData.DateStart), Utils.FormatDateTime(val), op);

	public LapQuery LapDuration(double val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LapData.LapDuration), val, op);

	public LapQuery IsPitOutLap(bool val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LapData.IsPitOutLap), val, op);

	public LapQuery DurationSector1(double val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LapData.DurationSector1), val, op);

	public LapQuery DurationSector2(double val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LapData.DurationSector2), val, op);

	public LapQuery DurationSector3(double val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LapData.DurationSector3), val, op);

	public LapQuery LapNumber(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(LapData.LapNumber), val, op);
}