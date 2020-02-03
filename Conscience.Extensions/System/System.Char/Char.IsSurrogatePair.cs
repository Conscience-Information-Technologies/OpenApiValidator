using System;

namespace System
{
	public static partial class Extensions
	{
		public static Boolean IsSurrogatePair(this Char highSurrogate, Char lowSurrogate)
		{
			return Char.IsSurrogatePair(highSurrogate, lowSurrogate);
		}
	}
}