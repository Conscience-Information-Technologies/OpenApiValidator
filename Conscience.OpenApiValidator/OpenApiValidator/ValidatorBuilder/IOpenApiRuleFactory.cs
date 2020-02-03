using System.Collections.Generic;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;

namespace Conscience.OpenApiValidator
{
	/// <summary>
	///
	/// </summary>
	internal interface IOpenApiRuleFactory
	{
		/// <summary>
		///
		/// </summary>
		IValidate Build(OpenApiDocument doc);

		/// <summary>
		///
		/// </summary>
		IValidate Build(OpenApiPaths paths);

		/// <summary>
		///
		/// </summary>
		IValidate Build(string urlPath, KeyValuePair<OperationType, OpenApiOperation> operation);
		
		/// <summary>
		///
		/// </summary>
		IValidate Build(OpenApiParameter parameter);

		/// <summary>
		///
		/// </summary>
		IValidate Build(OpenApiRequestBody requestBody);

		/// <summary>
		///
		/// </summary>
		IValidate Build(IDictionary<string, OpenApiMediaType> content);

		/// <summary>
		///
		/// </summary>
		IValidate Build(KeyValuePair<string, OpenApiMediaType> mediaType);

		/// <summary>
		///
		/// </summary>
		IList<IValidate> Build(KeyValuePair<string, OpenApiEncoding> encoding);

		/// <summary>
		///
		/// </summary>
		IValidate Build(OpenApiSchema schema);

		/// <summary>
		///
		/// </summary>
		IList<IValidate> Build(OpenApiSecurityRequirement securityRequirement);

		/// <summary>
		///
		/// </summary>
		IList<IValidate> Build(IOpenApiExtensible openApiExtensible);

		/// <summary>
		///
		/// </summary>
		IList<IValidate> Build(IOpenApiExtension openApiExtension);

		/// <summary>
		///
		/// </summary>
		/// <param name="encodings"></param>
		IValidate Build(IDictionary<string, OpenApiEncoding> encodings);

		#region Some Possible Builder Members
		/// <summary>
		///
		/// </summary>
		//IList<IValidate> Build(IDictionary<string, OpenApiHeader> headers);

		/// <summary>
		///
		/// </summary>
		//IList<IValidate> Build(OpenApiResponse response);

		/// <summary>
		///
		/// </summary>
		//IList<IValidate> Build(OpenApiResponses response);

		/// <summary>
		///
		/// </summary>
		//IList<IValidate> Build(OpenApiExternalDocs externalDocs);

		/// <summary>
		///
		/// </summary>
		//IValidate Build(KeyValuePair<string, OpenApiHeader> tag);

		/// <summary>
		///
		/// </summary>
		//IList<IValidationRule> Build(IDictionary<string, OpenApiServerVariable> serverVariables);

		/// <summary>
		///
		/// </summary>
		//RuleLogs Build(IValidate rule);

		/// <summary>
		///
		/// </summary>
		//IList<IValidate> Build(OpenApiContact contact);

		/// <summary>
		///
		/// </summary>
		//IList<IValidate> Build(IList<OpenApiServer> servers);

		/// <summary>
		///
		/// </summary>
		//IValidate Build(KeyValuePair<string, OpenApiPathItem> pathItem);

		/// <summary>
		///
		/// </summary>
		//IList<IValidate> Build(OpenApiServerVariable serverVariable);

		/// <summary>
		///
		/// </summary>
		//IList<IValidate> Build(IDictionary<OperationType, OpenApiOperation> operations);
		/// <summary>
		///
		/// </summary>
		//IList<IValidate> Build(IList<OpenApiParameter> parameters);

		/// <summary>
		///
		/// </summary>
		//IList<IValidate> Build(IList<OpenApiParameter> parameters);

		/// <summary>
		///
		/// </summary>
		/// <param name="referenceable">referenced object</param>
		//IList<IValidator> Visit(IOpenApiReferenceable referenceable);

		/// <summary>
		///
		/// </summary>
		//public abstract IList<IValidator> Build(OpenApiInfo info);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(OpenApiLicense license);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(OpenApiServer server);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(IDictionary<string, OpenApiCallback> callbacks);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(IDictionary<string, OpenApiExample> examples);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(OpenApiComponents components);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(IDictionary<string, OpenApiLink> links);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(OpenApiLink link);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(OpenApiCallback callback);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(OpenApiTag tag);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(OpenApiOAuthFlow openApiOAuthFlow);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(OpenApiSecurityScheme securityScheme);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(OpenApiExample example);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(IList<OpenApiTag> openApiTags);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(IList<OpenApiSecurityRequirement> openApiSecurityRequirements);

		/// <summary>
		///
		/// </summary>
		//IList<IValidator> Build(IList<OpenApiExample> example);
		#endregion 
	}
}
