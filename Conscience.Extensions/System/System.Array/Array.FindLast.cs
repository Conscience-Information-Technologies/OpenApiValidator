using System;

namespace System
{
	public static partial class Extensions
	{
		public static T FindLast<T>(this T[] array, Predicate<T> match)
		{
			return Array.FindLast(array, match);
		}
	}
}