using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static string GetLeftOfLast(this string @this, string leftOf)
        {
            return @this.GetLeftOfLast(leftOf, StringComparison.CurrentCulture);
        }

        public static string GetLeftOfLast(this string @this, string leftOf, StringComparison comparisonType = StringComparison.CurrentCulture)
        {
            if (@this.IsNullOrEmpty() || leftOf.IsNullOrEmpty() || @this.Length <= leftOf.Length)
                return @this;
             
            int lastValuePosition = @this.LastIndexOf(leftOf, comparisonType);
  
            return lastValuePosition > 0 ? @this.Substring(0, lastValuePosition) : @this;
        }
    }
}
