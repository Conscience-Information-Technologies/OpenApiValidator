using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static string IfNullEmptyThenThat(this string @this, string that)
        {
            return @this.GetLength() == 0 ? that : @this;
        }

    }
}
