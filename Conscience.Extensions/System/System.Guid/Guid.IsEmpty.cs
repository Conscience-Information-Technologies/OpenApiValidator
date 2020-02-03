using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsEmpty(this Guid @this)
		{
			return @this==Guid.Empty;
		}

		public static bool IsEmpty(this Guid? @this)
		{
			return @this==Guid.Empty;
		}
	}
}