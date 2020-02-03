using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static string GetEmptyIfNull(this string @this)
        {
            return @this == null ? "" : @this;
        }
    }
}
