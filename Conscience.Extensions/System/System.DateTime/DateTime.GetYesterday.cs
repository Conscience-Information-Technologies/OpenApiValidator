using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTime GetYesterDay(this DateTime @this)
		{
			return @this.AddDays(-1);
		}
	}
}