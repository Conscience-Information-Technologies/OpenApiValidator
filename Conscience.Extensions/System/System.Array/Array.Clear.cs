using System;

namespace System
{
	public static partial class Extensions
	{
		public static void Clear<T>(this T[] array, Int32 index, Int32 length)
		{
			Array.Clear(array, index, length);
		}
	}
}