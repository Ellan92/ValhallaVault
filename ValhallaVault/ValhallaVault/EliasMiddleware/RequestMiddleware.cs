using System.Diagnostics;
using ValhallaVault.EmeliesMiddleware;

namespace ValhallaVault.EliasMiddleware
{
    public class RequestMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestMiddleware> _logger;

        public RequestMiddleware(RequestDelegate next, ILogger<RequestMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();

            _logger.LogInformation($"Request: {context.Request.Method} {context.Request.Path}");

            await _next(context);

            _logger.LogInformation($"Response: {context.Response.StatusCode} ({stopwatch.ElapsedMilliseconds} ms)");
        }
    }
}
