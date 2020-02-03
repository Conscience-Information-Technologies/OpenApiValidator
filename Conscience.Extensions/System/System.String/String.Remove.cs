using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace System
{
	public static partial class Extensions
	{
		public static string Remove(this string @this, string toRemove)
		{
			return @this.Replace(toRemove, string.Empty);
		}

		public static string RemoveIgnoreCase(this string @this, string toRemove)
		{
			return Regex.Replace(@this, Regex.Escape(toRemove), string.Empty, RegexOptions.IgnoreCase);
		}
	}
}
