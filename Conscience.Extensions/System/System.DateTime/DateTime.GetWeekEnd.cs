using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTime GetWeekEnd(this DateTime @this, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
		{
			var weekEnd = @this.GetClone();
			while(!GetWeekendDays().Contains(weekEnd.DayOfWeek))
			{
				weekEnd=weekEnd.AddDays(1);
			}

			return weekEnd;
		}
	}
}