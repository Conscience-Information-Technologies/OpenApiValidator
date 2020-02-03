using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTime ConvertTimeBySystemTimeZoneId(this DateTime dateTime, String destinationTimeZoneId)
		{
			return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, destinationTimeZoneId);
		}

		public static DateTime ConvertTimeBySystemTimeZoneId(this DateTime dateTime, String sourceTimeZoneId, String destinationTimeZoneId)
		{
			return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, sourceTimeZoneId, destinationTimeZoneId);
		}
	}
}