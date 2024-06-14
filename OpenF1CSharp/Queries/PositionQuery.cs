namespace OpenF1CSharp
{
	public class PositionQuery : BaseQuery<PositionData>
	{
		private static readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/position?";

		public PositionQuery() : base(DEFAULT_QUERY) { }
	}
}