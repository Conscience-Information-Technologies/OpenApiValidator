using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsExists<T>(this T[] array, Predicate<T> match)
		{
			return Array.Exists(array, match);
		}
	}
}