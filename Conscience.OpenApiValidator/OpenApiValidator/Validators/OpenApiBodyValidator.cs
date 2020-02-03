using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;

namespace Conscience.OpenApiValidator
{
	/// <summary>
	///
	/// </summary>	   
	[Serializable]
	public class OpenApiBodyValidator : OpenApiValidatorBase<Stream, OpenApiRequestBody>
	{
		/// <summary>
		///
		/// </summary>
		public bool Required { get; set; }

		/// <summary>
		///
		/// </summary>
		public IDictionary<string, OpenApiMediaType> Content { get; set; }

		/// <summary>
		///
		/// </summary>
		public OpenApiBodyValidator(IValidatorContext context, OpenApiRequestBody openApiBody) : base(context, openApiBody)
		{

		}

		public void SetData(HttpRequest request)
		{
			foreach(var rule in Rules)
			{
				var queryStringParameterRule = rule as Conscience.OpenApiValidator.OpenApiContentMediaTypeRule;

				queryStringParameterRule.SetData(request);
			}		 
		}

		/// <summary>
		///
		/// </summary>
		public override RuleLogs Validate()
		{
			return base.Validate();
		}

		public override Object Clone()
		{
			var cloneCopy = new OpenApiBodyValidator(this._context, this._openApiElement);
			this.Copy(cloneCopy);
			return cloneCopy;
		}

		public override IValidate Copy(IValidate other)
		{
			if(other is OpenApiBodyValidator)
			{
				base.Copy(other);
				var thatRef = other as OpenApiBodyValidator;
				thatRef.Required=this.Required;
				return thatRef;
			}
			return other;
		}
	}
}
