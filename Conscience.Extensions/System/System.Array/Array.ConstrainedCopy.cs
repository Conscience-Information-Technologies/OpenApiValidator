using System;

namespace System
{
	public static partial class Extensions
	{
		public static void ConstrainedCopy<T>(this T[] sourceArray, Int32 sourceIndex, T[] destinationArray, Int32 destinationIndex, Int32 length)
		{
			Array.ConstrainedCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
		}
	}
}