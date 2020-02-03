using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTime ConvertTimeToUtc(this DateTime dateTime)
		{
			return TimeZoneInfo.ConvertTimeToUtc(dateTime);
		}

		public static DateTime ConvertTimeToUtc(this DateTime dateTime, TimeZoneInfo sourceTimeZone)
		{
			return TimeZoneInfo.ConvertTimeToUtc(dateTime, sourceTimeZone);
		}
	}
}