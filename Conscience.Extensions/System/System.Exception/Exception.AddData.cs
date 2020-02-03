using System;

namespace System
{
	public static partial class Extensions
	{
		public static Exception AddData(this Exception @this, string key, object value)
		{
			@this.Data.Add(key, value);
			return @this;
		}
	}
}