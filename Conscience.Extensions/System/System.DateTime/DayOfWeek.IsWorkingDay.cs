using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsWorkingDay(this DayOfWeek dayOfWeek)
		{
			if(!dayOfWeek.IsWeekendDay())
				return true;

			return false;
		}
	}
}