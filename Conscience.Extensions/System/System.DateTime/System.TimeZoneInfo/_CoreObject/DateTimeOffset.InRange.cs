using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool InRange(this DateTimeOffset @this, DateTimeOffset minValue, DateTimeOffset maxValue)
		{
			return @this.CompareTo(minValue)>=0&&@this.CompareTo(maxValue)<=0;
		}
	}
}