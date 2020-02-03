using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTime GetClone(this DateTime @this)
		{
			return new DateTime(@this.Year, @this.Month, @this.Day, @this.Hour, @this.Minute, @this.Second, @this.Millisecond, @this.Kind);
		}
	}
}