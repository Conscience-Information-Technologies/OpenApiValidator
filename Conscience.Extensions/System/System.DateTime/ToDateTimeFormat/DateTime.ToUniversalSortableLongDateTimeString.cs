using System;
using System.Globalization;

namespace System
{
	public static partial class Extensions
	{
		public static string ToUniversalSortableLongDateTimeString(this DateTime @this)
		{
			return @this.ToString("U", DateTimeFormatInfo.CurrentInfo);
		}

		public static string ToUniversalSortableLongDateTimeString(this DateTime @this, string culture)
		{
			return @this.ToString("U", new CultureInfo(culture));
		}

		public static string ToUniversalSortableLongDateTimeString(this DateTime @this, CultureInfo culture)
		{
			return @this.ToString("U", culture);
		}
	}
}