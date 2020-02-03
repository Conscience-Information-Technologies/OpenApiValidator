using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static int GetDiffMonth(this DateTime @this, DateTime dateTime)
		{
			var l = @this<dateTime ? @this : dateTime;
			var r = @this>=dateTime ? @this : dateTime;
			return (l.Day==r.Day ? 0 : l.Day>r.Day ? 0 : 1)
			+(l.Month==r.Month ? 0 : r.Month-l.Month)
			+(l.Year==r.Year ? 0 : (r.Year-l.Year)*12);
		}
	}
}