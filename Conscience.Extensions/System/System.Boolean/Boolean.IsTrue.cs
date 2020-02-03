using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsTrue(this bool @this)
		{
			return @this==true;
		}
	}
}