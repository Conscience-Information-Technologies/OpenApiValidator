using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static T[] RandomNultiple<T>(this T[] @this, int count)
		{
			if(@this==null)
				@this=new T[] { };
			T[] that = new T[] { };
			for(int i = 0; i<count; i++)
			{
				var random = new Random();
				that.Add(@this[random.Next(@this.Length)]);
			}

			return that;
		}
	}
}