using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsFalse(this bool @this)
		{
			return @this==false;
		}
	}
}