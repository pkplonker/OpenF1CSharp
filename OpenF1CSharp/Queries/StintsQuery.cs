namespace OpenF1CSharp
{
	public class StintsQuery : BaseQuery<StintData>
	{
		private static readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/stints?";

		public StintsQuery() : base(DEFAULT_QUERY) { }
	}
}