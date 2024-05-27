namespace OpenF1CSharp;

public class SessionQuery : BaseQuery<SessionData>
{
	private static readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/sessions?";

	public SessionQuery() : base(DEFAULT_QUERY) { }
}