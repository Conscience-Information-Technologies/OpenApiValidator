using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Conscience
{
	public class RuleException : Exception
	{
		public RuleException(string ruleName, string message) : base(message)
		{
			this.RuleName=ruleName;
		}


		public string RuleName { get; private set; }
	}
}
