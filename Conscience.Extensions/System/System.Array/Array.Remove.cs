using System;

namespace System
{
	public static partial class Extensions
	{
		public static T[] Remove<T>(this T[] @this, T item)
		{
			int numIdx = System.Array.IndexOf(@this, item);
			if(numIdx==-1)
				return @this;
			@this=@this.RemoveAt(numIdx);

			return @this;
		}

		public static T[] Remove<T>(this T[] @this, T[] items)
		{
			foreach(var item in items)
			{
				int numIdx = System.Array.IndexOf(@this, item);
				if(numIdx>0)
					@this=@this.RemoveAt(numIdx);
			}

			return @this;
		}
	}
}