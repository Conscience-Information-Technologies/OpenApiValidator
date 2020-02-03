using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace Conscience.OpenApiValidator
{
	/// <summary>
	///
	/// </summary>	 
	[Serializable]
	public class OpenApiCookiesValidator : OpenApiValidatorBase<IRequestCookieCollection, object>
	{
		public OpenApiCookiesValidator(IValidatorContext context) : base(context, null)
		{ }

		public void  SetData(HttpRequest request)
		{
			foreach(var rule in Rules)
			{
				var queryStringParameterRule = rule as Conscience.OpenApiValidator.OpenApiParameterRule;
				if(queryStringParameterRule!=null&&request.Cookies!=null)
					foreach(var cookie in request.Cookies.Where(e => rule.RequestElementName==e.Key))
					{
						var keyValue = new KeyValuePair<string, StringValues>(cookie.Key, new StringValues(cookie.Value));
						queryStringParameterRule.SetData(keyValue);
					}
			}
		}

		public override RuleLogs Validate()
		{
			return base.Validate();
		}

		public override Object Clone()
		{
			var cloneCopy = new OpenApiHeadersValidator(this._context);
			base.Copy(cloneCopy);
			return cloneCopy;
		}

	}
}
