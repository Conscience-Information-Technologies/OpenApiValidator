using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTimeOffset ConvertTime(this DateTimeOffset dateTimeOffset, TimeZoneInfo destinationTimeZone)
		{
			return TimeZoneInfo.ConvertTime(dateTimeOffset, destinationTimeZone);
		}
	}
}