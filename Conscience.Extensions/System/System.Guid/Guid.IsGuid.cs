using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace System
{
	public static partial class Extensions
	{
		static public bool IsGuid(this string @this)
		{
			Regex format = new Regex(
			    "^[A-Fa-f0-9]{32}$|"+
			    "^({|\\()?[A-Fa-f0-9]{8}-([A-Fa-f0-9]{4}-){3}[A-Fa-f0-9]{12}(}|\\))?$|"+
			    "^({)?[0xA-Fa-f0-9]{3,10}(, {0,1}[0xA-Fa-f0-9]{3,6}){2}, {0,1}({)([0xA-Fa-f0-9]{3,4}, {0,1}){7}[0xA-Fa-f0-9]{3,4}(}})$");
			Match match = format.Match(@this);
			return match.Success;
		}
	}
}