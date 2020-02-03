using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsNotEmpty(this Guid @this)
		{
			return @this!=Guid.Empty;
		}

		public static bool IsNotEmpty(this Guid? @this)
		{
			return !@this.IsEmpty();
		}

	}
}