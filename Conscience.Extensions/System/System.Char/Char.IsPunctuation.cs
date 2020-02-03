using System;

namespace System
{
	public static partial class Extensions
	{
		public static Boolean IsPunctuation(this Char c)
		{
			return Char.IsPunctuation(c);
		}
	}
}