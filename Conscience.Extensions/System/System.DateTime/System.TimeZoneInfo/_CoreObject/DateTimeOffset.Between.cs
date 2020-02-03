using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool Between(this DateTimeOffset @this, DateTimeOffset minValue, DateTimeOffset maxValue)
		{
			return minValue.CompareTo(@this)==-1&&@this.CompareTo(maxValue)==-1;
		}
	}
}