using System;

namespace System
{
	public static partial class Extensions
	{
		public static void Reverse<T>(this T[] array)
		{
			Array.Reverse(array);
		}

		public static void Reverse<T>(this T[] array, Int32 index, Int32 length)
		{
			Array.Reverse(array, index, length);
		}
	}
}