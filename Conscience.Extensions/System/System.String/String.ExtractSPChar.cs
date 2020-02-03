using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace System
{
	public static partial class Extensions
	{
		public static string ExtractSPChar(this string originalString)
		{
			string specialCharacters = string.Empty;

			foreach(var item in originalString.Where(x => !char.IsLetterOrDigit(x)).GroupBy(x => x))
				specialCharacters=specialCharacters+item.Key;

			return specialCharacters;
		}
	}
}