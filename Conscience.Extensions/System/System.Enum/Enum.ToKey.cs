using System;
using System.Collections.Generic;
using System.Linq;

namespace System
{
	public static partial class Extensions
	{
		public static string ToKey<T>(this T @this) where T : IConvertible
		{
			return Convert.ToString(@this);
		}
	}
}