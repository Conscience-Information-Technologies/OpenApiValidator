using System;

namespace System
{
	public static partial class Extensions
	{
		public static T[] RemoveAt<T>(this T[] @this, int at)
		{
			Array.Clear(@this, at, 1);
			return @this;
		}
	}
}