using System;

namespace System
{
	public static partial class Extensions
	{
		public static Int16 ToInt16(this Decimal value)
		{
			return Decimal.ToInt16(value);
		}
	}
}