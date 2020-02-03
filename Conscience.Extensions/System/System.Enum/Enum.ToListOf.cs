using System;
using System.Collections.Generic;
using System.Linq;

namespace System
{
	public static partial class Extensions
	{
		public static List<KeyValuePair<string, int>> ToListOf<T>(this Type enumType, bool withOutDefault = false, int EnumDefaultValue = 0) where T : IConvertible
		{
			var ty = typeof(T);

			if(ty.IsEnum)
			{
				var query = Enum.GetValues(ty)
				   .Cast<int>()
				   .Select(e => new KeyValuePair<string, int>(Enum.GetName(ty, e), e));

				if(withOutDefault)
				{
					query=query.Where(e => e.Value!=EnumDefaultValue);
				}

				return query.ToList();
			}

			return null;
		}

		public static List<KeyValuePair<string, int>> ToListOf<T>(this T enumType, bool withOutDefault = false, int EnumDefaultValue = 0) where T : IConvertible
		{
			var ty = typeof(T);

			if(ty.IsEnum)
			{
				var query = Enum.GetValues(ty)
				   .Cast<int>()
				   .Select(e => new KeyValuePair<string, int>(Enum.GetName(ty, e), e));

				if(withOutDefault)
				{
					query=query.Where(e => e.Value!=EnumDefaultValue);
				}

				return query.ToList();
			}

			return null;
		}
	}
}
