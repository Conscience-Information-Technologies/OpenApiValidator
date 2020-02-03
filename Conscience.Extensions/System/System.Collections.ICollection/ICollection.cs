using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace System.Collections.Generic
{
	public static partial class Extensions
	{
		public static bool IsNullOrEmpty<T>(this ICollection<T> @this)
		{
			return @this==null||@this.Count==0;
		}

		public static bool IsNotNullOrEmpty<T>(this ICollection<T> @this)
		{
			return !@this.IsNullOrEmpty();
		}
	}
}