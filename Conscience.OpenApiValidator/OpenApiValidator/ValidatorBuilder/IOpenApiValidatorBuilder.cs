using System.Collections.Generic;
using Microsoft.OpenApi.Models;

namespace Conscience.OpenApiValidator
{
	/// <summary>
	/// 
	/// </summary>
	internal interface IOpenApiValidatorBuilder 
	{
		/// <summary>
		///
		/// </summary>
		IEnumerable<IValidate> Build(OpenApiDocument doc);
	}

	#region Few Possible Members
	//internal IEnumerable<IValidate> WalkAndBuild(OpenApiSchema openApi_HttpSchema)
	//{
	//	if (openApi_HttpSchema != null)
	//	{
	//		var rule = _ruleFactoryRule.Build(openApi_HttpSchema);

	//		//if (schema.Items != null)
	//		//	rule.AddRule(WalkAndBuild(schema.Items));

	//		//if (schema.AllOf.IsNotNullOrEmpty())
	//		//	rule.AddRule(WalkAndBuild(schema.AllOf));

	//		//if (schema.AnyOf.IsNotNullOrEmpty())
	//		//	rule.AddRule(WalkAndBuild(schema.AnyOf));

	//		//if (schema.Properties.IsNotNullOrEmpty())
	//		//	foreach (var item in schema.Properties)
	//		//	{
	//		//		rule.AddRule(WalkAndBuild(item.Value));
	//		//	}

	//		//WalkAndBuild(OpenApiConstants.ExternalDocs, () => WalkAndBuild(schema.ExternalDocs));
	//		//WalkAndBuild(schema as IOpenApiExtensible);
	//		yield return rule;
	//	}
	//	yield break;
	//}

	/// <summary>
	///
	/// </summary>
	//internal IEnumerable<IValidate> WalkAndBuild(IEnumerable<OpenApiSchema> openApi_HttpSchemas)
	//{
	//	if (openApi_HttpSchemas != null)
	//	{
	//		foreach (var openApi_Schema in openApi_HttpSchemas)
	//		{
	//			foreach (var item in WalkAndBuild(openApi_Schema))
	//			{
	//				yield return item;
	//			}
	//		}
	//	}
	//	yield break;
	//}

	/// <summary>
	///
	/// </summary>
	//internal IEnumerable<IValidate> WalkAndBuild(OpenApiParameter parameter)
	//{
	//	if (parameter != null) {
	//		var rule = _ruleFactoryRule.Build(parameter);

	//		if (parameter.Schema != null)
	//		{
	//			rule.AddRule(WalkAndBuild(parameter.Schema));
	//		}

	//		if (parameter.Content.IsNotNullOrEmpty())
	//		{
	//			rule.AddRule(WalkAndBuild(parameter.Content));
	//		}
	//		//WalkAndBuild(OpenApiConstants.Examples, () => WalkAndBuild(parameter.Examples));
	//		//WalkAndBuild(parameter as IOpenApiExtensible);
	//		yield return rule;
	//	}
	//	yield break;
	//}

	/// <summary>
	///
	/// </summary>
	//internal IEnumerable<IValidate> WalkAndBuild(OpenApiResponses responses)
	//{
	//	if(responses != null)
	//	{
	//		var rule = _ruleFactoryRule.Build(responses).FirstOrDefault();

	//		if(responses != null)
	//			foreach(var response in responses)
	//			{
	//				rule.AddRule(WalkAndBuild(response.Value));
	//			}

	//		//WalkAndBuild(responses as IOpenApiExtensible);
	//		yield return rule;
	//	}
	//	yield break;
	//}

	/// <summary>
	///
	/// </summary>
	//internal IEnumerable<IValidate> WalkAndBuild(OpenApiResponse response)
	//{
	//	if(response != null)			{
	//		var rule = _ruleFactoryRule.Build(response).FirstOrDefault();

	//		rule.AddRule(WalkAndBuild(response.Content));
	//		rule.AddRule(WalkAndBuild(response.Headers));
	//		//WalkAndBuild(OpenApiConstants.Links, () => WalkAndBuild(response.Links));
	//		//WalkAndBuild(response as IOpenApiExtensible);
	//		yield return rule;
	//	}
	//	yield break;
	//}

