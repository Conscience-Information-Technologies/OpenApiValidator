using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool In(this DateTimeOffset @this, params DateTimeOffset[] values)
		{
			return Array.IndexOf(values, @this)!=-1;
		}
	}
}