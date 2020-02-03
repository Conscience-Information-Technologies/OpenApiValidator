using System;

namespace System
{
	public static partial class Extensions
	{
		public static void ClearAll<T>(this T[] @this)
		{
			Array.Clear(@this, 0, @this.Length);
		}
	}
}
