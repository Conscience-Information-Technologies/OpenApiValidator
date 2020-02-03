//using System;
//using System.Collections.Generic;
//using System.Dynamic;
//using System.Linq;
//using Conscience.Logging;
//using Microsoft.Extensions.Primitives;
//using Microsoft.OpenApi.Interfaces;
//using Microsoft.OpenApi.Models;

//namespace Conscience.OpenApiValidator
//{
//	/// <summary>
//	///
//	/// </summary>
//	public class OpenApiRequiredRule<TElement> : ValidatorRule<string, TElement>
//	{
//		private readonly IOpenApiExtensible OpenApiExtension;
//		private readonly KeyValuePair<string, IOpenApiExtension> requiredMeta;

//		/// <summary>
//		///
//		/// </summary>
//		public OpenApiRequiredRule(IValidatorContext context, TElement element) : base(context, element)
//		{
//			if (element is IOpenApiExtensible)
//				requiredMeta = (element as IOpenApiExtensible).Extensions.Where(e => e.Key != null && e.Key.Equals("x-required")).FirstOrDefault();
//		}

//		/// <summary>
//		///
//		/// </summary>
//		public virtual RuleLogs Validate()
//		{
//			//if (requiredMeta.IsNotDefault() && _data.IsNullOrEmpty())
//			//if (!requiredMeta.Equals(default(KeyValuePair<string, IOpenApiExtension>)) && _data != null)
//			//{
//			//	_ruleLogs.Log(new NullReferenceException($"Rule: {RuleName}, Field: _data"), LogNature.ExArgument, $"NULL - Data Field of {RuleName}");
//			//}
//			//else
//			if (Data == null)
//			{
//				_ruleLogs.Log(new NullReferenceException($"Rule: {RuleName}, Field: _data"), LogNature.ExArgument, $"NULL - Data Field of {RuleName}");
//			}

//			return _ruleLogs;
//		}
//	}
//}
