using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

//https://medium.com/@dushyanthak/best-practices-for-writing-custom-middlewares-in-asp-net-core-97b58c50cf9c

namespace ValhallaVault.FarresMiddleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class FarresMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<FarresMiddleware> _logger;
        public FarresMiddleware(RequestDelegate next, ILogger<FarresMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation($"Tar emot en HTTP-förfrågan: {httpContext.Request.Path}");
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class FarresMiddlewareExtensions
    {
        public static IApplicationBuilder UseFarresMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<FarresMiddleware>();
        }
    }
}