	/// <summary>
	///
	/// </summary>
	//internal IEnumerable<IValidate> WalkAndBuild(IDictionary<string, OpenApiHeader> headers)
	//{
	//	if(headers != null)
	//	{
	//		var rule = _ruleFactoryRule.Build(headers).FirstOrDefault();

	//		foreach(var header in headers)
	//		{
	//			rule.AddRule(WalkAndBuild(header));
	//		}
	//		yield return rule;
	//	}
	//	yield break;
	//}

	/// <summary>
	///
	/// </summary>
	//internal IEnumerable<IValidate> WalkAndBuild(KeyValuePair<string, OpenApiHeader> header)
	//{
	//	if(header.Key != null&&header.Value != null)
	//	{
	//		var rule = _ruleFactoryRule.Build(header);

	//		rule.AddRule(WalkAndBuild(header.Value.Content));
	//		rule.AddRule(WalkAndBuild(header.Value.Schema));

	//		//WalkAndBuild(OpenApiConstants.Example, () => WalkAndBuild(header.Example));
	//		//WalkAndBuild(OpenApiConstants.Examples, () => WalkAndBuild(header.Examples));
	//		//WalkAndBuild(header as IOpenApiExtensible);
	//		yield return rule;
	//	}
	//	yield break;
	//}

	/// <summary>
	///
	/// </summary>
	//private bool ProcessAsReference(IOpenApiReferenceable referenceable)
	//{
	//	var isReference = referenceable.Reference != null&&!isComponent;
	//	if(isReference)
	//	{
	//		WalkAndBuild(referenceable);
	//	}
	//	return isReference;
	//}


	/// <summary>
	///
	/// </summary>
	//internal IList<IValidate> WalkAndBuild(IOpenApiElement element)
	//{
	//	List<IValidate> ruleList = new List<IValidate>();
	//	if(element != null)
	//	{
	//		switch(element)
	//		{
	//			case OpenApiDocument e:
	//			ruleList.Add(WalkAndBuild(e));
	//			break;
	//			case OpenApiEncoding e:
	//			ruleList.AddRange(WalkAndBuild(e));
	//			break;
	//			case OpenApiExternalDocs e:
	//			ruleList.AddRange(WalkAndBuild(e));
	//			break;
	//			case OpenApiHeader e:
	//			ruleList.AddRange(WalkAndBuild(e));
	//			break;
	//			case OpenApiMediaType e:
	//			ruleList.AddRange(WalkAndBuild(e));
	//			break;
	//			case OpenApiOperation e:
	//			ruleList.AddRange(WalkAndBuild(e));
	//			break;
	//			case OpenApiParameter e:
	//			ruleList.AddRange(WalkAndBuild(e));
	//			break;
	//			case OpenApiRequestBody e:
	//			ruleList.AddRange(WalkAndBuild(e));
	//			break;
	//			case OpenApiResponse e:
	//			ruleList.AddRange(WalkAndBuild(e));
	//			break;
	//			case OpenApiSchema e:
	//			ruleList.AddRange(WalkAndBuild(e));
	//			break;
	//			//case OpenApiLicense e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case OpenApiInfo e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case OpenApiContact e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case OpenApiCallback e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case OpenApiExample e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case IDictionary<string, OpenApiExample> e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case OpenApiComponents e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case OpenApiLink e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case IDictionary<string, OpenApiLink> e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case OpenApiOAuthFlows e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case OpenApiOAuthFlow e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case OpenApiSecurityScheme e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case OpenApiSecurityRequirement e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case OpenApiServer e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case OpenApiServerVariable e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case OpenApiTag e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case IList<OpenApiTag> e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case IOpenApiExtensible e:
	//			//WalkAndBuild(e);
	//			//break;
	//			//case IOpenApiExtension e:
	//			//WalkAndBuild(e);
	//			//break;
	//		}
	//	}
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidate> WalkAndBuild(OpenApiContact contact) => contact.IsNull() ? new List<IValidate>() : _ruleFactoryRule.Build(contact);

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidate> WalkAndBuild(OpenApiServerVariable serverVariable) => serverVariable.IsNull() ? new List<IValidate>() : _ruleFactoryRule.Build(serverVariable);//_visitor.Build(serverVariable as IOpenApiExtensible);

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidate> WalkAndBuild(IDictionary<OperationType, OpenApiOperation> operations)
	//{
	//	List<IValidate> ruleList = new List<IValidate>();
	//	if(operations != null)
	//	{
	//		//IValidationRule rule = _visitor.Build(operations).FirstOrDefault();
	//		//ruleList.Add(rule);

