using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static int GetDiffYear(this DateTime @this, DateTime dateTime)
		{
			var l = @this<dateTime ? @this : dateTime;
			var r = @this>=dateTime ? @this : dateTime;
			return l.Year==r.Year ? 0 : (r.Year-l.Year);
		}
	}
}