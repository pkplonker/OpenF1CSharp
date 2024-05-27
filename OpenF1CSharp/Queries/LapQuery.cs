namespace OpenF1CSharp;

public class LapQuery : BaseQuery<LapData>
{
	private static readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/laps?";

	public LapQuery() : base(DEFAULT_QUERY) { }
}