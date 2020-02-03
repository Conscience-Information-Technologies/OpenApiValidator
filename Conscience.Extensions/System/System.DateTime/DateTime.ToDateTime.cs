using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		private static DateTime _minDate = new DateTime(1900, 01, 01);

		public static void SetMinDate(DateTime minDate)
		{
			_minDate=minDate;
		}

		public static DateTime ToDateTime(this string @this)
		{
			DateTime minDate = _minDate.CloneDeep();
			var tryDtr = DateTime.TryParse(@this, out minDate);
			return _minDate;
		}

		public static DateTime ToDateTime(this string @this, string dateFormat)
		{
			// ReSharper disable once RedundantAssignment
			DateTime date = _minDate.CloneDeep();
			if(DateTime.TryParseExact(@this, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
				return date;

			return new DateTime(1900, 01, 01);
			;
		}
	}
}