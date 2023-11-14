

namespace Demo.Middlewares
{
    public class FactoryMiddleware2 : IMiddleware
    {
        private readonly ILogger<FactoryMiddleware2> _logger;

        public FactoryMiddleware2(ILogger<FactoryMiddleware2> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            _logger.LogInformation("Before Request - Middleware2");
            Console.WriteLine("Before Request - Middleware2");
            await next(context);
            _logger.LogInformation("After Request - Middleware2");
            Console.WriteLine("After Request - Middleware2");
        }
    }
}