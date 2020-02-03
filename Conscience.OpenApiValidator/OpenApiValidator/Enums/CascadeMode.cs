namespace Conscience.OpenApiValidator
{
	/// <summary>
	/// Specifies how rules should cascade when one fails.
	/// </summary>
	public enum CascadeMode
	{
		Continue,
		StopOnFirstFailure,
		ContinueForEachFirstFailure,
	}
}
