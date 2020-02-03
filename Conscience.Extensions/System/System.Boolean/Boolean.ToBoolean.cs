using System;

namespace System
{
	public static partial class Extensions
	{
		public static bool ToBoolean(this string @this)
		{
			if(string.IsNullOrEmpty(@this)||string.IsNullOrEmpty(@this))
				return false;

			switch(@this.ToLower().Trim())
			{
				case "true":
				case "t":
				case "yes":
				case "y":
				case "1":
				case "11":
				return true;
				case "false":
				case "f":
				case "no":
				case "n":
				case "0":
				case "00":
				return false;
				default:
				return false;
			}
		}
	}
}