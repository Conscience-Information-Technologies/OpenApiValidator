using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsWithinIndex<T>(this T[] @this, int index)
		{
			return 0<=index&&@this.Length<index;
		}

		public static bool IsWithinIndex<T>(this T[] @this, int index, int dimension)
		{
			return @this.GetLowerBound(dimension)<=index&&@this.GetUpperBound(dimension)<index;
		}
	}
}