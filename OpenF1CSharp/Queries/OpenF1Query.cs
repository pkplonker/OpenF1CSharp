namespace OpenF1CSharp;

public interface IOpenF1Query
{
	public static string OPENF1_ADDRESS = "https://api.openf1.org/v1";
	public string GenerateQuery();
	public void Reset();
}