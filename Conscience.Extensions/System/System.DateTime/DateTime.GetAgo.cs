using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static string Ago(this DateTime oldDateThis, DateTime? latestDateOrNow = null)
		{
			throw new NotImplementedException("Please complete implimentation, Logically not corret method.");

			DateTime latest = latestDateOrNow==null ? DateTime.Now : latestDateOrNow.Value;
			var timespan = latest-oldDateThis;
			string ago = string.Empty;
			if(timespan.Days>365)
			{
				ago+=AgoYears(oldDateThis, latestDateOrNow);
			}
			if((timespan.Days%365)>30)
			{
				ago=(ago==string.Empty ? "" : ", ")+AgoMonths(oldDateThis.AddYears(latest.Year), latestDateOrNow);
			}
			if(((timespan.Days%365)%30)>0)
			{
				ago=(ago==string.Empty ? "" : ", ")+AgoMonths(oldDateThis.AddMonths(latest.Month), latestDateOrNow);
			}
			if(timespan.Hours>0)
			{
				ago=(ago==string.Empty ? "" : ", ")+AgoMonths(oldDateThis.AddDays(latest.Day), latestDateOrNow);
			}
			if(timespan.Minutes>0)
			{
				ago=(ago==string.Empty ? "" : ", ")+AgoHours(oldDateThis, latestDateOrNow);
			}
			return ago==string.Empty ? "A moment ago" : ago.Replace(" ago", "")+" ago";
		}

		public static string AgoYearMonths(this DateTime oldDateThis, DateTime? latestDateOrNow = null)
		{
			DateTime latest = latestDateOrNow==null ? DateTime.Now : latestDateOrNow.Value;
			var timespan = latest-oldDateThis;

			string ago = string.Empty;
			if(timespan.Days>365)
			{
				ago+=AgoYears(oldDateThis, latestDateOrNow);
			}
			if((timespan.Days%365)>30)
			{
				ago=(ago==string.Empty ? "" : ", ")+AgoMonths(oldDateThis.AddYears(latest.Year), latestDateOrNow);
			}

			return ago==string.Empty ? "A moment ago" : ago.Replace(" ago", "")+" ago";
		}

		public static string AgoYears(this DateTime oldDateThis, DateTime? latestDateOrNow = null)
		{
			DateTime latest = latestDateOrNow==null ? DateTime.Now : latestDateOrNow.Value;
			var timespan = latest-oldDateThis;

			return string.Format("{0} year{1} ago", timespan.Days/365, (timespan.Days/365)>1 ? "s" : "");
		}

		public static string AgoMonths(this DateTime oldDateThis, DateTime? latestDateOrNow = null)
		{
			DateTime latest = latestDateOrNow==null ? DateTime.Now : latestDateOrNow.Value;
			var timespan = latest-oldDateThis;

			return string.Format("{0} month{1} ago", timespan.Days/30, (timespan.Days/30)>1 ? "s" : "");
		}

		public static string AgoDays(this DateTime oldDateThis, DateTime? latestDateOrNow = null)
		{
			DateTime latest = latestDateOrNow==null ? DateTime.Now : latestDateOrNow.Value;
			var timespan = latest-oldDateThis;

			return string.Format("{0} day{1} ago", timespan.Days, timespan.Days>1 ? "s" : "");
		}

		public static string AgoHours(this DateTime oldDateThis, DateTime? latestDateOrNow = null)
		{
			DateTime latest = latestDateOrNow==null ? DateTime.Now : latestDateOrNow.Value;
			var timespan = latest-oldDateThis;

			return string.Format("{0} hour{1} ago", timespan.Hours, timespan.Hours>1 ? "s" : "");
		}

		public static string AgoMinutes(this DateTime oldDateThis, DateTime? latestDateOrNow = null)
		{
			DateTime latest = latestDateOrNow==null ? DateTime.Now : latestDateOrNow.Value;
			var timespan = latest-oldDateThis;

			return string.Format("{0} minute{1} ago", timespan.Minutes, timespan.Minutes>1 ? "s" : "");
		}
	}
}