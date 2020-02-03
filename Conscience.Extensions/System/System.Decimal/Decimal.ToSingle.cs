using System;

namespace System
{
	public static partial class Extensions
	{
		public static Single ToSingle(this Decimal d)
		{
			return Decimal.ToSingle(d);
		}
	}
}