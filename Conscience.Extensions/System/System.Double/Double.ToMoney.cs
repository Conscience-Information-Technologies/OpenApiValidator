using System;

namespace System
{
	public static partial class Extensions
	{
		public static Double ToMoney(this Double @this)
		{
			return Math.Round(@this, 2);
		}
	}
}