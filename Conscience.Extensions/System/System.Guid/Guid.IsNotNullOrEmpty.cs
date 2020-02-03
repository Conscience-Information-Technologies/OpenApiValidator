using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static bool IsNotNullOrEmpty(this Guid? @this)
		{
			return !@this.IsNullOrEmpty();
		}
	}
}