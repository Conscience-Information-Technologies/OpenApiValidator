using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Conscience.OpenApiValidator;
using Newtonsoft.Json;

namespace OpenApiValidatorWebRequest.Middleware
{
	public class OpenApiValidatorMiddleware
	{
		private readonly RequestDelegate _next;

		public OpenApiValidatorMiddleware(RequestDelegate next)
		{
			_next=next;
		}

		public async Task Invoke(HttpContext httpContext, OpenApiHttpRequestValidator _httpRequestValidator)
		{
			if(_httpRequestValidator.UrlPath==null)
				await _next(httpContext);
			else
			{
				var logs = _httpRequestValidator.Validate(httpContext);

				if(logs.Count==0)
					await _next(httpContext);
				else
				{
					httpContext.Response.ContentType="application/json";
					var response = new ApiResponse(httpContext.Response.StatusCode, logs);
					var json = JsonConvert.SerializeObject(response);
					await httpContext.Response.WriteAsync(json);
				}
			}

		}
	}

	public class ApiResponse
	{
		public int StatusCode { get; }

		public RuleLogs Logs { get; }

		public ApiResponse(int statusCode, RuleLogs logs)
		{
			StatusCode=statusCode;
			Logs=logs;
		}
	}
}
