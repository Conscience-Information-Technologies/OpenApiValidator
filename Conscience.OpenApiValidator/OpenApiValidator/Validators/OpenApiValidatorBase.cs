using System;
using System.Collections.Generic;

namespace Conscience.OpenApiValidator
{
	/// <summary>
	///
	/// </summary>	 
	[Serializable]
	public class OpenApiValidatorBase<TData, TElement> : ValidatorRule<TData, TElement>
	{
		//public new List<OpenApiParameterRule> ChildRules { get; set; }
		public OpenApiValidatorBase(IValidatorContext context, TElement element) : base(context, element)
		{
		}

		public override void SetData(TData parent)
		{
			
		} 
	}


}
