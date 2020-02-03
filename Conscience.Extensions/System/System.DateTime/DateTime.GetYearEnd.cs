using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTime GetEndOfYear(this DateTime @this)
		{
			return new DateTime(@this.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
		}
	}
}