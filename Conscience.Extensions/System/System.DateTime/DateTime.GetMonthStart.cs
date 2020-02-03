using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTime GetMonthStart(this DateTime @this)
		{
			return new DateTime(@this.Year, @this.Month, 1);
		}
	}
}