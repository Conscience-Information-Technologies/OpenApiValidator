using System;
using System.Globalization;

namespace System
{
	public static partial class Extensions
	{
		public static string ToShortDateLongTimeString(this DateTime @this)
		{
			return @this.ToString("G", DateTimeFormatInfo.CurrentInfo);
		}

		public static string ToShortDateLongTimeString(this DateTime @this, string culture)
		{
			return @this.ToString("G", new CultureInfo(culture));
		}

		public static string ToShortDateLongTimeString(this DateTime @this, CultureInfo culture)
		{
			return @this.ToString("G", culture);
		}
	}
}