	//		foreach(var operation in operations)
	//		{
	//			ruleList.AddRange(WalkAndBuild(operation));
	//		}
	//	}

	//	return ruleList;
	//}

	/// <summary>
	///
	/// </summary>
	/// <param name="operation"></param>
	//internal IList<IValidate> WalkAndBuild(KeyValuePair<OperationType, OpenApiOperation> operation)
	//{
	//	var ruleList = new List<IValidate>();

	//	if(operation.Value != null)
	//	{
	//		var rule = _visitor.Build(operation);
	//		ruleList.Add(rule);

	//		rule.AddRule(WalkAndBuild(operation.Value.Parameters));
	//		rule.AddRule(WalkAndBuild(operation.Value.RequestBody));
	//		//rule.AddChildRule(WalkAndBuild(operation.Value.Responses));

	//		//WalkAndBuild(OpenApiConstants.Callbacks, () => WalkAndBuild(operation.Callbacks));
	//		//WalkAndBuild(OpenApiConstants.Tags, () => WalkAndBuild(operation.Tags));
	//		//WalkAndBuild(OpenApiConstants.Security, () => WalkAndBuild(operation.Security));
	//		//WalkAndBuild(operation as IOpenApiExtensible);
	//	}
	//	return ruleList;
	//}

	//	return ruleList;
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidationRule> WalkAndBuild(OpenApiPaths paths)
	//{
	//	List<IValidationRule> ruleList = new List<IValidationRule>();
	//	if(paths.IsNotNullOrEmpty())
	//	{
	//		foreach(var pathItem in paths)
	//		{
	//			rule.AddChildRule(WalkAndBuild(pathItem));
	//			//ruleList.AddRange();// JSON Pointer uses ~1 as an escape character for /
	//		}
	//	}

	//	return ruleList;
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidationRule> WalkAndBuild(IDictionary<string, OpenApiServerVariable> serverVariables)
	//{
	//	IList<IValidationRule> ruleList = new List<IValidationRule>();
	//	if(serverVariables != null)
	//	{
	//		var rule = _visitor.Build(serverVariables).FirstOrDefault();
	//		foreach(var variable in serverVariables)
	//		{
	//			rule.AddChildRule(WalkAndBuild(variable.Value));// JSON Pointer uses ~1 as an escape character for /
	//		}
	//	}
	//	return ruleList;
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(IList<OpenApiTag> tags)
	//{
	//	if(tags.IsNull())
	//	{
	//		return;
	//	}
	//	_visitor.Build(tags);
	//	// Visit tags
	//	if(tags!=null)
	//	{
	//		for(int i = 0; i<tags.Count; i++)
	//		{
	//			WalkAndBuild(i.ToString(), () => WalkAndBuild(tags[i]));
	//		}
	//	}
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(OpenApiExternalDocs externalDocs)
	//{
	//	if(externalDocs.IsNull())
	//	{
	//		return;
	//	}

	//	_visitor.Build(externalDocs);
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(OpenApiComponents components)
	//{
	//	if(components.IsNull())
	//	{
	//		return;
	//	}

	//	_visitor.Build(components);

	//	if(components.IsNull())
	//	{
	//		return;
	//	}

	//	WalkAndBuild(OpenApiConstants.Schemas, () =>
	//	{
	//		if(components.Schemas!=null)
	//		{
	//			foreach(var item in components.Schemas)
	//			{
	//				WalkAndBuild(item.Key, () => WalkAndBuild(item.Value, isComponent: true));
	//			}
	//		}
	//	});

