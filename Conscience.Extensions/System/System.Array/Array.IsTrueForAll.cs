using System;

namespace System
{
	public static partial class Extensions
	{
		public static Boolean IsTrueForAll<T>(this T[] array, Predicate<T> match)
		{
			return Array.TrueForAll(array, match);
		}
	}
}