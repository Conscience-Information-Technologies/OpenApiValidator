using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    { 
        public static string GetRightOfLast(this string @this, string rightOf)
        {
            return @this.GetRightOfLast(rightOf, StringComparison.CurrentCulture);
        }

        public static string GetRightOfLast(this string @this, string rightOf, StringComparison comparisonType = StringComparison.CurrentCulture)
        {
            if (@this.IsNullOrEmpty() || rightOf.IsNullOrEmpty() || @this.Length <= rightOf.Length)
                return @this;

            int lastValuePosition = @this.LastIndexOf(rightOf, comparisonType);

            return lastValuePosition > 0 ? @this.Substring(lastValuePosition + rightOf.Length) : @this;
        }
    }
}
