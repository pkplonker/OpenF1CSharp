namespace OpenF1CSharp
{
	public class TeamRadioQuery : BaseQuery<TeamRadioData>
	{
		private static readonly string DEFAULT_QUERY = $"{IOpenF1Query.OPENF1_ADDRESS}/team_radio?";

		public TeamRadioQuery() : base(DEFAULT_QUERY) { }
	}
}