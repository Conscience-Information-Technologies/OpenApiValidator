﻿using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static string IfNullThenEmpty(this string @this)
        {
            return @this ?? "";
        }
    }
}
