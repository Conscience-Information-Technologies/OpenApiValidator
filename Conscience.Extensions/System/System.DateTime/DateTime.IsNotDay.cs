using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsNotDay(this DateTime @this, DayOfWeek dayOfWeek)
		{
			return !@this.IsDay(dayOfWeek);
		}
	}
}