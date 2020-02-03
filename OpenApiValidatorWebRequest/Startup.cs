using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conscience.OpenApiValidator;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenApiValidatorWebRequest.Middleware;

namespace OpenApiValidatorWebRequest
{
	public class Startup
	{
		public Startup(IConfiguration configuration, IHostingEnvironment environment)
		{
			this._configuration=configuration;
			this._environment=environment;
		}

		private IConfiguration _configuration;

		private IHostingEnvironment _environment;

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			var openApiDoc = OpenApiDocumentReaderHelper.GetOpenApiDocument(_environment.WebRootPath);

			var ruleEngineBuilder = new OpenApiValidatorBuilder(new ValidatorContext());
			var ruleEngineRequestValidators = new SortedDictionary<string, OpenApiHttpRequestValidator>();

			ruleEngineBuilder.Build(openApiDoc).Cast<OpenApiHttpRequestValidator>().ToList().ForEach(e => ruleEngineRequestValidators.Add(e.Key, e));
			var dummyValidator = new OpenApiHttpRequestValidator();

			services.AddTransient<OpenApiHttpRequestValidator, OpenApiHttpRequestValidator>((provider) =>
			{
				var request = provider.GetRequiredService<IHttpContextAccessor>().HttpContext.Request;
				var requestValidator = ruleEngineRequestValidators.FirstOrDefault(e => e.Key.ToLower()==$"{request.Path}{request.Method}".ToLower().Replace("/", ""));// request.Method);

				if(requestValidator.Key!=null)
					return (OpenApiHttpRequestValidator)requestValidator.Value.Clone();

				return dummyValidator;
			});

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			app.UseMiddleware<OpenApiValidatorMiddleware>();

			app.UseMvc();
		}
	}
}
