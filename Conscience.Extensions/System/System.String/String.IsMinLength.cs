using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static bool IsMinLength(this string @this, int minLength)
        {
            return @this != null && @this.Length >= minLength;
        }

    }
}
