

namespace Demo.Middlewares
{
    public class FactoryMiddleware1 : IMiddleware
    {
        private readonly ILogger<FactoryMiddleware1> _logger;

        public FactoryMiddleware1(ILogger<FactoryMiddleware1> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            _logger.LogInformation("Before Request - Middleware1");
            Console.WriteLine("Before Request - Middleware1");
            await next(context);
            _logger.LogInformation("After Request - Middleware1");
            Console.WriteLine("After Request - Middleware1");
        }
    }
}