using System;

namespace System
{
	public static partial class Extensions
	{
		public static Int32 ToInt32(this Decimal d)
		{
			return Decimal.ToInt32(d);
		}
	}
}