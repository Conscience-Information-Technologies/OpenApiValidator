using System;
using System.Globalization;
using System.Reflection;

namespace System
{
	public static partial class Extensions
	{
		public static Object CreateInstance<T>(this Type type, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture)
		{
			return Activator.CreateInstance(type, bindingAttr, binder, args, culture);
		}

		public static Object CreateInstance(this Type type, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes)
		{
			return Activator.CreateInstance(type, bindingAttr, binder, args, culture, activationAttributes);
		}

		public static Object CreateInstance(this Type type, Object[] args)
		{
			return Activator.CreateInstance(type, args);
		}

		public static Object CreateInstance(this Type type, Object[] args, Object[] activationAttributes)
		{
			return Activator.CreateInstance(type, args, activationAttributes);
		}

		public static Object CreateInstance(this Type type)
		{
			return Activator.CreateInstance(type);
		}

		public static Object CreateInstance(this Type type, Boolean nonPublic)
		{
			return Activator.CreateInstance(type, nonPublic);
		}
	}
}