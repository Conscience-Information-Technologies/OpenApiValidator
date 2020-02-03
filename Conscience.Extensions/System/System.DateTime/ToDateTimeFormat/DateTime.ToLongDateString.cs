using System;
using System.Globalization;

namespace System
{
	public static partial class Extensions
	{
		public static string ToLongDateString(this DateTime @this)
		{
			return @this.ToString("D", DateTimeFormatInfo.CurrentInfo);
		}

		public static string ToLongDateString(this DateTime @this, string culture)
		{
			return @this.ToString("D", new CultureInfo(culture));
		}

		public static string ToLongDateString(this DateTime @this, CultureInfo culture)
		{
			return @this.ToString("D", culture);
		}
	}
}