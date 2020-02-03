using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsLastDayOfTheMonth(this DateTime @this)
		{
			return @this==new DateTime(@this.Year, @this.Month, 1).AddMonths(1).AddDays(-1);
		}
	}
}