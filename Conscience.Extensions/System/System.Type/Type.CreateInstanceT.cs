using System;
using System.Globalization;
using System.Reflection;

namespace System
{
	public static partial class Extensions
	{
		//public static T CreateInstance<T>(this Type @this, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture)
		//{
		//	return (T)Activator.CreateInstance(@this, bindingAttr, binder, args, culture);
		//}

		public static T CreateInstance<T>(this Type @this, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes)
		{
			return (T)Activator.CreateInstance(@this, bindingAttr, binder, args, culture, activationAttributes);
		}

		public static T CreateInstance<T>(this Type @this, Object[] args)
		{
			return (T)Activator.CreateInstance(@this, args);
		}

		public static T CreateInstance<T>(this Type @this, Object[] args, Object[] activationAttributes)
		{
			return (T)Activator.CreateInstance(@this, args, activationAttributes);
		}

		public static T CreateInstance<T>(this Type @this)
		{
			return (T)Activator.CreateInstance(@this);
		}

		public static T CreateInstance<T>(this Type @this, Boolean nonPublic)
		{
			return (T)Activator.CreateInstance(@this, nonPublic);
		}
	}
}