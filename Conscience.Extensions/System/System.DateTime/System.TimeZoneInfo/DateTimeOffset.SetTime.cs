using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTimeOffset SetTime(this DateTimeOffset current, int hour)
		{
			return SetTime(current, hour, 0, 0, 0);
		}

		public static DateTimeOffset SetTime(this DateTimeOffset current, int hour, int minute)
		{
			return SetTime(current, hour, minute, 0, 0);
		}

		public static DateTimeOffset SetTime(this DateTimeOffset current, int hour, int minute, int second)
		{
			return SetTime(current, hour, minute, second, 0);
		}

		public static DateTimeOffset SetTime(this DateTimeOffset current, int hour, int minute, int second, int millisecond)
		{
			return new DateTime(current.Year, current.Month, current.Day, hour, minute, second, millisecond);
		}
	}
}