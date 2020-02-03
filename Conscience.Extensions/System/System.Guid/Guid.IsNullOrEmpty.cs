using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsNullOrEmpty(this Guid? @this)
		{
			return @this==null||@this.HasValue==false||@this.Value==Guid.Empty;
		}
	}
}