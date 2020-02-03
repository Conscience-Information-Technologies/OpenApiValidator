using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsDateEqual(this DateTime date, DateTime dateToCompare)
		{
			return (date.Date==dateToCompare.Date);
		}
	}
}