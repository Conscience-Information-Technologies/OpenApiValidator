using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsWeekDay(this DateTime @this)
		{
			return !@this.IsWeekendDay();
		}
	}
}