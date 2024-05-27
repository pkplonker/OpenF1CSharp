namespace OpenF1CSharp;

public class MeetingQuery : BaseQuery<MeetingData>
{
	private static readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/meetings?";

	public MeetingQuery() : base(DEFAULT_QUERY) { }
}