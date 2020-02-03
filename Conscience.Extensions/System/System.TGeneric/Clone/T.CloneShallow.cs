using System;
using System.Reflection;

namespace System
{
	public static partial class Extensions
	{
		public static T CloneShallow<T>(this T @this)
		{
			if(Object.ReferenceEquals(@this, null))
			{
				return default(T);
			}

			MethodInfo method = @this.GetType().GetMethod("MemberwiseClone", BindingFlags.NonPublic|BindingFlags.Instance);
			return (T)method.Invoke(@this, null);
		}
	}
}