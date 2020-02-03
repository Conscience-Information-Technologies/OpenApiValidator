using System;

namespace System
{
	public static partial class Extensions
	{
		public static DateTime GetYearStart(this DateTime @this)
		{
			return new DateTime(@this.Year, 1, 1);
		}
	}
}