using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTime LastDayOfWeek(this DateTime @this)
		{
			return new DateTime(@this.Year, @this.Month, @this.Day).AddDays(6-(int)@this.DayOfWeek);
		}
	}
}