using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTimeOffset ConvertTimeBySystemTimeZoneId(this DateTimeOffset dateTimeOffset, String destinationTimeZoneId)
		{
			return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTimeOffset, destinationTimeZoneId);
		}
	}
}