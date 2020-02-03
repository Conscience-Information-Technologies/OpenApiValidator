using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool In(this DateTime @this, params DateTime[] values)
		{
			return Array.IndexOf(values, @this)!=-1;
		}
	}
}