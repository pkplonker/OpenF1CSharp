namespace OpenF1CSharp;

public class PitQuery : BaseQuery<PitStopData>
{
	private static readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/pit?";

	public PitQuery() : base(DEFAULT_QUERY) { }
}