	//	WalkAndBuild(OpenApiConstants.Callbacks, () =>
	//	{
	//		if(components.Callbacks!=null)
	//		if(components.Callbacks!=null)
	//		{
	//			foreach(var item in components.Callbacks)
	//			{
	//				WalkAndBuild(item.Key, () => WalkAndBuild(item.Value, isComponent: true));
	//			}
	//		}
	//	});

	//	WalkAndBuild(OpenApiConstants.Parameters, () =>
	//	{
	//		if(components.Parameters!=null)
	//		{
	//			foreach(var item in components.Parameters)
	//			{
	//				WalkAndBuild(item.Key, () => WalkAndBuild(item.Value, isComponent: true));
	//			}
	//		}
	//	});

	//	WalkAndBuild(OpenApiConstants.Examples, () =>
	//	{
	//		if(components.Examples!=null)
	//		{
	//			foreach(var item in components.Examples)
	//			{
	//				WalkAndBuild(item.Key, () => WalkAndBuild(item.Value, isComponent: true));
	//			}
	//		}
	//	});

	//	WalkAndBuild(OpenApiConstants.Headers, () =>
	//	{
	//		if(components.Headers!=null)
	//		{
	//			foreach(var item in components.Headers)
	//			{
	//				WalkAndBuild(item.Key, () => WalkAndBuild(item.Value, isComponent: true));
	//			}
	//		}
	//	});

	//	WalkAndBuild(OpenApiConstants.Links, () =>
	//	{
	//		if(components.Links!=null)
	//		{
	//			foreach(var item in components.Links)
	//			{
	//				WalkAndBuild(item.Key, () => WalkAndBuild(item.Value, isComponent: true));
	//			}
	//		}
	//	});

	//	WalkAndBuild(OpenApiConstants.RequestBodies, () =>
	//	{
	//		if(components.RequestBodies!=null)
	//		{
	//			foreach(var item in components.RequestBodies)
	//			{
	//				WalkAndBuild(item.Key, () => WalkAndBuild(item.Value, isComponent: true));
	//			}
	//		}
	//	});

	//	WalkAndBuild(OpenApiConstants.Responses, () =>
	//	{
	//		if(components.Responses!=null)
	//		{
	//			foreach(var item in components.Responses)
	//			{
	//				WalkAndBuild(item.Key, () => WalkAndBuild(item.Value, isComponent: true));
	//			}
	//		}
	//	});
	//	WalkAndBuild(components as IOpenApiExtensible);
	//}

	///// <summary>
	/////
	///// </summary>
	//internal IList<IValidator> WalkAndBuild(IList<OpenApiServer> servers)
	//{
	//	if(servers.IsNull())
	//	{
	//		return;
	//	}

	//	_visitor.Build(servers);

	//	// Visit Servers
	//	if(servers!=null)
	//	{
	//		for(int i = 0; i<servers.Count; i++)
	//		{
	//			WalkAndBuild(i.ToString(), () => WalkAndBuild(servers[i]));
	//		}
	//	}
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(OpenApiInfo info)
	//{
	//	if(info.IsNull())
	//	{
	//		return;
	//	}

	//	_visitor.Build(info);
	//	if(info!=null)
	//	{
	//		WalkAndBuild(OpenApiConstants.Contact, () => WalkAndBuild(info.Contact));
	//		WalkAndBuild(OpenApiConstants.License, () => WalkAndBuild(info.License));
	//	}
	//	WalkAndBuild(info as IOpenApiExtensible);
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(IOpenApiExtensible openApiExtensible)
	//{
	//	IList<IValidator> ruleList = new List<IValidator>();
	//	if(openApiExtensible != null)
	//	{
	//		var rule = _visitor.Build(openApiExtensible).FirstOrDefault();
	//		foreach(var extension in openApiExtensible.Extensions)
	//		{
	//			rule.AddChildRule(WalkAndBuild(extension.Value));// JSON Pointer uses ~1 as an escape character for /
	//		}
	//	}
	//	return ruleList;
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(IOpenApiExtension extension)
	//{
	//	return extension.IsNull() ? new List<IValidator>() : _visitor.Build(extension);
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(OpenApiLicense license)
	//{
	//	if(license.IsNull())
	//	{
	//		return;
	//	}

