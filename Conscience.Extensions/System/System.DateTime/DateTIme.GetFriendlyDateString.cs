using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static string ToFriendlyDateString(this DateTime @this)
		{
			string day = "";
			if(@this.Date==DateTime.Today)
			{
				day="Today";
			}
			else if(@this.Date==DateTime.Today.AddDays(-1))
			{
				day="Yesterday";
			}
			else if(@this.Date>DateTime.Today.AddDays(-6))
			{
				// *** Show the Day of the week
				day=@this.ToString("dddd").ToString();
			}
			else
			{
				day=@this.ToString("MMMM dd, yyyy");
			}

			//append the time portion to the output
			day+=" @ "+@this.ToString("t").ToLower();
			return day;
		}
	}
}