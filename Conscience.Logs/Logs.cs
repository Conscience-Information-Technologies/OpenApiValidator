using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Conscience.Logging
{
	[Serializable]
	[DebuggerDisplay("{Count}, Exceptions : {ExceptionCount}, Errors : {ErrorCount}")]
	public class Logs : List<Log>
	{
		public void Log(string text) { this.Log(text, null, LogNature.Log, Env.ALL); }

		public void Log(string text, string location) { this.Log(text, location, LogNature.Log, Env.ALL); }

		public void Log(string text, string location, LogNature messageNature) { this.Log(text, location, messageNature, Env.ALL); }

		public void Log(string text, string location, LogNature messageNature, Env allowLogEnv)
		{
			this.Add(new Log(text, location, messageNature, allowLogEnv));
		}

		public void Log(Log log)
		{
			this.Add(log);
		}   

		public void Log(Exception exception, LogNature logNature) { this.Log(exception, logNature, null); }

		public void Log(Exception exception, LogNature logNature, string text)
		{
			this.Add(new Log(exception, logNature, text));
		}
		
		public void Log(IEnumerable<Log> log)
		{
			this.AddRange(log);
		}

		public virtual string ID { get; set; }
		public virtual string Time { get; set; } = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-ffff-t");
		public virtual object Data { get; set; }
		public int Code { get; set; }

		private int ExceptionCount { get { return Exceptions.Count(); } }
		private int ErrorCount { get { return Errors.Count(); } }
		public IEnumerable<Log> Exceptions { get { return this.Where(e => e.LogNature==LogNature.EXCEPTION); } }
		public IEnumerable<Log> Errors { get { return this.Where(e => e.LogNature==LogNature.ERROR); } }
		public IEnumerable<Log> ErrorsExceptions { get { return this.Where(e => e.LogNature==LogNature.ERROR&&e.LogNature==LogNature.EXCEPTION); } }
		public Exception LatestException { get; private set; }
		public Log LatestError { get; private set; }
		public bool AnyException { get { return LatestException!=null; } }
		public bool AnyErrorException { get { return LatestException!=null||LatestError!=null; } }
		public virtual bool IsValid => !AnyErrorException;

		public override string ToString()
		{
			return LogToString();
		}

		public string LogToString()
		{
			StringBuilder _textMessageCollector = new StringBuilder();

			foreach(var message in this)
				_textMessageCollector.Append(message.ToString());

			return _textMessageCollector.ToString();
		}

		public new void Add(Log log)
		{
			if(log==null)
				return;

			if(log.LogNature==LogNature.EXCEPTION)
			{
				if(log.Exception==null)
					log.Exception=new Exception(log.Message);
				this.LatestException=log.Exception;
			}
			else
			if(log.LogNature==LogNature.ERROR)
			{
				this.LatestError=log;
			}

			base.Add(log);
		}

		public new void AddRange(IEnumerable<Log> logs)
		{
			foreach(var log in logs)
			{
				this.Add(log);
			}
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
