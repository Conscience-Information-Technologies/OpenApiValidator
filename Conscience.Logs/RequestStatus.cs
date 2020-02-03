using System;
using System.Net;
using System.Text;

namespace Conscience.Logging
{
	public class RequestStatus : Logs
	{
		public RequestStatus() { }
		public RequestStatus(HttpStatusCode httpStatusCode) { HttpStatusCode=httpStatusCode; }
		//public ApiStatus(Log log) { base.Log(log); }
		//public ApiStatus(string text) { base.Log(text, null, LogNature.Log, Environment.ALL); }
		//public ApiStatus(string text, string location) { base.Log(text, location, LogNature.Log, Environment.ALL); }
		//public ApiStatus(string text, string location, LogNature messageNature) { base.Log(text, location, messageNature, Environment.ALL); }
		//public ApiStatus(string text, string location, LogNature messageNature, Environment allowLogEnv)
		//{
		//	base.Add(new Log(text, location, messageNature, allowLogEnv));
		//}
		//public ApiStatus(Exception exception) { base.Add(exception, null); }
		//public ApiStatus(Exception exception, string text)
		//{
		//	base.Add(new Log(exception, text));
		//}

		public HttpStatusCode HttpStatusCode { get; private set; }
		public string HTTPMessage { get; set; }
		public RequestStatus NestedStatus { get; set; }
		private bool? isSuccess { get; set; }
		public virtual bool IsSuccess
		{
			get
			{
				var @apiStatus = this;
				while(@apiStatus!=null)
				{
					if(@apiStatus.IsValid==false||(isSuccess.HasValue&&isSuccess==false))
						return false;
					@apiStatus=@apiStatus.NestedStatus;
				}

				return true;
			}
			set
			{
				isSuccess=value;
			}
		}

		public virtual void SetHttpStatusCode(HttpStatusCode httpStatusCode)
		{
			HttpStatusCode=httpStatusCode;
		}

		public override string ToString()
		{
			StringBuilder _textMessageCollector = new StringBuilder();
			var _status = this;

			_textMessageCollector.Append("############################################################");
			_textMessageCollector.Append($"ID: {ID}, Activity Code: {Code}\n");
			_textMessageCollector.Append($"Http Status Code: {HttpStatusCode}\n");
			_textMessageCollector.Append($"Message: {HTTPMessage}\n");
			while(_status!=null)
			{
				_textMessageCollector.Append(_status.LogToString());
				_textMessageCollector.Append("\n\n");
				_status=this.NestedStatus;
			}

			return _textMessageCollector.ToString();
		}
	}
}