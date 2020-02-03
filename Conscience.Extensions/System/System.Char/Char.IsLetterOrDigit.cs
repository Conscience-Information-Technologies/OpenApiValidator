using System;

namespace System
{
	public static partial class Extensions
	{
		public static Boolean IsLetterOrDigit(this Char c)
		{
			return Char.IsLetterOrDigit(c);
		}
	}
}