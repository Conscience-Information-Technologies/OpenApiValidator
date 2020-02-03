using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace System
{
public static partial class Extensions
    {
        public static int ContainsCount(this string val, string stringToMatch)
        {
            return Regex.Matches(val, stringToMatch, RegexOptions.IgnoreCase).Count;
        }
    }
}
