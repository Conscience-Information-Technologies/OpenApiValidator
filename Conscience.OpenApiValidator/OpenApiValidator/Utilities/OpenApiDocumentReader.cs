using Manatee.Json.Schema;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using System;
using System.IO;
using System.Net.Http;

namespace Conscience.OpenApiValidator
{
	public class OpenApiDocumentReaderHelper
	{
		public OpenApiDocumentReaderHelper()
		{
		}

		public static OpenApiDocument GetOpenApiDocument(string webRootPath)
		{
			var directorySeparatorChar = Path.DirectorySeparatorChar.ToString();
			var defaultOpenAPiFilesLocation = webRootPath + directorySeparatorChar;
			var openApiFileLocation = defaultOpenAPiFilesLocation + "OpenAPI" + directorySeparatorChar + "1.0.3.yaml";
			var jsonSchemaFileLocation = defaultOpenAPiFilesLocation + "Schema";

			var textFromOpenApiSchemaFile = File.ReadAllText(openApiFileLocation);

			var openApiDoc = new OpenApiStringReader().Read(textFromOpenApiSchemaFile, out var _);

			ManateeRegisterJsonSchema(jsonSchemaFileLocation);
				    
			return openApiDoc;
		}

		public static OpenApiDocument ManateeRegisterJsonSchema(string _specLocation)
		{
			var exFiles = "";
			foreach (var file in Directory.GetFiles(_specLocation))
			{
				//var textFromOpenApiSchemaFile = File.ReadAllText(file);
				try
				{
					JsonSchemaRegistry.Register(JsonSchemaRegistry.Get(file));
				}
				catch (Exception ex)
				{
					exFiles += file + "\n\n";
					exFiles += ex.ToString() + "\n\n";
				}
			}

			return null;
		}

		//private static HttpMethod OperationToHttpMethod(OperationType operation)
		//{
		//	switch(operation)
		//	{
		//		case OperationType.Get:
		//		return HttpMethod.Get;

		//		case OperationType.Put:
		//		return HttpMethod.Put;

		//		case OperationType.Post:
		//		return HttpMethod.Post;

		//		case OperationType.Patch:
		//		return new HttpMethod("PATCH");

		//		case OperationType.Delete:
		//		return HttpMethod.Delete;

		//		case OperationType.Options:
		//		return HttpMethod.Options;

		//		case OperationType.Head:
		//		return HttpMethod.Head;

		//		case OperationType.Trace:
		//		return HttpMethod.Trace;
		//	}

		//	throw new ArgumentException($"I can't translate this kind of OpenAPI operation: {operation}");
		//}
	}
}
