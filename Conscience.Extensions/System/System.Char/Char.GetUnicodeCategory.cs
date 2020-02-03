using System;
using System.Globalization;

namespace System
{
	public static partial class Extensions
	{
		public static UnicodeCategory GetUnicodeCategory(this Char c)
		{
			return Char.GetUnicodeCategory(c);
		}
	}
}