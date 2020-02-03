using System;

namespace System
{
	public static partial class Extensions
	{
		public static Int32 FindLastIndex<T>(this T[] array, Predicate<T> match)
		{
			return Array.FindLastIndex(array, match);
		}

		public static Int32 FindLastIndex<T>(this T[] array, Int32 startIndex, Predicate<T> match)
		{
			return Array.FindLastIndex(array, startIndex, match);
		}

		public static Int32 FindLastIndex<T>(this T[] array, Int32 startIndex, Int32 count, Predicate<T> match)
		{
			return Array.FindLastIndex(array, startIndex, count, match);
		}
	}
}