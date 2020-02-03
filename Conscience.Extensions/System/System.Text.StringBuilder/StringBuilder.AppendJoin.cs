using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static StringBuilder AppendJoin<T>(this StringBuilder @this, string separator, IEnumerable<T> values)
		{
			@this.Append(string.Join(separator, values));

			return @this;
		}

		public static StringBuilder AppendJoin<T>(this StringBuilder @this, string separator, params T[] values)
		{
			@this.Append(string.Join(separator, values));

			return @this;
		}
	}
}