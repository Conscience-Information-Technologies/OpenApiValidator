using System;
using System.Dynamic;
using System.Text;

namespace Conscience.Logging
{
	[Serializable]
	public class Log
	{
		public Log(string message) : this(message, null, LogNature.Log, Env.ALL) { }
		public Log(string message, string location) : this(message, location, LogNature.Log, Env.ALL) { }
		public Log(string message, string location, LogNature logNature) : this(message, location, logNature, Env.ALL) { }
		public Log(string message, string location, LogNature logNature, Env allowLogEnv)
		{
			Message=message;
			Location=location;
			AllowLogEnv=allowLogEnv;
			LogNature=logNature;
		}
		public Log(Exception exception, LogNature logNature, string message) : this(message, exception.StackTrace, logNature, Env.ALL)
		{
			Exception=exception;
		}

		public virtual string ID { get; set; }
		public string Code { get; set; }
		public string Key { get; set; }
		public string Message { get; set; }
		public string Location { get; set; }
		public Env AllowLogEnv { get; set; }
		public LogNature LogNature { get; set; }
		public Exception Exception { get; set; }
		public virtual ExpandoObject Data { get; set; }

		public bool HasErrorException {get{ return this.Exception!=null||LogNature==LogNature.ERROR; } }
		public override string ToString()
		{
			StringBuilder _messageMessageCollector = new StringBuilder();
			_messageMessageCollector.Append($"{Message}, {Location}, {LogNature}, {AllowLogEnv}");
			if(this.Exception!=null)
			{
				_messageMessageCollector.Append("\n\n\n");
				_messageMessageCollector.Append("------------------------------------------------------------");
				_messageMessageCollector.Append("--------------------------Exception-------------------------");
				_messageMessageCollector.Append("------------------------------------------------------------");

				var exceptionForLoop = this.Exception;

				while(exceptionForLoop!=null)
				{
					if(this.Exception!=null)
					{
						_messageMessageCollector.Append(this.Exception.ToString());
						_messageMessageCollector.Append("------------------------------------------------------------");
					}

					exceptionForLoop=this.Exception.InnerException;
				}
				_messageMessageCollector.Append("------------------------------------------------------------");
				_messageMessageCollector.Append("------------------------------------------------------------");
				_messageMessageCollector.Append("\n\n\n");
			}

			return _messageMessageCollector.ToString();
		}
	}

	//public enum ProcessState
	//{
	//	//InProgress = 1,
	//	//Stopped = 2,
	//	//Finished = 3,
	//	//SomethingWentWrong = 4,

	//	NeedToProgress = 101,
	//	InProgress = 102,
	//	Progressed = 103,
	//	Active = 104,
	//	InActive = 105,
	//	Hold = 106,
	//	Stopped = 107,
	//	Finished = 108,
	//	Error = 109,
	//	Exception = 110,
	//}

}
