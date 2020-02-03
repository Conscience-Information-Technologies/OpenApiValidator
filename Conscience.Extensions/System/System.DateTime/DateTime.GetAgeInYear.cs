using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		static public int GetAgeInYear(this DateTime @this)
		{
			if(DateTime.Today.Month<@this.Month||
			    DateTime.Today.Month==@this.Month&&
			    DateTime.Today.Day<@this.Day)
			{
				return DateTime.Today.Year-@this.Year-1;
			}

			return DateTime.Today.Year-@this.Year;

			//int age = DateTime.Now.Year - @this.Year;
			//if (DateTime.Now.DayOfYear < @this.DayOfYear)
			//    age = age - 1;

			//return age;
		}
	}
}