using System;

namespace System
{
	public static partial class Extensions
	{
		public static void Copy<T>(this T[] sourceArray, T[] destinationArray, Int32 length)
		{
			Array.Copy(sourceArray, destinationArray, length);
		}

		public static void Copy<T>(this T[] sourceArray, Int32 sourceIndex, T[] destinationArray, Int32 destinationIndex, Int32 length)
		{
			Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
		}

		public static void Copy<T>(this T[] sourceArray, T[] destinationArray, Int64 length)
		{
			Array.Copy(sourceArray, destinationArray, length);
		}

		public static void Copy<T>(this T[] sourceArray, Int64 sourceIndex, T[] destinationArray, Int64 destinationIndex, Int64 length)
		{
			Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
		}
	}
}