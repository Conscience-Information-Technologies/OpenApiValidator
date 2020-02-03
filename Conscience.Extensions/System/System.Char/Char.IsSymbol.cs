using System;

namespace System
{
	public static partial class Extensions
	{
		public static Boolean IsSymbol(this Char c)
		{
			return Char.IsSymbol(c);
		}
	}
}