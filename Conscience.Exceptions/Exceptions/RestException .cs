using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Conscience
{
	public class RestException : Exception
	{
		protected RestException(HttpStatusCode statusCode, string message)
		    : base(message)
		{
			this.StatusCode=statusCode;
		}

		public HttpStatusCode StatusCode { get; private set; }
	}
}
