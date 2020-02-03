using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		static public (int Years, int Months, int Days, int Hours, int Minutes) GetAgeInDetail(this DateTime @this)
		{
			return @this.GetAgeInDetail(DateTime.Now);
		}

		static public (int Years, int Months, int Days, int Hours, int Minutes) GetAgeInDetail(this DateTime @this, DateTime latestDate)
		{
			DateTime now = latestDate;
			int Years = new DateTime(latestDate.Subtract(@this).Ticks).Year-1;
			DateTime PastYearDate = @this.AddYears(Years);
			int Months = 0;
			for(int i = 1; i<=12; i++)
			{
				if(PastYearDate.AddMonths(i)==now)
				{
					Months=i;
					break;
				}
				else if(PastYearDate.AddMonths(i)>=now)
				{
					Months=i-1;
					break;
				}
			}
			int Days = now.Subtract(PastYearDate.AddMonths(Months)).Days;
			int Hours = now.Subtract(PastYearDate).Hours;
			int Minutes = now.Subtract(PastYearDate).Minutes;
			int Seconds = now.Subtract(PastYearDate).Seconds;

			return (Years, Months, Days, Hours, Minutes);
		}
	}
}