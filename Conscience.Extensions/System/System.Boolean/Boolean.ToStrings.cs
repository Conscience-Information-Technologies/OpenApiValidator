using System;

namespace System
{
	public static partial class Extensions
	{
		public enum BooleanToString
		{
			Default = 0,
			True_False = 1,
			T_F = 2,
			Yse_No = 3,
			Y_N = 4,
			Int_1_0 = 5,
			Int_11_00 = 6,
		}

		public static string ToStrings(this bool @this, BooleanToString val = BooleanToString.Default)
		{
			if(@this)
				switch(val)
				{
					case BooleanToString.True_False:
					return "True";
					case BooleanToString.T_F:
					return "T";
					case BooleanToString.Yse_No:
					return "Yes";
					case BooleanToString.Y_N:
					return "Y";
					case BooleanToString.Int_1_0:
					return "1";
					case BooleanToString.Int_11_00:
					return "11";
					default:
					return "1";
				}
			else
				switch(val)
				{
					case BooleanToString.True_False:
					return "False";
					case BooleanToString.T_F:
					return "F";
					case BooleanToString.Yse_No:
					return "No";
					case BooleanToString.Y_N:
					return "N";
					case BooleanToString.Int_1_0:
					return "0";
					case BooleanToString.Int_11_00:
					return "00";
					default:
					return "0";
				}
		}
	}
}