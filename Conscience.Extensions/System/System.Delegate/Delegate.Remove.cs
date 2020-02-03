using System;

namespace System
{
	public static partial class Extensions
	{
		public static Delegate Remove(this Delegate source, Delegate value)
		{
			return Delegate.Remove(source, value);
		}
	}
}