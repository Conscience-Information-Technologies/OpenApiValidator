using System;

namespace System
{
	public static partial class Extensions
	{
		public static void ForEach<T>(this T[] array, Action<T> action)
		{
			Array.ForEach(array, action);
		}
	}
}