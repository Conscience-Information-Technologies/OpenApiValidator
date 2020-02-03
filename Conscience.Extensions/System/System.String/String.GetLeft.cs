using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static string GetLeft(this string @this, int length)
        {
            if (@this.GetLength() == 0 || @this.Length > length || length <= 0)
                return @this;

            return @this.Substring(0, length);
        }
    }
}
