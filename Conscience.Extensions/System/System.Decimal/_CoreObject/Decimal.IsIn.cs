using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsIn(this Decimal @this, params Decimal[] values)
		{
			return Array.IndexOf(values, @this)!=-1;
		}
	}
}