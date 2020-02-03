using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool NotIn(this DateTimeOffset @this, params DateTimeOffset[] values)
		{
			return Array.IndexOf(values, @this)==-1;
		}
	}
}