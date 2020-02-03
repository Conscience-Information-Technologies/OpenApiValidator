using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTime GetWeekStart(this DateTime @this, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
		{
			var weekStart = @this.GetClone();
			while(!GetWeekendDays().Contains(weekStart.DayOfWeek))
			{
				weekStart=weekStart.AddDays(-1);
			}

			return weekStart;
		}
	}
}