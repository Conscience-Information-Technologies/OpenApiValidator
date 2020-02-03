using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsNow(this DateTime @this)
		{
			return @this==DateTime.Now;
		}
	}
}