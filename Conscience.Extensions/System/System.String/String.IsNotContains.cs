using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static bool IsNotContains(this string @this, string that)
        {
            return !@this.Contains(that);
        }
    }
}
