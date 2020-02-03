using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsNotNull(this string @this)
		{
			return @this!=null;
		}
	}
}
