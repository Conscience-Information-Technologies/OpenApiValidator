using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsContains(this string @this, string compare)
		{
			return @this.IndexOf(compare)>=0;
		}

		public static bool IsContains(this string @this, string compare, StringComparison comp = StringComparison.CurrentCulture)
		{
			return @this.IndexOf(compare, comp)>=0;
		}
	}
}
