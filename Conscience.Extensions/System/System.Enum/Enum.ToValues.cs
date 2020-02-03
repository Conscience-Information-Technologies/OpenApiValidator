using System;
using System.Collections.Generic;
using System.Linq;

namespace System
{
	public static partial class Extensions
	{
		public static IList<int> ToValues<T>(this T @this) where T : IConvertible
		{
			Type e = typeof(T);
			return Enum.GetValues(e).Cast<int>().ToList();
		}
	}
}