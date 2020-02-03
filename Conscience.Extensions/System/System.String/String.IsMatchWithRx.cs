using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace System
{
public static partial class Extensions
    {
        public static bool IsMatchWithRx(this string @this, string pattern, RegexOptions options = RegexOptions.None)
        {
            return Regex.IsMatch(@this, pattern, options);
        }
    }
}
