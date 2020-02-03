using System;

namespace System
{

	public static partial class Extensions
	{
		public static Boolean IsReferenceEquals<T>(this T @this, T that) where T : class
		{
			return Object.ReferenceEquals(@this, that);
		}
	}
}