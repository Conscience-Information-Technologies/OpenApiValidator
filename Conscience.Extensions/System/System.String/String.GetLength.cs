using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static int GetLength(this string @this)
        {
            return @this.IsNullOrEmpty() ? 0 : @this.Trim().Length;
        }
    }
}
