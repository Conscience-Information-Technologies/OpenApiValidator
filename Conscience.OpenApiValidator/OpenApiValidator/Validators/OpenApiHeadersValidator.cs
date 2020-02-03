using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Conscience.OpenApiValidator
{
	/// <summary>
	///
	/// </summary>  
	[Serializable]
	public class OpenApiHeadersValidator : OpenApiValidatorBase<IHeaderDictionary, object>
	{
		public OpenApiHeadersValidator(IValidatorContext context) : base(context, null)
		{
			Rules= new List<IValidate>();
		}

		public override RuleLogs Validate()
		{
			return base.Validate();
		}


		public void SetData(HttpRequest request)
		{
			foreach(var rule in Rules)
			{
				var queryStringParameterRule = rule as Conscience.OpenApiValidator.OpenApiParameterRule;
				if(queryStringParameterRule!=null&&request.Headers!=null)
					foreach(var header in request.Headers.Where(e => rule.RequestElementName==e.Key))
					{
						queryStringParameterRule.SetData(header);
					}
			}
		}

		public override Object Clone()
		{
			var cloneCopy = new OpenApiHeadersValidator(this._context);
			base.Copy(cloneCopy);
			return cloneCopy;
		}


	}
}
