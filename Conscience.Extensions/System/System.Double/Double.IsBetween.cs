using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsBetween(this Double @this, Double minValue, Double maxValue)
		{
			return minValue.CompareTo(@this)==-1&&@this.CompareTo(maxValue)==-1;
		}
	}
}