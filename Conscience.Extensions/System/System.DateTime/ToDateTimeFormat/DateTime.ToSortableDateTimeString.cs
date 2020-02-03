using System;
using System.Globalization;

namespace System
{
	public static partial class Extensions
	{
		public static string ToSortableDateTimeString(this DateTime @this)
		{
			return @this.ToString("s", DateTimeFormatInfo.CurrentInfo);
		}

		public static string ToSortableDateTimeString(this DateTime @this, string culture)
		{
			return @this.ToString("s", new CultureInfo(culture));
		}

		public static string ToSortableDateTimeString(this DateTime @this, CultureInfo culture)
		{
			return @this.ToString("s", culture);
		}
	}
}