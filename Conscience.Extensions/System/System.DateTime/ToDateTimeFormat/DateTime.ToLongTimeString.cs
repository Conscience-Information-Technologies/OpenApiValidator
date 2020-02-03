using System;
using System.Globalization;

namespace System
{
	public static partial class Extensions
	{
		public static string ToLongTimeString(this DateTime @this)
		{
			return @this.ToString("T", DateTimeFormatInfo.CurrentInfo);
		}

		public static string ToLongTimeString(this DateTime @this, string culture)
		{
			return @this.ToString("T", new CultureInfo(culture));
		}

		public static string ToLongTimeString(this DateTime @this, CultureInfo culture)
		{
			return @this.ToString("T", culture);
		}
	}
}