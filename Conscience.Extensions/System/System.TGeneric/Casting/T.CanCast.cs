using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool CanCast<T>(this object @this)
		{
			Type type = @this.GetType();
			return type.IsAssignableFrom(typeof(T));
		}

		public static bool CanCast(this object @this, Type targetType)
		{
			Type type = @this.GetType();
			return type.IsAssignableFrom(targetType);
		}
	}
}