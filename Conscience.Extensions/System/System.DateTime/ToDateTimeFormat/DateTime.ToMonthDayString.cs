using System;
using System.Globalization;

namespace System
{
	public static partial class Extensions
	{
		public static string ToMonthDayString(this DateTime @this)
		{
			return @this.ToString("m", DateTimeFormatInfo.CurrentInfo);
		}

		public static string ToMonthDayString(this DateTime @this, string culture)
		{
			return @this.ToString("m", new CultureInfo(culture));
		}

		public static string ToMonthDayString(this DateTime @this, CultureInfo culture)
		{
			return @this.ToString("m", culture);
		}
	}
}