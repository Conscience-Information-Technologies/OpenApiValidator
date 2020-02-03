using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool GetPropertyValue<T>(this T @this, T minValue, T maxValue) where T : IComparable<T>
		{
			return minValue.CompareTo(@this)==-1&&@this.CompareTo(maxValue)==-1;
		}
	}
}
