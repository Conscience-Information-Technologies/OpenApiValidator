using System;

namespace System
{
	public static partial class Extensions
	{
		public static string ToStringSafe<T>(this T @this)
		{
			return @this==null ? "" : @this.ToString();
		}
	}
}
