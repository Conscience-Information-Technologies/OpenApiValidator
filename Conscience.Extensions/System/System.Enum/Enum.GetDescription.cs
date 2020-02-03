using System;
using System.ComponentModel;
using System.Linq;

namespace System
{
	public static partial class Extensions
	{
		public static string GetDescription(this Enum @this)
		{
			var attr = @this.GetType().GetField(@this.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();

			if(attr==null||!(attr is DescriptionAttribute))
				return "";

			return (attr as DescriptionAttribute).Description;
		}
	}
}