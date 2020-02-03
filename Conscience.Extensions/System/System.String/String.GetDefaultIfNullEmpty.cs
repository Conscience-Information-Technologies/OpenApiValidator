using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static string GetDefaultIfNullEmpty(this string @this, string @default)
        {
            return @this.GetLength() == 0 ? @default : @this;
        }
    }
}
