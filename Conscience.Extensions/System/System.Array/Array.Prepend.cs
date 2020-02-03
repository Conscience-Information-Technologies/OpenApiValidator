using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static T[] Prepend<T>(this T[] @this, T item)
		{
			return @this.PrependRange(item);
		}
	}
}
