using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static string Upper(this string @this)
		{
			return @this.Capitalize();
		}
	}
}