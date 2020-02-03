using Conscience.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Conscience.OpenApiValidator
{
	/// <summary>
	///
	/// </summary>
	public interface IValidate : ICloneable
	{
		/// <summary>
		///
		/// </summary>
		string RequestElementName { get; set; }

		/// <summary>
		///
		/// </summary>
		RuleLogs Validate();

		/// <summary>
		///
		/// </summary>
		///void AddRule(IValidate validator);

		/// <summary>
		///
		/// </summary>
		///void AddRule(IList<IValidate> validator);

		/// <summary>
		///
		/// </summary>
		void AddRule(IValidate validator);

		/// <summary>
		///
		/// </summary>
		void AddRule(IEnumerable<IValidate> validator);

		void Clear();

		IValidate Copy(IValidate validator);

		void ReleaseElement();
	}

	public interface ISetData<TData>
	{
		/// <summary>
		///
		/// </summary>
		void SetData(TData parent);
	}

	/// <summary>
	///
	/// </summary>	 
	[Serializable]
	[DebuggerDisplay("Log= {LogCount}; Rules= {Rules.Count}")]
	public class ValidatorRule<TData, TElement> : IValidate, ISetData<TData>
	{
		/// <summary>
		///
		/// </summary>
		//protected TData _data;

		/// <summary>
		///
		/// </summary>	
		[NonSerialized]
		internal TElement _openApiElement;

		/// <summary>
		///
		/// </summary>
		[NonSerialized]
		public TData Data;

		/// <summary>
		///
		/// </summary>
		internal IValidatorContext _context;

		/// <summary>
		///
		/// </summary>
		internal RuleLogs _ruleLogs;

		/// <summary>
		///
		/// </summary>
		private int LogCount => _ruleLogs==null ? 0 : _ruleLogs.Count;

		/// <summary>
		///
		/// </summary>
		public string RequestElementName { get; set; }

		public string RuleName { get { return this.GetType().Name; } }

		public string RuleCode { get; set; }

		public string LocalizationResourceKey { get; set; }

		public ValidatorRule(IValidatorContext context, TElement element) : this(context, element, new RuleLogs())
		{ }

		/// <summary>
		///
		/// </summary>
		public ValidatorRule(IValidatorContext context, TElement element, RuleLogs ruleLogs)
		{
			_ruleLogs=ruleLogs;

			if(context==null)
				_ruleLogs.Log(new NullReferenceException($"Rule: {RuleName}, Field: _data"), LogNature.ExArgument, $"NULL - Data Field of {RuleName}");

			_context=context;
			_openApiElement=element;
			if(element!=null)
				OpenApiElementName=element.GetType().Name;

			RequestElementName=element.GetFieldNameForRules();
		}

		/// <summary>
		///
		/// </summary>
		public virtual List<IValidate> Rules { get; set; } = new List<IValidate>();


		public string OpenApiElementName { get; set; }

		/// <summary>
		///
		/// </summary>
		public virtual RuleLogs Validate()
		{
			//if(_data==null)
			//_ruleLogs.Log(new NullReferenceException($"Rule: {RuleName}, Field: _data"), LogNature.ExArgument, $"NULL - Data Field of {RuleName}");

			//foreach(var rule in this)
			//{
			//	_ruleLogs.Log(rule.Validate());
			//}

			foreach(var rule in Rules)
			{
				_ruleLogs.Log(rule.Validate());
			}

			return _ruleLogs;
		}

		public virtual void Clear()
		{
			_ruleLogs.Clear();
			Data=default(TData);
			foreach(var rule in Rules)
			{
				rule.Clear();
			}
		}

		/// <summary>
		///
		/// </summary>
		public void ReleaseElement()
		{
			_openApiElement=default(TElement);

			foreach(var rule in Rules)
			{
				rule.ReleaseElement();
			}
		}

		/// <summary>
		///
		/// </summary>
		public virtual void SetData(TData data)
		{
			Data=data;
		}

		/// <summary>
		///
		/// </summary>
		public override int GetHashCode()
		{
			//var hash = new HashCode();
			//hash.Add(_context);
			//hash.Add(hash);
			//hash.Add(_context.ValidatorOptions);
			//return hash.ToHashCode();
			return base.GetHashCode();
		}

		/// <summary>
		///
		/// </summary>
		//public void AddRule(IValidate validator)
		//{
		//	if(validator!=null)
		//		this.Add(validator);
		//}

		/// <summary>
		///
		/// </summary>
		//public void AddRule(IList<IValidate> validators)
		//{
		//if(validators!=null)
		//	this.AddRange(validators);
		//}

		/// <summary>
		///
		/// </summary>
		public virtual void AddRule(IValidate validator)
		{
			if(validator!=null)
			{
				Rules.Add(validator);
			}
		}

		/// <summary>
		///
		/// </summary>
		public virtual void AddRule(IEnumerable<IValidate> validators)
		{
			if(validators!=null)
			{
				Rules.AddRange(validators);
			}
		}

		public virtual Object Clone()
		{
			var that = new ValidatorRule<TData, TElement>(this._context, this._openApiElement);
			this.Copy(that);
			return that;
			//throw new NotImplementedException($"Clone is not implimented for Element {RequestElementName} & Rule {RuleName}");
		}

		public virtual IValidate Copy(IValidate other)
		{												   
			if(other is ValidatorRule<TData, TElement>)
			{
				var thatRef = other as ValidatorRule<TData, TElement>;

				//base.Copy(that);
				thatRef.OpenApiElementName=this.OpenApiElementName;
				thatRef.RequestElementName=this.RequestElementName;
				thatRef.RuleCode=this.RuleCode;
				thatRef.LocalizationResourceKey=this.LocalizationResourceKey;

				foreach(var rule in Rules)
				{
					var clonedObj = rule.Clone();
					if(clonedObj is IValidate)
						thatRef.Rules.Add(clonedObj as IValidate);
				}
				return thatRef;
			}
			return other;
		}
	}

	/// <summary>
	/// Object containing contextual information based on where the walker is currently referencing in an OpenApiDocument
	/// </summary>
	internal class CurrentKeys
	{
		/// <summary>
		/// Current Path key
		/// </summary>
		internal string Path { get; set; }

		/// <summary>
		/// Current Operation Type
		/// </summary>
		internal OperationType? Operation { get; set; }

		/// <summary>
		/// Current Response Status Code
		/// </summary>
		internal string Response { get; set; }

		/// <summary>
		/// Current Content Media Type
		/// </summary>
		internal string Content { get; set; }

		/// <summary>
		/// Current Callback Key
		/// </summary>
		internal string Callback { get; set; }

		/// <summary>
		/// Current Link Key
		/// </summary>
		//internal string Link { get; set; }

		/// <summary>
		/// Current Header Key
		/// </summary>
		internal string Header { get; set; }

		/// <summary>
		/// Current Encoding Key
		/// </summary>
		internal string Encoding { get; set; }

		/// <summary>
		/// Current Example Key
		/// </summary>
		//internal string Example { get; internal set; }

		/// <summary>
		/// Current Extension Key
		/// </summary>
		internal string Extension { get; set; }

		/// <summary>
		/// Current ServerVariable
		/// </summary>
		internal string ServerVariable { get; set; }
	}
}
