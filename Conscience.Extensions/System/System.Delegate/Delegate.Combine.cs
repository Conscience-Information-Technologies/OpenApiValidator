using System;

namespace System
{
	public static partial class Extensions
	{
		public static Delegate Combine(this Delegate a, Delegate b)
		{
			return Delegate.Combine(a, b);
		}
	}
}