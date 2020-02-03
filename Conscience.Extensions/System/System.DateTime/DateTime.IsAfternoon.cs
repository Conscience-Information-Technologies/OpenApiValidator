using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsAfternoon(this DateTime @this)
		{
			return @this.TimeOfDay>=new DateTime(2000, 1, 1, 12, 0, 0).TimeOfDay;
		}
	}
}