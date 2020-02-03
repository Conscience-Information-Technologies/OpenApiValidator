using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static DateTime AddWorkingDays(this DateTime @this, int days)
		{
			// start from a weekday
			while(@this.IsWeekendDay())
				@this=@this.AddDays(1.0);
			for(int i = 0; i<days; ++i)
			{
				@this=@this.AddDays(1.0);
				while(@this.IsWeekendDay())
					@this=@this.AddDays(1.0);
			}
			return @this;
		}
	}
}