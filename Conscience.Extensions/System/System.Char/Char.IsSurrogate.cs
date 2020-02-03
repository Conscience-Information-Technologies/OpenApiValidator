using System;

namespace System
{
	public static partial class Extensions
	{
		public static Boolean IsSurrogate(this Char c)
		{
			return Char.IsSurrogate(c);
		}
	}
}