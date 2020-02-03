using System;

namespace System
{
	public static partial class Extensions
	{
		public static Int64 ToInt64(this Decimal d)
		{
			return Decimal.ToInt64(d);
		}
	}
}