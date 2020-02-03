using System;

namespace System
{
	public static partial class Extensions
	{
		public static Boolean IsControl(this Char c)
		{
			return Char.IsControl(c);
		}
	}
}