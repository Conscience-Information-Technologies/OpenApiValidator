using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;

namespace Conscience.OpenApiValidator
{
	/// <summary>
	///
	/// </summary>
	[Serializable]
	[DebuggerDisplay("Log= {LogCount}; Child= {Rules.Count}")]
	public class OpenApiHttpRequestValidator : OpenApiValidatorBase<HttpRequest, OpenApiOperation>
	{
		private OpenApiHeadersValidator _headerValidator;
		private OpenApiPathValidator _pathValidator;
		private OpenApiQueryStringValidator _queryValidator;
		private OpenApiCookiesValidator _cookiesValidator;
		private OpenApiBodyValidator _bodyValidator;

		private readonly IValidatorContext _validatorContext;

		[NonSerialized]
		private readonly OpenApiRequestBody _OpenApiRequestBody;

		public OpenApiHttpRequestValidator() : base(null, null)
		{
			UrlPath=null;
		}

		public OpenApiHttpRequestValidator(string urlPath, OperationType httpMethod, IValidatorContext validatorContext, OpenApiOperation openApiOperation) : base(validatorContext, openApiOperation)
		{
			UrlPath = urlPath;
			HttpMethod = httpMethod;
			_validatorContext = validatorContext;
			_OpenApiRequestBody = openApiOperation.RequestBody;
		}

		public OpenApiHttpRequestValidator(string urlPath, IValidatorContext context, KeyValuePair<OperationType, OpenApiOperation> operation) : this(urlPath, operation.Key, context, operation.Value)
		{ }

		public string Key { get { return $"{UrlPath.Replace("/","")}{HttpMethod}"; } }

		public override void SetData(HttpRequest httpRequest)
		{
			_headerValidator?.SetData(httpRequest);
			_queryValidator?.SetData(httpRequest);
			_pathValidator?.SetData(httpRequest);
			_cookiesValidator?.SetData(httpRequest);
			_bodyValidator?.SetData(httpRequest);
		}

		public OperationType HttpMethod { get; private set; }

		public string UrlPath { get; private set; }

		public virtual RuleLogs Validate(HttpContext httpContext)
		{
			this.SetData(httpContext.Request);
			return this.Validate();
		}

		public override RuleLogs Validate()
		{
			if (_headerValidator != null)
				_ruleLogs.Log(_headerValidator.Validate());

			if (_pathValidator != null)
				_ruleLogs.Log(_pathValidator.Validate());

			if (_queryValidator != null)
				_ruleLogs.Log(_queryValidator.Validate());

			if (_cookiesValidator != null)
				_ruleLogs.Log(_cookiesValidator.Validate());

			if (_bodyValidator != null)
				_ruleLogs.Log(_bodyValidator.Validate());

			return _ruleLogs;
		}

		public override void AddRule(IValidate rule)
		{
			if (rule is OpenApiParameterRule)
			{
				var _openApiParameterRule = rule as OpenApiParameterRule;

				switch (_openApiParameterRule.InParameterLocation)
				{
					case ParameterLocation.Query:   //Query = 0,
						if (_queryValidator == null)
							_queryValidator = new OpenApiQueryStringValidator(_validatorContext);
						_queryValidator.AddRule(_openApiParameterRule);
						break;
					case ParameterLocation.Header:  //Header = 1,
						if (_headerValidator == null)
							_headerValidator = new OpenApiHeadersValidator(_validatorContext);
						_headerValidator.AddRule(_openApiParameterRule);
						break;
					case ParameterLocation.Path:  //Path = 2,
						if (_pathValidator == null)
							_pathValidator = new OpenApiPathValidator(_validatorContext);
						_pathValidator.AddRule(_openApiParameterRule);
						break;
					case ParameterLocation.Cookie:  //Cookie = 3
						if (_cookiesValidator == null)
							_cookiesValidator = new OpenApiCookiesValidator(_validatorContext);
						_cookiesValidator.AddRule(_openApiParameterRule);
						break;
					case null:
						break;
					default:
						break;
				}
			}
			else
				if (rule is OpenApiBodyValidator)
			{
				_bodyValidator = rule as OpenApiBodyValidator;
			}
		}

		public override void AddRule(IEnumerable<IValidate> rules)
		{
			foreach (var rule in rules)
			{
				this.AddRule(rule);
			}
		}

		public override void Clear()
		{
			_headerValidator?.Clear();
			_pathValidator?.Clear();
			_queryValidator?.Clear();
			_cookiesValidator?.Clear();
			_bodyValidator?.Clear();
			base.Clear();
		}
									 
		public override Object Clone()
		{
			var cloneCopy = new OpenApiHttpRequestValidator(this.UrlPath, this.HttpMethod, this._validatorContext, _openApiElement);
			if(this._headerValidator!=null)
				cloneCopy._headerValidator=this._headerValidator.Clone() as OpenApiHeadersValidator;

			if(this._pathValidator!=null)
				cloneCopy._pathValidator=this._pathValidator.Clone() as OpenApiPathValidator;

			if(this._queryValidator!=null)
				cloneCopy._queryValidator=this._queryValidator.Clone() as OpenApiQueryStringValidator;

			if(this._cookiesValidator!=null)
				cloneCopy._cookiesValidator=this._cookiesValidator.Clone() as OpenApiCookiesValidator;

			if(this._bodyValidator!=null)
				cloneCopy._bodyValidator=this._bodyValidator.Clone() as OpenApiBodyValidator;

			this.Copy(cloneCopy);
			return cloneCopy;
		}

		public override IValidate Copy(IValidate other)
		{
			if(other is OpenApiHttpRequestValidator)
			{
				var otherRef = other as OpenApiHttpRequestValidator;
				otherRef.HttpMethod=this.HttpMethod;
				otherRef.UrlPath=this.UrlPath;

				base.Copy(other);
				return otherRef;
			}
			return other;
		}
	}
}
