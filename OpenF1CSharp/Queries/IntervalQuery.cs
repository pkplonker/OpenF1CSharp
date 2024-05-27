namespace OpenF1CSharp;

public class IntervalQuery : BaseQuery<IntervalData>
{
	private static readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/intervals?";

	public IntervalQuery() : base(DEFAULT_QUERY) { }

}