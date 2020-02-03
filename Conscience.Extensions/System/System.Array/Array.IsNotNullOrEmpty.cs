using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsNotNullOrEmpty<T>(this T[] @this)
		{
			return !@this.IsNullOrEmpty();
		}
	}
}