using System;

namespace System
{
	public static partial class Extensions
	{
		public static Delegate RemoveAll(this Delegate source, Delegate value)
		{
			return Delegate.RemoveAll(source, value);
		}
	}
}