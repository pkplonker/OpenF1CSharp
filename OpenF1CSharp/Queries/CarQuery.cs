namespace OpenF1CSharp;

public class CarQuery
{
	private readonly QueryBuilder<CarData> queryBuilder;
	private readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/car_data?";

	public CarQuery()
	{
		queryBuilder =
			new QueryBuilder<CarData>(DEFAULT_QUERY);
	}

	public void Reset()
	{
		queryBuilder.Reset(DEFAULT_QUERY);
	}

	public string GenerateQuery() => queryBuilder.Build();

	private CarQuery Filter<T>(string propertyName, T value, ComparisonOperator op = ComparisonOperator.Equal)
	{
		queryBuilder.Filter(propertyName, value, op);
		return this;
	}

	public CarQuery Brake(bool val = true) => Filter(nameof(CarData.Brake), val ? 100 : 0);

	public CarQuery Date(DateTime val, ComparisonOperator op = ComparisonOperator.GreaterThanOrEqual) =>
		Filter(nameof(CarData.Date), Utils.FormatDateTime(val), op);

	public CarQuery DriverNumber(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.DriverNumber), val, op);

	public CarQuery Drs(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.Drs), val, op);

	public CarQuery MeetingKey(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.MeetingKey), val, op);

	public CarQuery NGear(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.NGear), val, op);

	public CarQuery Rpm(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.Rpm), val, op);

	public CarQuery SessionKey(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.SessionKey), val, op);

	public CarQuery Speed(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.Speed), val, op);

	public CarQuery Throttle(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.Throttle), val, op);
}