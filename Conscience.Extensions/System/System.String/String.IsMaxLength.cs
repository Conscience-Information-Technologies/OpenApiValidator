using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static bool IsMaxLength(this string @this, int maxLength)
        {
            return @this != null && @this.Length >= maxLength;
        }

    }
}
