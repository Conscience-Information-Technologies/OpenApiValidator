using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		private static List<DayOfWeek> _weekendDays = new List<DayOfWeek>() { DayOfWeek.Saturday, DayOfWeek.Sunday };

		public static void SetWeekendDays(List<DayOfWeek> weekendDays)
		{
			_weekendDays=weekendDays;
		}

		public static List<DayOfWeek> GetWeekendDays()
		{
			return _weekendDays;
		}
	}
}