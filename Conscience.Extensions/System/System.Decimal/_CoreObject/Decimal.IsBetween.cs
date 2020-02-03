using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsBetween(this Decimal @this, Decimal minValue, Decimal maxValue)
		{
			return minValue.CompareTo(@this)==-1&&@this.CompareTo(maxValue)==-1;
		}
	}
}