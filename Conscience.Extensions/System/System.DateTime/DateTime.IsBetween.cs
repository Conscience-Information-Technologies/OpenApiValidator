using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsBetween(this DateTime @this, DateTime minValue, DateTime maxValue)
		{
			return minValue.CompareTo(@this)==-1&&@this.CompareTo(maxValue)==-1;
		}

		public static Boolean IsInRange(this DateTime @this, DateTime startDate, DateTime endDate)
		{
			return @this.Date>=startDate.Date&&@this.Date<=endDate.Date;
		}
	}
}