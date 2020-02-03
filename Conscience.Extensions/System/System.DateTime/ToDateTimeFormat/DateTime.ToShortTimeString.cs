using System;
using System.Globalization;

namespace System
{
	public static partial class Extensions
	{
		public static string ToShortTimeString(this DateTime @this)
		{
			return @this.ToString("t", DateTimeFormatInfo.CurrentInfo);
		}

		public static string ToShortTimeString(this DateTime @this, string culture)
		{
			return @this.ToString("t", new CultureInfo(culture));
		}

		public static string ToShortTimeString(this DateTime @this, CultureInfo culture)
		{
			return @this.ToString("t", culture);
		}
	}
}