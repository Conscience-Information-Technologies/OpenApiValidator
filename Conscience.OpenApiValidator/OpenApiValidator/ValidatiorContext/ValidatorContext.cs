using System;

namespace Conscience.OpenApiValidator
{
	/// <summary>
	/// Defines a validation context.
	/// </summary>
	public interface IValidatorContext
	{				      
		ValidatorOptions ValidatorOptions { get; set; }
	}

	/// <summary>
	/// Validation context
	/// </summary> 
	[Serializable]
	public class ValidatorContext : IValidatorContext
	{
		/// <summary>
		///
		/// </summary>
		public ValidatorContext()
		{ }

		/// <summary>
		///
		/// </summary>
		public ValidatorOptions ValidatorOptions { get; set; }
	}
}
