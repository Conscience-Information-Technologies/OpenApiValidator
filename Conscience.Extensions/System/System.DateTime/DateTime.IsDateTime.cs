using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsDateTime(this string @this, string dateFormat)
		{
			DateTime dateVal = default(DateTime);
			return DateTime.TryParseExact(@this, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateVal);
		}

		public static bool IsDateTime(this string @this, string[] dateFormat)
		{
			DateTime dateVal = default(DateTime);
			return DateTime.TryParseExact(@this, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateVal);
		}
	}
}