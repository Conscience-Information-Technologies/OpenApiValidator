using System;
using System.Globalization;

namespace System
{
	public static partial class Extensions
	{
		public static string ToLongDateTimeString(this DateTime @this)
		{
			return @this.ToString("F", DateTimeFormatInfo.CurrentInfo);
		}

		public static string ToLongDateTimeString(this DateTime @this, string culture)
		{
			return @this.ToString("F", new CultureInfo(culture));
		}

		public static string ToLongDateTimeString(this DateTime @this, CultureInfo culture)
		{
			return @this.ToString("F", culture);
		}
	}
}