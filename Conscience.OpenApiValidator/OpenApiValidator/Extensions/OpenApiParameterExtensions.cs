using System.Collections.Generic;
using System.Linq;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;

namespace Conscience.OpenApiValidator
{
	public static class OpenApiIsRequiredExtension
	{
		public static bool IsRequired(this OpenApiParameter @this)
		{
			if (@this.Extensions != null && @this.Extensions.ContainsKey("x-required"))
				return @this.Extensions.ContainsKey("x-required");
				//return (bool)@this.Extensions.First(e => e.Key == "x-required").Value.ToString();

			return @this.Required;
		}

		internal static string GetFieldNameForRules(this object @this)
		{
			if (@this == null || @this is string)
				return null;

			var elementType = @this.GetType();
			if (elementType.GetProperty("Name") != null)
				return elementType.GetProperty("Name")?.GetValue(@this, null)?.ToString();
			else
			if (elementType.GetProperty("Title") != null)
				return elementType.GetProperty("Title")?.GetValue(@this, null)?.ToString();

			if (@this is IOpenApiExtensible)
			{
				var fieldName = (@this as IOpenApiExtensible).Extensions.Where(e => e.Key.Equals("x-title") || e.Key.Equals("x-name")).FirstOrDefault();
				return fieldName.Equals(default(KeyValuePair<string, IOpenApiExtension>)) ? null : fieldName.Value?.ToString();
			}
			return null;
		}
		
	}
}
