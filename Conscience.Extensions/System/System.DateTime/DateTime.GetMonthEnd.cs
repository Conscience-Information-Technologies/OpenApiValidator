using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTime GetMonthEnd(this DateTime @this)
		{
			return new DateTime(@this.Year, @this.Month, 1).AddMonths(1).AddDays(-1);
		}
	}
}