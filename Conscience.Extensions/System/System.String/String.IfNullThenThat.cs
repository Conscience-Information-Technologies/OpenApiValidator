﻿using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static string IfNullThenThat(this string @this, string that)
        {
            return @this ?? that;
        }

    }
}
