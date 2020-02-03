using System;

namespace System
{
	public static partial class Extensions
	{
		public static void IfTrue(this bool @this, Action action)
		{
			if(@this==true)
				action();
		}
	}
}