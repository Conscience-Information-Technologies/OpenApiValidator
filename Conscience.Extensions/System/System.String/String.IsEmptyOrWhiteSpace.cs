using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static bool IsEmptyOrWhiteSpace(this string @this)
        {
            return @this.GetLength() == 0;
        }
    }
}
