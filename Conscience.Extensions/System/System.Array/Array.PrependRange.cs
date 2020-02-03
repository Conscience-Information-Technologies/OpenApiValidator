using System;
using System.Collections.Generic;
using System.Text;


namespace System
{
	public static partial class Extensions
	{
		public static T[] PrependRange<T>(this T[] @this, params T[] items)
		{
			if(@this==null)
				@this=new T[] { };

			T[] result = new T[@this.Length+items.Length];
			items.CopyTo(result, 0);

			@this.CopyTo(result, @this.Length);
			return result;
		}
	}
}
