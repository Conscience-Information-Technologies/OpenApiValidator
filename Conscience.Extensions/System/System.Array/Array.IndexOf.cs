using System;

namespace System
{
	public static partial class Extensions
	{
		public static Int32 IndexOf<T>(this T[] array, Object value)
		{
			return Array.IndexOf(array, value);
		}

		public static Int32 IndexOf<T>(this T[] array, Object value, Int32 startIndex)
		{
			return Array.IndexOf(array, value, startIndex);
		}

		public static Int32 IndexOf<T>(this T[] array, Object value, Int32 startIndex, Int32 count)
		{
			return Array.IndexOf(array, value, startIndex, count);
		}
	}
}