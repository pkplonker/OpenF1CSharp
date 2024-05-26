namespace OpenF1CSharp;

public class CarDataQuery
{
	private readonly QueryBuilder<CarData> queryBuilder;
	private const string DEFAULT_QUERY = "https://api.openf1.org/v1/car_data?";

	public CarDataQuery()
	{
		queryBuilder =
			new QueryBuilder<CarData>(DEFAULT_QUERY);
	}

	public void Reset()
	{
		queryBuilder.Reset(DEFAULT_QUERY);
	}

	public string GenerateQuery() => queryBuilder.Build();

	private CarDataQuery Filter<T>(string propertyName, T value, ComparisonOperator op = ComparisonOperator.Equal)
	{
		queryBuilder.Filter(propertyName, value, op);
		return this;
	}

	public CarDataQuery Brake(bool val = true) => Filter(nameof(CarData.Brake), val ? 100 : 0);

	public CarDataQuery Date(DateTime val, ComparisonOperator op = ComparisonOperator.GreaterThan) =>
		Filter(nameof(CarData.Date), Utils.FormatDateTime(val), op);

	public CarDataQuery DriverNumber(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.DriverNumber), val, op);

	public CarDataQuery Drs(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.Drs), val, op);

	public CarDataQuery MeetingKey(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.MeetingKey), val, op);

	public CarDataQuery NGear(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.NGear), val, op);

	public CarDataQuery Rpm(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.Rpm), val, op);

	public CarDataQuery SessionKey(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.SessionKey), val, op);

	public CarDataQuery Speed(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.Speed), val, op);

	public CarDataQuery Throttle(int val, ComparisonOperator op = ComparisonOperator.Equal) =>
		Filter(nameof(CarData.Throttle), val, op);
}