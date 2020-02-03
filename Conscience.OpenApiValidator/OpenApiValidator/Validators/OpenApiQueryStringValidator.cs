using System;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Conscience.OpenApiValidator
{
	/// <summary>
	///
	/// </summary>		 
	[Serializable]
	public class OpenApiQueryStringValidator : OpenApiValidatorBase<IQueryCollection, object>
	{
		public OpenApiQueryStringValidator(IValidatorContext context) : base(context, null)
		{
		}

		public void SetData(HttpRequest request)
		{
			foreach(var rule in Rules)
			{
				var queryStringParameterRule = rule as Conscience.OpenApiValidator.OpenApiParameterRule;
				if(queryStringParameterRule!=null&&request.Query!=null)
					foreach(var queryItem in request.Query.Where(e => rule.RequestElementName==e.Key))
					{
						queryStringParameterRule.SetData(queryItem);
					}
			}
		}

		public override RuleLogs Validate()
		{
			return base.Validate();
		}

		public override Object Clone()
		{
			var cloneCopy = new OpenApiQueryStringValidator(this._context);
			base.Copy(cloneCopy);
			return cloneCopy;
		}
	}
}
