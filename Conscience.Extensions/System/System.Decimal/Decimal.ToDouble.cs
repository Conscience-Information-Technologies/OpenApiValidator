using System;

namespace System
{
	public static partial class Extensions
	{
		public static Double ToDouble(this Decimal d)
		{
			return Decimal.ToDouble(d);
		}
	}
}