using System;
using System.Collections.Generic;
using System.Text;

namespace Conscience
{
	public class RuleDataMisMatchException : Exception
	{
		public RuleDataMisMatchException(string ruleName) : base("Data and type mismatch found.")
		{
			this.RuleName=ruleName;
		}

		public RuleDataMisMatchException(string ruleName, string message) : base(message)
		{
			this.RuleName=ruleName;
		}

		public RuleDataMisMatchException(string ruleName, string message, Exception innerException) : base(message, innerException)
		{
			this.RuleName=ruleName;
		}

		public string RuleName { get; private set; }



	}
}
