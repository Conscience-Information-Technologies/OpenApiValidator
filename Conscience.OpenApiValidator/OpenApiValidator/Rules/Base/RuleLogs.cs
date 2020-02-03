using System;
using System.Text;
using Conscience.Logging;

namespace Conscience.OpenApiValidator
{
	/// <summary>
	///
	/// </summary>	   
	[Serializable]
	public class RuleLogs : Logs
	{
		/// <summary>
		///
		/// </summary>
		public RuleLogs()
		{

		}

		/// <summary>
		/// 
		/// </summary>
		public override string ToString()
		{
			StringBuilder _textMessageCollector = new StringBuilder();
			var _status = this;

			_textMessageCollector.Append("############################################################");
			_textMessageCollector.Append(base.ToString());
			_textMessageCollector.Append("\n\n");

			return _textMessageCollector.ToString();
		}
	}
}
