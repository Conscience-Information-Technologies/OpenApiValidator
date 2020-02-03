using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static string GetRight(this string @this, int length)
        {
            if (@this.IsNullOrEmpty() || length <= 0 || @this.Length <= length)
                return @this;

            int startIndex = @this.Length - length;
            string result = @this.Substring(startIndex);

            return result;
        }
    }
}
