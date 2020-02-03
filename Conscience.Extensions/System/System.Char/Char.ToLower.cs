using System;
using System.Globalization;

namespace System
{
	public static partial class Extensions
	{
		public static Char ToLower(this Char c, CultureInfo culture)
		{
			return Char.ToLower(c, culture);
		}

		public static Char ToLower(this Char c)
		{
			return Char.ToLower(c);
		}
	}
}