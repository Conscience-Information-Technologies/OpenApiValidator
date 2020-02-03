using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace System
{
public static partial class Extensions
    {
        public static string ExtractAlpha(this string originalString)
        {
            return Regex.Replace(originalString, @"[^a-zA-Z]", string.Empty);
        }
    }
}
