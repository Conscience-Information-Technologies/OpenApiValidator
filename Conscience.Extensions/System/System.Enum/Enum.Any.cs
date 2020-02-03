using System;
using System.Linq;

namespace System
{
	public static partial class Extensions
	{
		public static bool Any<T>(this T @this, int that) where T : IConvertible
		{
			var _enum = typeof(T);
			return _enum.ToListOf<T>(true, 0).Any(v => v.Value==that);
		}

		public static bool Any<T>(this Type @this, int that) where T : IConvertible
		{
			return @this.ToListOf<T>(true, 0).Any(v => v.Value==that);
		}

		public static bool Any<T>(this T @this, string that) where T : IConvertible
		{
			var _enum = typeof(T);
			return _enum.ToListOf<T>(true, 0).Any(v => v.Key==that);
		}

		public static bool Any<T>(this Type @this, string that) where T : IConvertible
		{
			return @this.ToListOf<T>(true, 0).Any(v => v.Key==that);
		}
	}
}
