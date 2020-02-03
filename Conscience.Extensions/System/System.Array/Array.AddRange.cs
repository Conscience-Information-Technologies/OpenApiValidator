using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static T[] AddRange<T>(this T[] @this, params T[] items)
		{
			if (@this == null)
				@this = new T[] { };

			for (int i = 0; i < items.Length; i++)
			{
				Array.Resize(ref @this, @this.Length + 1);
				@this[@this.Length - 1] = items[i];
			}

			return @this;
		}
	}
}
