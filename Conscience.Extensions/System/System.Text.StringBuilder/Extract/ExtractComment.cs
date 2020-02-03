using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static StringBuilder ExtractComment(this StringBuilder @this)
		{
			return @this.ExtractComment(0);
		}

		public static StringBuilder ExtractComment(this StringBuilder @this, out int endIndex)
		{
			return @this.ExtractComment(0, out endIndex);
		}

		public static StringBuilder ExtractComment(this StringBuilder @this, int startIndex)
		{
			int endIndex;
			return @this.ExtractComment(startIndex, out endIndex);
		}

		public static StringBuilder ExtractComment(this StringBuilder @this, int startIndex, out int endIndex)
		{
			if(@this.Length>startIndex+1)
			{
				var ch1 = @this[startIndex];
				var ch2 = @this[startIndex+1];

				if(ch1=='/'&&ch2=='/')
				{
					// Single line comment

					return @this.ExtractCommentSingleLine(startIndex, out endIndex);
				}

				if(ch1=='/'&&ch2=='*')
				{
					/*
					 * Multi-line comment
					 */

					return @this.ExtractCommentMultiLine(startIndex, out endIndex);
				}
			}

			endIndex=-1;
			return null;
		}
	}
}