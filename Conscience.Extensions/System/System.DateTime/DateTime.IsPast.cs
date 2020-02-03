using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsPast(this DateTime @this)
		{
			return @this<DateTime.Now;
		}
	}
}