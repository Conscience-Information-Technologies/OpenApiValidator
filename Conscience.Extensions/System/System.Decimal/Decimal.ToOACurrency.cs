using System;

namespace System
{
	public static partial class Extensions
	{
		public static Int64 ToOACurrency(this Decimal value)
		{
			return Decimal.ToOACurrency(value);
		}
	}
}