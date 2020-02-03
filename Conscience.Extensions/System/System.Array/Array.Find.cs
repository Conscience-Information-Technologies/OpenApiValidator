using System;

namespace System
{
	public static partial class Extensions
	{
		public static T Find<T>(this T[] array, Predicate<T> match)
		{
			return Array.Find(array, match);
		}
	}
}