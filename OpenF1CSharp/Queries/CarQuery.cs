namespace OpenF1CSharp;

public class CarQuery: BaseQuery<CarData>
{
	private static readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/car_data?";

	public CarQuery() : base(DEFAULT_QUERY) { }
	
	/// <summary>
	/// Convenience method for Brake property
	/// </summary>
	/// <param name="val">Value to filter</param>
	/// <returns>Builder Query adjusted for API expectation of 100 == true && 0 == false</returns>
	public BaseQuery<CarData> Brake(bool val = true) => Filter(nameof(CarData.Brake), val ? 100 : 0);

}