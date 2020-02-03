using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTime ConvertTimeFromUtc(this DateTime dateTime, TimeZoneInfo destinationTimeZone)
		{
			return TimeZoneInfo.ConvertTimeFromUtc(dateTime, destinationTimeZone);
		}
	}
}