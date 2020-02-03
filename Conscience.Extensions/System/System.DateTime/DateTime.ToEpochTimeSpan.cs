using System;

namespace System
{
	public static partial class Extensions
	{
		public static TimeSpan ToEpochTimeSpan(this DateTime @this)
		{
			return @this.Subtract(new DateTime(1970, 1, 1));
		}
	}
}