	//	_visitor.Build(license);
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(OpenApiCallback callback)
	//{
	//	if(callback.IsNull()||ProcessAsReference(callback, isComponent))
	//	{
	//		return;
	//	}

	//	_visitor.Build(callback);

	//	if(callback!=null)
	//	{
	//		foreach(var item in callback.PathItems)
	//		{
	//			_visitor.CurrentKeys.Callback=item.Key.ToString();
	//			var pathItem = item.Value;
	//			WalkAndBuild(item.Key.ToString(), () => WalkAndBuild(pathItem));
	//			_visitor.CurrentKeys.Callback=null;
	//		}
	//	}
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(OpenApiTag tag)
	//{
	//	if(tag.IsNull()||ProcessAsReference(tag))
	//	{
	//		return;
	//	}

	//	_visitor.Build(tag);
	//	_visitor.Build(tag.ExternalDocs);
	//	_visitor.Build(tag as IOpenApiExtensible);
	//}

	///// <summary>
	/////
	///// </summary>
	//internal IList<IValidator> WalkAndBuild(OpenApiServer server)
	//{
	//	if(server.IsNull())
	//	{
	//		return;
	//	}

	//	_visitor.Build(server);
	//	WalkAndBuild(OpenApiConstants.Variables, () => WalkAndBuild(server.Variables));
	//	_visitor.Build(server as IOpenApiExtensible);
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(IList<OpenApiSecurityRequirement> securityRequirements)
	//{
	//	if(securityRequirements.IsNull())
	//	{
	//		return;
	//	}

	//	_visitor.Build(securityRequirements);

	//	if(securityRequirements!=null)
	//	{
	//		for(int i = 0; i<securityRequirements.Count; i++)
	//		{
	//			WalkAndBuild(i.ToString(), () => WalkAndBuild(securityRequirements[i]));
	//		}
	//	}
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(IDictionary<string, OpenApiCallback> callbacks)
	//{
	//	if(callbacks.IsNull())
	//	{
	//		return;
	//	}

	//	_visitor.Build(callbacks);
	//	if(callbacks!=null)
	//	{
	//		foreach(var callback in callbacks)
	//		{
	//			_visitor.CurrentKeys.Callback=callback.Key;
	//			WalkAndBuild(callback.Key, () => WalkAndBuild(callback.Value));
	//			_visitor.CurrentKeys.Callback=null;
	//		}
	//	}
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(IDictionary<string, OpenApiExample> examples)
	//{
	//	if(examples.IsNull())
	//	{
	//		return;
	//	}

	//	_visitor.Build(examples);

	//	if(examples!=null)
	//	{
	//		foreach(var example in examples)
	//		{
	//			_visitor.CurrentKeys.Example=example.Key;
	//			WalkAndBuild(example.Key, () => WalkAndBuild(example.Value));
	//			_visitor.CurrentKeys.Example=null;
	//		}
	//	}
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(IOpenApiAny example)
	//{
	//	if(example.IsNull())
	//	{
	//		return;
	//	}

	//	_visitor.Build(example);
	//}

	///// <summary>
	/////
	///// </summary>
	//internal IList<IValidator> WalkAndBuild(OpenApiExample example)
	//{
	//	if(example.IsNull()||ProcessAsReference(example, isComponent))
	//	{
	//		return;
	//	}

	//	_visitor.Build(example);
	//	WalkAndBuild(example as IOpenApiExtensible);
	//}

	///// <summary>
	/////
	///// </summary>
	//internal IList<IValidator> WalkAndBuild(IList<OpenApiExample> examples)
	//{
	//	if(examples.IsNull())
	//	{
	//		return;
	//	}

	//	_visitor.Build(examples);

	//	// Visit Examples
	//	if(examples!=null)
	//	{
	//		for(int i = 0; i<examples.Count; i++)
	//		{
	//			WalkAndBuild(i.ToString(), () => WalkAndBuild(examples[i]));
	//		}
	//	}
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(OpenApiOAuthFlows flows)
	//{
	//	if(flows.IsNull())
	//	{
	//		return;
	//	}
	//	_visitor.Build(flows);
	//	WalkAndBuild(flows as IOpenApiExtensible);
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(OpenApiOAuthFlow oAuthFlow)
	//{
	//	if(oAuthFlow.IsNull())
	//	{
	//		return;
	//	}

