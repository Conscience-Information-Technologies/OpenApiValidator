using System;
using System.Globalization;

namespace System
{
	public static partial class Extensions
	{
		public static Char ToUpper(this Char c, CultureInfo culture)
		{
			return Char.ToUpper(c, culture);
		}

		public static Char ToUpper(this Char c)
		{
			return Char.ToUpper(c);
		}
	}
}