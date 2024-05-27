namespace OpenF1CSharp;

public class LocationQuery : BaseQuery<LocationData>
{
	private static readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/location?";

	public LocationQuery() : base(DEFAULT_QUERY) { }
}