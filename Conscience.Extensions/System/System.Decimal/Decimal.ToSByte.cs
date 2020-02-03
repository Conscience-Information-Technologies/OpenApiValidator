using System;

namespace System
{
	public static partial class Extensions
	{
		public static SByte ToSByte(this Decimal value)
		{
			return Decimal.ToSByte(value);
		}
	}
}