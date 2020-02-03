using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsInRange<T>(this T @this, T minValue, T maxValue) where T : IComparable<T>
		{
			return @this.CompareTo(minValue)>=0&&@this.CompareTo(maxValue)<=0;
		}
	}
}