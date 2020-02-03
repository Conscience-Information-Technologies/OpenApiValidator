using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsNullOrEmpty<T>(this T[] @this)
		{
			return @this==null||@this.Length==0;
		}
	}
}