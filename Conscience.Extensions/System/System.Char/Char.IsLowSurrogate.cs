using System;

namespace System
{
	public static partial class Extensions
	{
		public static Boolean IsLowSurrogate(this Char c)
		{
			return Char.IsLowSurrogate(c);
		}
	}
}