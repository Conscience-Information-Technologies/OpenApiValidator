using System;

namespace System
{
	public static partial class Extensions
	{
		public static T[] RemoveIf<T>(this T[] @this, Predicate<T> match)
		{
			foreach(var item in @this)
			{
				if(match(item))
				{
					int numIdx = System.Array.IndexOf(@this, item);
					if(numIdx>0)
						@this=@this.RemoveAt(numIdx);
				}
			}

			return @this;
		}
	}
}