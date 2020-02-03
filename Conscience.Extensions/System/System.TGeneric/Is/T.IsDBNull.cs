using System;

namespace System
{
	public static partial class Extensions
	{
		public static Boolean IsDBNull<T>(this T @this) where T : class
		{
			return Convert.IsDBNull(@this);
		}
	}
}