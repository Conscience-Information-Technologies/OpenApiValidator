using System;

namespace System
{
	public static partial class Extensions
	{
		public static Int32 FindIndex<T>(this T[] array, Predicate<T> match)
		{
			return Array.FindIndex(array, match);
		}

		public static Int32 FindIndex<T>(this T[] array, Int32 startIndex, Predicate<T> match)
		{
			return Array.FindIndex(array, startIndex, match);
		}

		public static Int32 FindIndex<T>(this T[] array, Int32 startIndex, Int32 count, Predicate<T> match)
		{
			return Array.FindIndex(array, startIndex, count, match);
		}
	}
}