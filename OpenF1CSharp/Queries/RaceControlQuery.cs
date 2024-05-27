namespace OpenF1CSharp;

public class RaceControlQuery : BaseQuery<RaceControlData>
{
	private static readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/race_control?";

	public RaceControlQuery() : base(DEFAULT_QUERY) { }
}