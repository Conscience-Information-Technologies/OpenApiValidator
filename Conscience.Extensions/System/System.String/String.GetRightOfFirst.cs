using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static string GetRightOfFirst(this string @this, string rightOf)
        {
            return @this.GetRightOfFirst(rightOf, StringComparison.CurrentCulture);
        }

        public static string GetRightOfFirst(this string @this, string rightOf, StringComparison comparisonType = StringComparison.CurrentCulture)
        {
            if (@this.IsNullOrEmpty() || rightOf.IsNullOrEmpty() || @this.Length <= rightOf.Length)
                return @this;

            int lastValuePosition = @this.IndexOf(rightOf, comparisonType);

            return lastValuePosition > 0 ? @this.Substring(lastValuePosition + rightOf.Length) : @this;
        }
    }
}
