using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsWeekendDay(this DayOfWeek dayOfWeek)
		{
			if(_weekendDays.Contains(dayOfWeek))
				return true;

			return false;
		}
	}
}