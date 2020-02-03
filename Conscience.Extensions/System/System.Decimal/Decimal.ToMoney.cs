using System;

namespace System
{
	public static partial class Extensions
	{
		public static Decimal ToMoney(this Decimal @this)
		{
			return Math.Round(@this, 2);
		}
	}
}