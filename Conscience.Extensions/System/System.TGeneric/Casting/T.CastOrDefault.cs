using System;

namespace System
{
	public static partial class Extensions
	{
		public static T CastOrDefault<T>(this object @this)
		{
			Type type = @this.GetType();
			if(type.IsAssignableFrom(typeof(T)))
				return (T)@this;

			return default(T);
		}

		public static T CastOrDefault<T>(this object @this, T defaultValue)
		{
			Type type = @this.GetType();
			if(type.IsAssignableFrom(typeof(T)))
				return (T)@this;
			return defaultValue;
		}

		public static T CastOrDefault<T>(this object @this, Func<T> defaultValueFactory)
		{
			Type type = @this.GetType();
			if(type.IsAssignableFrom(typeof(T)))
				return (T)@this;
			return defaultValueFactory();
		}

		public static T CastOrDefault<T>(this object @this, Func<object, T> defaultValueFactory)
		{
			Type type = @this.GetType();
			if(type.IsAssignableFrom(typeof(T)))
				return (T)@this;
			return defaultValueFactory(@this);
		}
	}
}