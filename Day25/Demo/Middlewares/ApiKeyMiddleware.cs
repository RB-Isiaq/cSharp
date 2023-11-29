

using System.Net;
using Demo.Constants;
using Demo.Interfaces;
namespace Demo.Middlewares
{
    public class ApiKeyMiddleware : IMiddleware
    {
        private readonly IApiKeyValidationService _apiKeyValidationService;
        public ApiKeyMiddleware(IApiKeyValidationService apiKeyValidationService)
        {
            _apiKeyValidationService = apiKeyValidationService;
        }


        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var headerKey = context.Request.Headers[AppConstants.ApiKeyHeaderName].ToString();
            if (!_apiKeyValidationService.IsValidApiKey(headerKey))
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                var message = new { message = "Api Key Invalid or not present" };
                context.Response.WriteAsJsonAsync(message);
                return Task.CompletedTask;
            }

            next(context);
            return Task.CompletedTask;
        }
    }
}