	//	_visitor.Build(oAuthFlow);
	//	WalkAndBuild(oAuthFlow as IOpenApiExtensible);
	//}

	///// <summary>
	/////
	///// </summary>
	//internal IList<IValidator> WalkAndBuild(IDictionary<string, OpenApiLink> links)
	//{
	//	if(links.IsNull())
	//	{
	//		return;
	//	}

	//	_visitor.Build(links);

	//	if(links!=null)
	//	{
	//		foreach(var item in links)
	//		{
	//			_visitor.CurrentKeys.Link=item.Key;
	//			WalkAndBuild(item.Key, () => WalkAndBuild(item.Value));
	//			_visitor.CurrentKeys.Link=null;
	//		}
	//	}
	//}

	///// <summary>
	/////
	///// </summary>
	//internal IList<IValidator> WalkAndBuild(OpenApiLink link)
	//{
	//	if(link.IsNull()||ProcessAsReference(link, isComponent))
	//	{
	//		return;
	//	}

	//	_visitor.Build(link);
	//	WalkAndBuild(OpenApiConstants.Server, () => WalkAndBuild(link.Server));
	//	WalkAndBuild(link as IOpenApiExtensible);
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(OpenApiSecurityRequirement securityRequirement)
	//{
	//	if(securityRequirement.IsNull())
	//	{
	//		return;
	//	}

	//	_visitor.Build(securityRequirement);
	//	WalkAndBuild(securityRequirement as IOpenApiExtensible);
	//}

	///// <summary>
	/////
	///// </summary>
	//internal IList<IValidator> WalkAndBuild(OpenApiSecurityScheme securityScheme)
	//{
	//	if(securityScheme.IsNull()||ProcessAsReference(securityScheme))
	//	{
	//		return;
	//	}

	//	_visitor.Build(securityScheme);
	//	WalkAndBuild(securityScheme as IOpenApiExtensible);
	//}

	/// <summary>
	///
	/// </summary>
	//internal IList<IValidator> WalkAndBuild(IOpenApiReferenceable referenceable)
	//{
	//	_visitor.Build(referenceable);
	//}

	/// <summary>
	/// Adds a segment to the context path to enable pointing to the current location in the document
	/// </summary>
	/// <param name="context">An identifier for the context.</param>
	/// <param name="walk">An action that walks objects within the context.</param>
	//private void WalkAndBuild(string context, Action WalkAndBuildAction)
	//{
	//	WalkAndBuildAction();
	//}

	/// <summary>
	/// Object containing contextual information based on where the walker is currently referencing in an OpenApiDocument
	/// </summary>
	//internal class CurrentKeys
	//{
	//	/// <summary>
	//	/// Current Path key
	//	/// </summary>
	//	internal string Path { get; set; }

	//	/// <summary>
	//	/// Current Operation Type
	//	/// </summary>
	//	internal OperationType? Operation { get; set; }

	//	/// <summary>
	//	/// Current Response Status Code
	//	/// </summary>
	//	internal string Response { get; set; }

	//	/// <summary>
	//	/// Current Content Media Type
	//	/// </summary>
	//	internal string Content { get; set; }

	//	/// <summary>
	//	/// Current Callback Key
	//	/// </summary>
	//	internal string Callback { get; set; }

	//	/// <summary>
	//	/// Current Link Key
	//	/// </summary>
	//	//internal string Link { get; set; }

	//	/// <summary>
	//	/// Current Header Key
	//	/// </summary>
	//	internal string Header { get; set; }

	//	/// <summary>
	//	/// Current Encoding Key
	//	/// </summary>
	//	internal string Encoding { get; set; }

	//	/// <summary>
	//	/// Current Example Key
	//	/// </summary>
	//	//internal string Example { get; internal set; }

	//	/// <summary>
	//	/// Current Extension Key
	//	/// </summary>
	//	internal string Extension { get; set; }

	//	/// <summary>
	//	/// Current ServerVariable
	//	/// </summary>
	//	internal string ServerVariable { get; set; }
	//}
	#endregion
}
