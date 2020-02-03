using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsLeapYear(this DateTime @this)
		{
			return (System.DateTime.DaysInMonth(@this.Year, 2)==29);
		}
	}
}