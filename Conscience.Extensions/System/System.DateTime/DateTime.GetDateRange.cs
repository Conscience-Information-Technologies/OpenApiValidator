using System;
using System.Collections.Generic;
using System.Linq;

namespace System
{
	public static partial class Extensions
	{
		public static IEnumerable<DateTime> GetRange(this DateTime @this, DateTime toDate)
		{
			var range = Enumerable.Range(0, new TimeSpan(toDate.Ticks-@this.Ticks).Days);

			return from p in range select @this.Date.AddDays(p);
		}

		public static IEnumerable<DateTime> GetRange(this DateTime @this, int toDays)
		{
			DateTime toDate = @this.AddDays(toDays);

			return @this.GetRange(toDate);
		}
	}
}