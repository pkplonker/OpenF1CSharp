namespace OpenF1CSharp
{
	public class DriverQuery : BaseQuery<DriverData>
	{
		private static readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/drivers?";
		public DriverQuery() : base(DEFAULT_QUERY) { }
	}
}