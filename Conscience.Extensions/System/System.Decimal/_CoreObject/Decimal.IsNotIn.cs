using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsNotIn(this Decimal @this, params Decimal[] values)
		{
			return Array.IndexOf(values, @this)==-1;
		}
	}
}