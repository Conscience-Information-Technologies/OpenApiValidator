using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static bool IsEndsWith(this string @this, string that)
        {
            return @this.EndsWith(that);
        }
    }
}
