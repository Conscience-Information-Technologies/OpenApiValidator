using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		private static char[] replacement = { 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'c', 'c', 'e', 'e', 'e', 'e', 'i', 'i', 'i', 'i', 'o', 'o', 'o', 'o', 'o', 'o', 'o',
					     'u', 'u', 'u', 'u', 't', 'y', 'y', 's', 'b', 'd', 'n', 'm', ' ', ' ', ' ', ' ', ' ' };
		private static char[] accents = { 'à', 'â', 'ä', 'æ', 'ã', 'á', 'å', 'ç', '©', 'é', 'è', 'ê', 'ë', 'î', 'ï', 'í', 'ì', 'ô', 'õ', 'œ', 'ò', 'ó', 'ö', 'ø',
					 'ù', 'ú', 'û', 'ü', 'þ', 'ý', 'ÿ', '§', 'ß', 'ð', 'ñ', 'µ', '€', '£', '¥', '+', '•' };

		public static string RemoveDiacritics(this string @this)
		{
			if(@this.IsNullOrEmpty())
				return @this;

			StringBuilder returnString = new StringBuilder();

			if(@this.ToLower().IndexOfAny(accents)>-1)
			{
				returnString.Length=0;
				returnString.Append(@this);
				for(int i = 0; i<accents.Length; i++)
				{
					returnString.Replace(accents[i], replacement[i]);
					returnString.Replace(accents[i].ToString(), replacement[i].ToString());
					returnString.Replace(accents[i].ToString().ToUpper(), replacement[i].ToString().ToUpper());
				}

				return returnString.ToString();
			}
			else
				return @this;
		}
	}
}