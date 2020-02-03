using System;
using System.Globalization;

namespace System
{
	public static partial class Extensions
	{
		public static string ToUniversalSortableDateTimeString(this DateTime @this)
		{
			return @this.ToString("u", DateTimeFormatInfo.CurrentInfo);
		}

		public static string ToUniversalSortableDateTimeString(this DateTime @this, string culture)
		{
			return @this.ToString("u", new CultureInfo(culture));
		}

		public static string ToUniversalSortableDateTimeString(this DateTime @this, CultureInfo culture)
		{
			return @this.ToString("u", culture);
		}
	}
}