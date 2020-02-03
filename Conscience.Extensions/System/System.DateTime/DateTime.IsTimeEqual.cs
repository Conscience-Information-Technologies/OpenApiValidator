using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsTimeEqual(this DateTime time, DateTime timeToCompare)
		{
			return (time.TimeOfDay==timeToCompare.TimeOfDay);
		}
	}
}