using System;

namespace System
{
	public static partial class Extensions
	{
		public static T[] FindAll<T>(this T[] array, Predicate<T> match)
		{
			return Array.FindAll(array, match);
		}
	}
}