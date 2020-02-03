using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static bool IsNotStartsWith(this string @this, string that)
        {
            return !@this.StartsWith(that);
        }
    }
}
