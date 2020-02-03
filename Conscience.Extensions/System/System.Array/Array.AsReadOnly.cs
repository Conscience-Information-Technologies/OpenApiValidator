using System;
using System.Collections.ObjectModel;

namespace System
{
	public static partial class Extensions
	{
		public static ReadOnlyCollection<T> AsReadOnly<T>(this T[] array)
		{
			return Array.AsReadOnly(array);
		}
	}
}