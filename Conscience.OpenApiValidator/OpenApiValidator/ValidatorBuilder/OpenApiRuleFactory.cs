using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;

namespace Conscience.OpenApiValidator
{
	/// <summary>
	///
	/// </summary>
	internal class OpenApiRuleFactory : IOpenApiRuleFactory
	{
		/// <summary>
		///
		/// </summary>
		IList<IValidate> Rules;

		/// <summary>
		///
		/// </summary>
		private readonly IValidatorContext _validatorContext;

		/// <summary>
		///
		/// </summary>
		public OpenApiRuleFactory(IValidatorContext validatorContext)
		{
			_validatorContext = validatorContext;
		}

		/// <summary>
		///
		/// </summary>
		public IValidate Build(OpenApiDocument doc)
		{
			IValidate validator = new ValidatorRule<HttpRequest, OpenApiDocument>(_validatorContext, doc);

			return validator;
		}

		/// <summary>
		///
		/// </summary>
		public IValidate Build(OpenApiPaths paths)
		{
			IValidate validator = new ValidatorRule<HttpRequest, OpenApiPaths>(_validatorContext, paths);
			return validator;
		}

		/// <summary>
		///
		/// </summary>
		public IList<IValidate> Build(OpenApiPathItem pathItem) => Rules;

		/// <summary>
		///
		/// </summary>
		public IValidate Build(string urlPath, KeyValuePair<OperationType, OpenApiOperation> operation) => new OpenApiHttpRequestValidator(urlPath, _validatorContext, operation);

		/// <summary>
		///
		/// </summary>
		public IValidate Build(OpenApiParameter parameter)
		{
			IValidate validator = new OpenApiParameterRule(parameter.Name, parameter.In, _validatorContext, parameter);

			//if (parameter.IsRequired())
			//validator.AddRule(BuildRequired(_validatorContext, parameter));

			return validator;
		}

		//if (!parameter.AllowEmptyValue)
		//validator.AddRule(BuildRequired(_validatorContext, parameter));
		//private IValidate BuildRequired(IValidatorContext validatorContext, IOpenApiElement openApiElement)
		//{
			//return new OpenApiRequiredRule<IOpenApiElement>(validatorContext, openApiElement);

			//switch (schema.Type)
			//{
			//	case "string":
			//		new ValidatorRule<string, IOpenApiElement>(validatorContext, openApiElement);
			//		break;
			//	case "boolean":
			//		new ValidatorRule<bool, IOpenApiElement>(validatorContext, openApiElement);
			//		break;
			//	case "boolean":
			//		new ValidatorRule<bool, IOpenApiElement>(validatorContext, openApiElement);
			//		break;
			//	default:
			//		break;
			//}
			//return null;
		//}

		/// <summary>
		///
		/// </summary>
		public IValidate Build(OpenApiRequestBody requestBody)
		{
			IValidate validator = new OpenApiBodyValidator(_validatorContext, requestBody);
			return validator;
		}

		/// <summary>
		///
		/// </summary>
		public IValidate Build(IDictionary<string, OpenApiMediaType> content)
		{
			IValidate validator = new ValidatorRule<HttpRequest, IDictionary<string, OpenApiMediaType>>(_validatorContext, content);
			//OpenApiBodyValidator
			return validator;
		}

		/// <summary>
		///
		/// </summary>
		public IValidate Build(KeyValuePair<string, OpenApiMediaType> mediaType)
		{
			return new OpenApiContentMediaTypeRule(_validatorContext, mediaType);
		}

		/// <summary>
		///
		/// </summary>
		public IList<IValidate> Build(KeyValuePair<string, OpenApiEncoding> encoding) => Rules;

		/// <summary>
		///
		/// </summary>
		public IValidate Build(OpenApiSchema schema)
		{
			IValidate validator = new OpenApiSchemaRuleUsingManateeJson(_validatorContext, schema);

			///string dataTypestring format
			return validator;
		}

		/// <summary>
		///
		/// </summary>
		public IList<IValidate> Build(OpenApiSecurityRequirement securityRequirement) => Rules;

		/// <summary>
		///
		/// </summary>
		public IList<IValidate> Build(IOpenApiExtensible openApiExtensible) => Rules;

		/// <summary>
		///
		/// </summary>
		public IList<IValidate> Build(IOpenApiExtension openApiExtension) => Rules;

		/// <summary>
		///
		/// </summary>
		/// <param name="encodings"></param>
		public IValidate Build(IDictionary<string, OpenApiEncoding> encodings)
		{
			IValidate validator = new ValidatorRule<HttpRequest, IDictionary<string, OpenApiEncoding>>(_validatorContext, encodings);
			return validator;
		}

		#region Some Possible Builder Members
		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(OpenApiOAuthFlow openApiOAuthFlow)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidate> Build(OpenApiContact contact) => Rules;

		/// <summary>
		///
		/// </summary>
		//public IList<IValidate> Build(IList<OpenApiServer> servers) => Rules;

		/// <summary>
		///
		/// </summary>
		//public IList<IValidate> Build(IDictionary<OperationType, OpenApiOperation> operations) => Rules;

		/// <summary>
		///
		/// </summary>
		//public IList<IValidate> Build(IList<OpenApiParameter> parameters) => Rules;

		/// <summary>
		///
		/// </summary>
		//public IList<IValidate> Build(OpenApiExternalDocs externalDocs) => Rules;

		/// <summary>
		///
		/// </summary>
		//public IValidate Build(KeyValuePair<string, OpenApiHeader> tag)
		//{
		//	IValidate validator = new ValidatorRule<HttpRequest, object>(_validatorContext, tag);

		//	return validator;
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidate> Build(IDictionary<string, OpenApiHeader> headers) => Rules;

		/// <summary>
		///
		/// </summary>
		//public IList<IValidate> Build(OpenApiResponse response) => Rules;

		/// <summary>
		///
		/// </summary>
		//public IList<IValidate> Build(OpenApiResponses response) => Rules;

		/// <summary>
		///
		/// </summary>						  `
		//public IList<IValidate> Build(IDictionary<string, OpenApiServerVariable> serverVariables) => Rules;

		//public IValidate Build(KeyValuePair<string, OpenApiPathItem> pathItem)
		//{
		//	var httpRequestValidator = new OpenApiHttpRequestValidator(_validatorContext);
		//	return httpRequestValidator;
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(OpenApiInfo info)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(OpenApiLicense license)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(OpenApiServer server)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(IDictionary<string, OpenApiCallback> callbacks)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(IDictionary<string, OpenApiExample> examples)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(OpenApiComponents components)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(IDictionary<string, OpenApiLink> links)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(OpenApiLink link)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(OpenApiCallback callback)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(OpenApiTag tag)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(OpenApiSecurityScheme securityScheme)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(OpenApiExample example)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(IList<OpenApiTag> openApiTags)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(IList<OpenApiSecurityRequirement> openApiSecurityRequirements)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidator> Build(IList<OpenApiExample> example)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		/// <param name="referenceable">referenced object</param>
		//public IList<IValidator> Visit(IOpenApiReferenceable referenceable)
		//{
		//}

		/// <summary>
		///
		/// </summary>
		//public IList<IValidationRule> Build(OpenApiServerVariable serverVariable)
		//{
		//	return Rules;
		//}
		#endregion
	}
}
