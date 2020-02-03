using System;
using System.Collections.Generic;
using System.Linq;

namespace System
{
	public static partial class Extensions
	{
		public static int ToValue<T>(this T @this) where T : IConvertible
		{
			return Convert.ToInt32(@this);
		}
	}
}