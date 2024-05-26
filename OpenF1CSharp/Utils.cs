namespace OpenF1CSharp;

public class Utils
{
	public static string FormatDateTime<TValue>(TValue value)
	{
		ArgumentNullException.ThrowIfNull(value);
		if (value is DateTime dateTime)
		{
			return dateTime.ToString("yyyy-MM-ddTHH:mm:ss.fff");
		}
		return value?.ToString() ??string.Empty;
	}
}