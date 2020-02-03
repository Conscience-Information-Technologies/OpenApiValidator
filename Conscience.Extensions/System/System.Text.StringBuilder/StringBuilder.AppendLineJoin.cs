using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static StringBuilder AppendLineJoin<T>(this StringBuilder @this, string separator, IEnumerable<T> values)
		{
			@this.AppendLine(string.Join(separator, values));

			return @this;
		}

		public static StringBuilder AppendLineJoin(this StringBuilder @this, string separator, params object[] values)
		{
			@this.AppendLine(string.Join(separator, values));

			return @this;
		}
	}
}