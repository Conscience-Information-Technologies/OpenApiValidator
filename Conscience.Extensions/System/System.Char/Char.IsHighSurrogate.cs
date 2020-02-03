using System;

namespace System
{
	public static partial class Extensions
	{
		public static Boolean IsHighSurrogate(this Char c)
		{
			return Char.IsHighSurrogate(c);
		}
	}
}