using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsDay(this DateTime @this, DayOfWeek dayOfWeek)
		{
			return @this.DayOfWeek==dayOfWeek;
		}
	}
}