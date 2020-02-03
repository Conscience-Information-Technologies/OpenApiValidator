using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsDefault<T>(this T @this)
		{
			return @this.Equals(default(T));
		}

		public static bool IsNotDefault<T>(this T @this)
		{
			return !@this.Equals(default(T));
		}

		//public static bool IsDefault<T>(this T value) where T : struct
		//{
		//	bool isDefault = value.Equals(default(T));
		//	return isDefault;
		//}
	}
}
