using System;
using System.Collections.Generic;
using System.Linq;

namespace ProsPano.Extensions
{
	namespace System
	{
		public static partial class Extensions
		{
			public static T ToEnum<T>(this T @this, string from) where T : IConvertible
			{
				return (T)Enum.Parse(typeof(T), from);
			}

			public static T ToEnum<T>(this T @this, int from) where T : IConvertible
			{
				var enumType = typeof(T);
				return (T)Enum.Parse(enumType, Enum.GetName(enumType, from));
			}

			public static T ToEnum<T>(this int @this) where T : IConvertible
			{
				var enumType = typeof(T);
				return (T)Enum.Parse(enumType, Enum.GetName(enumType, @this));
			}

			public static T? ToEnum<T>(this string @this, T defaultValue) where T : struct, IConvertible
			{
				if(typeof(T).IsEnum&&!string.IsNullOrWhiteSpace(@this))
				{
					if(@this.Length<10&&@this.All(c => char.IsDigit(c)))
					{
						if(Enum.IsDefined(typeof(T), int.Parse(@this)))
							return int.Parse(@this).ToEnum<T>();
					}
					else
					{
						bool success = Enum.TryParse(@this, out T ret);
						if(success)
							return ret;
					}
				}
				return defaultValue;
			}

			public static T? ToEnum<T>(this string @this, T defaultValue, bool ignoreCase = true) where T : struct, IConvertible
			{
				if(typeof(T).IsEnum&&!string.IsNullOrWhiteSpace(@this))
				{
					if(@this.Length<10&&@this.All(c => char.IsDigit(c)))
					{
						if(Enum.IsDefined(typeof(T), int.Parse(@this)))
							return int.Parse(@this).ToEnum<T>();
					}
					else
					{
						bool success = Enum.TryParse(@this, ignoreCase, out T ret);
						if(success)
							return ret;
					}
				}
				return defaultValue;
			}
		}
	}
}