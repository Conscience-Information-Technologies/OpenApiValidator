using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsFuture(this DateTime @this)
		{
			return @this>DateTime.Now;
		}
	}
}