using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		private static readonly Func<Type, bool> SimpleTypesPredicate = t =>
					      t==typeof(byte)||
					      t==typeof(sbyte)||
					      t==typeof(int)||
					      t==typeof(uint)||
					      t==typeof(short)||
					      t==typeof(ushort)||
					      t==typeof(long)||
					      t==typeof(ulong)||
					      t==typeof(float)||
					      t==typeof(double)||
					      t==typeof(decimal)||
					      t==typeof(bool)||
					      t==typeof(char)||
					      t==typeof(DateTime)||
					      t==typeof(string)||
					      t.GetTypeInfo().BaseType==typeof(Enum);

		public static bool IsSimpleType<T>(this T type) where T : Type
		{
			var underlyingType = Nullable.GetUnderlyingType(type);
			return SimpleTypesPredicate(underlyingType??type);
		}

		public static bool IsSimpleType(Type type)
		{
			return type.IsSimpleType();
		}
	}
}