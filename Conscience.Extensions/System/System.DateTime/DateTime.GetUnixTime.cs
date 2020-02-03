using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		private static readonly DateTime UnixRefereceDataTime = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).ToUniversalTime();

		public static long GetUnixTime(this DateTime dateTime)
		{
			return (long)(dateTime.ToUniversalTime()-UnixRefereceDataTime).TotalSeconds;
		}
	}
}
