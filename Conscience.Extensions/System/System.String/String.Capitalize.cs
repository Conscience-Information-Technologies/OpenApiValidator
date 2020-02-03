using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static string Capitalize(this string @this)
        {
            if (@this.GetLength() == 0)
                return @this;

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(@this);
        }
    }
}
