using System;

namespace System
{
	public static partial class Extensions
	{
		public static Byte ToByte(this Decimal value)
		{
			return Decimal.ToByte(value);
		}
	}
}