using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsWeekendDay(this DateTime @this)
		{
			return @this.DayOfWeek.IsWeekendDay()||@this.DayOfWeek.IsWeekendDay();
		}
	}
}