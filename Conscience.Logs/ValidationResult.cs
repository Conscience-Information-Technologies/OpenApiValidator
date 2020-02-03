using System;
using System.Collections.Generic;
using System.Linq;

namespace Conscience.Logging
{

	/// <summary>
	/// The result of running a validator
	/// </summary>
	public class ValidationResult : Logs
	{	     
		/// <summary>
		/// Creates a new validationResult
		/// </summary>
		public ValidationResult() {
		}

		public ValidationResult(Logs log)
		{
			this.Log(log);
		}
		public ValidationResult(IEnumerable<Log> log)
		{
			base.Log(log);
		}

		/// <summary>
		/// Generates a string representation of the error messages separated by new lines.
		/// </summary>
		/// <returns></returns>
		public override string ToString() {
			return base.ToString();
		}

		/// <summary>
		/// Generates a string representation of the error messages separated by the specified character.
		/// </summary>
		/// <param name="separator">The character to separate the error messages.</param>
		/// <returns></returns>
		//public string ToString(string separator) {
		//	return	string.Join(separator, errors.Select(failure => failure.ErrorMessage));
		//}
	}
}
