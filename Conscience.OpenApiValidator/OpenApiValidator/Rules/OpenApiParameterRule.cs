using System;
using System.Collections.Generic;
using Conscience.Logging;
using Microsoft.Extensions.Primitives;
using Microsoft.OpenApi.Models;

namespace Conscience.OpenApiValidator
{
	/// <summary>
	///
	/// </summary>				    
	[Serializable]
	public class OpenApiParameterRule : ValidatorRule<KeyValuePair<string, StringValues>, OpenApiParameter>
	{
		//private OpenApiSchemaRule
		private OpenApiSchemaRuleUsingManateeJson _openApiSchemaRule;
		private IList<OpenApiContentMediaTypeRule> _openApiContentMediaTypeRule;
		private bool _required;

		/// <summary>
		///
		/// </summary>
		public OpenApiParameterRule(string fieldName, ParameterLocation? inParameterLocation, IValidatorContext context, OpenApiParameter element) : base(context, element)
		{
			this.RequestElementName = fieldName;
			this.InParameterLocation = inParameterLocation;
			this._required = element.Required;
		}

		public override void Clear()
		{
			_openApiSchemaRule.Clear();

			//foreach(var rule in _openApiContentMediaTypeRule)
				//rule.ClearLog();

			base.Clear();
		}

		/// <summary>
		///
		/// </summary>
		public ParameterLocation? InParameterLocation { get; private set; }

		/// <summary>
		///
		/// </summary>
		public override void AddRule(IEnumerable<IValidate> validators)
		{
			foreach(var validator in validators)
			{
				this.AddRule(validator);
			}
		}

		/// <summary>
		///
		/// </summary>
		public override void AddRule(IValidate rule)
		{
			if(rule is OpenApiSchemaRuleUsingManateeJson)
			{
				_openApiSchemaRule=rule as OpenApiSchemaRuleUsingManateeJson;
			}
			else
				if(rule is OpenApiContentMediaTypeRule)
			{
				if(_openApiContentMediaTypeRule==null)
					_openApiContentMediaTypeRule=new List<OpenApiContentMediaTypeRule>();

				_openApiContentMediaTypeRule.Add(rule as OpenApiContentMediaTypeRule);
			}
		}

		public override void SetData(KeyValuePair<string, StringValues> data)
		{
			_openApiSchemaRule.SetData(data.Value.ToString());
		}

		/// <summary>
		///
		/// </summary>
		public override RuleLogs Validate()
		{
			if(_required&&_openApiSchemaRule.Data==null)
			{
				_ruleLogs.Log($"{RequestElementName} is required.");
				return _ruleLogs;
			}



			return _openApiSchemaRule.Validate();
		}

		public override Object Clone()
		{
			var that = new OpenApiParameterRule(this.RequestElementName, this.InParameterLocation, this._context, this._openApiElement);
			this.Copy(that);
			return that;
		}

		public override IValidate Copy(IValidate other)
		{
			if(other is OpenApiParameterRule)
			{
				var otherRef = other as OpenApiParameterRule;

				if(this._openApiSchemaRule!=null)
					otherRef._openApiSchemaRule=this._openApiSchemaRule as OpenApiSchemaRuleUsingManateeJson;

				base.Copy(other);
				return otherRef;
			}
			return other;
		}
	}
}
