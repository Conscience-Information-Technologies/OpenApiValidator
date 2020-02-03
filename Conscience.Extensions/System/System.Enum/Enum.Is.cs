using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool Is<T>(this T @this, T that) where T : IConvertible
		{
			return Convert.ToInt32(@this)==Convert.ToInt32(that);
		}

		public static bool IsNot<T>(this T @this, T that) where T : IConvertible
		{
			return !@this.Is(that);
		}

		public static bool Is<T>(this T @this, int other) where T : IConvertible
		{
			return Convert.ToInt32(@this)==other;
		}

		public static bool IsNot<T>(this T @this, int other) where T : IConvertible
		{
			return !@this.Is(other);
		}

		public static bool Is<T>(this T @this, string other) where T : IConvertible
		{
			return Convert.ToString(@this)==other;
		}

		public static bool IsNot<T>(this T @this, string other) where T : IConvertible
		{
			return !@this.Is(other);
		}
	}
}