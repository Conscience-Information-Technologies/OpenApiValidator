using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static string GetNullIfEmpty(this string @this)
        {
            if (@this.GetLength() == 0)
                return null;

            return @this;
        }
    }
}
