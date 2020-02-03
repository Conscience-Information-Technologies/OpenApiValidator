using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static DateTime GetDayEnd(this DateTime @this)
		{
			return new DateTime(@this.Year, @this.Month, @this.Day, 23, 59, 59, 999);
		}
	}
}