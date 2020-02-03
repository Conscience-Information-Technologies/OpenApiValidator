using System;

namespace System
{
	public static partial class Extensions
	{
		public static Int32 LastIndexOf<T>(this T[] array, Object value)
		{
			return Array.LastIndexOf(array, value);
		}

		public static Int32 LastIndexOf<T>(this T[] array, Object value, Int32 startIndex)
		{
			return Array.LastIndexOf(array, value, startIndex);
		}

		public static Int32 LastIndexOf<T>(this T[] array, Object value, Int32 startIndex, Int32 count)
		{
			return Array.LastIndexOf(array, value, startIndex, count);
		}
	}
}