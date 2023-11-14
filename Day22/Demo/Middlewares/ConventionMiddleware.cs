
namespace Demo.Middlewares
{
    public class ConventionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ConventionMiddleware> _logger;

        public ConventionMiddleware(
            RequestDelegate next,
            ILogger<ConventionMiddleware> logger
        )
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation("Before Request");

            await _next(context);

            _logger.LogInformation("After Request");
        }

    }
}