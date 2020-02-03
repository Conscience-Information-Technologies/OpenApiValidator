using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsNotNull<T>(this T @this) where T : class
		{
			return @this != null;
		}
	}
}
