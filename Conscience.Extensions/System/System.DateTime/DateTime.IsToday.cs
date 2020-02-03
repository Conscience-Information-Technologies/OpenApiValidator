using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsToday(this DateTime @this)
		{
			return @this.Date==DateTime.Today;
		}
	}
}