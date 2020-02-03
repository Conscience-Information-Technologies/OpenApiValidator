using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace System
{
	public static partial class Extensions
	{
		public static bool ObjectEquals<T>(this T @this)
		{
			return object.Equals(@this, default(T));
		}
		public static bool ObjectNotEquals<T>(this T @this)
		{
			return !@this.ObjectEquals();
		}
	}
}
