using System;
using System.Collections;

namespace System
{
	public static partial class Extensions
	{
		public static void Sort<T>(this T[] array)
		{
			Array.Sort(array);
		}

		public static void Sort<T>(this T[] array, T[] items)
		{
			Array.Sort(array, items);
		}

		public static void Sort<T>(this T[] array, Int32 index, Int32 length)
		{
			Array.Sort(array, index, length);
		}

		public static void Sort<T>(this T[] array, T[] items, Int32 index, Int32 length)
		{
			Array.Sort(array, items, index, length);
		}

		public static void Sort<T>(this T[] array, IComparer comparer)
		{
			Array.Sort(array, comparer);
		}

		public static void Sort<T>(this T[] array, T[] items, IComparer comparer)
		{
			Array.Sort(array, items, comparer);
		}

		public static void Sort<T>(this T[] array, Int32 index, Int32 length, IComparer comparer)
		{
			Array.Sort(array, index, length, comparer);
		}

		public static void Sort<T>(this T[] array, T[] items, Int32 index, Int32 length, IComparer comparer)
		{
			Array.Sort(array, items, index, length, comparer);
		}
	}
}