using System;
using System.Collections.Generic;
using System.Text;

namespace Conscience
{
	public class DataException : Exception
	{
		public DataException(string message, Exception innerException)
		    : base(message, innerException)
		{
		}
	}
}
