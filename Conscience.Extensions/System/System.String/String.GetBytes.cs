using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static sbyte[] GetBytes(this string @this)
		{
			return GetSBytesForEncoding(System.Text.Encoding.UTF8, @this);
		}
		public static sbyte[] GetBytes(this string @this, System.Text.Encoding encoding)
		{
			return GetSBytesForEncoding(encoding, @this);
		}
		public static sbyte[] GetBytes(this string @this, string encoding)
		{
			return GetSBytesForEncoding(System.Text.Encoding.GetEncoding(encoding), @this);
		}
		private static sbyte[] GetSBytesForEncoding(System.Text.Encoding encoding, string s)
		{
			sbyte[] sbytes = new sbyte[encoding.GetByteCount(s)];
			encoding.GetBytes(s, 0, s.Length, (byte[])(object)sbytes, 0);
			return sbytes;
		}
	}
}
