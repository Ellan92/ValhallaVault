namespace ValhallaVault.EmeliesMiddleware
{
    public class Middleware
    {
        // Middleware som loggar IP-adressen från varje inkommen request. 
        private readonly RequestDelegate _next;
        private readonly ILogger<Middleware> _logger;

        public Middleware(RequestDelegate next, ILogger<Middleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            var ipAddress = context.Connection.RemoteIpAddress?.ToString();
            _logger.LogInformation($"HTTP-Request från IP-adress: {ipAddress}");

            await _next(context);
        }
    }
}
