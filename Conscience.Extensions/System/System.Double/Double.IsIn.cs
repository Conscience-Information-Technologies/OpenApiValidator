using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsIn(this Double @this, params Double[] values)
		{
			return Array.IndexOf(values, @this)!=-1;
		}
	}
}