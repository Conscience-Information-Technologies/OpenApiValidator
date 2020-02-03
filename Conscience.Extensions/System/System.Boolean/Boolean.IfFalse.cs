using System;

namespace System
{
	public static partial class Extensions
	{
		public static void IfFalse(this bool @this, Action action)
		{
			if(@this==false)
				action();
		}
	}
}