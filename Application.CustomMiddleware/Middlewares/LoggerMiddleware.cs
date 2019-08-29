using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Threading.Tasks;

namespace Application.CustomMiddleware.Middlewares
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public LoggerMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<LoggerMiddleware>();
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            //Read body from the request and log it
            using (var reader = new StreamReader(httpContext.Request.Body))
            {
                var requestBody = reader.ReadToEnd();
                //As this is a middleware below line will make sure it will log each and every request body
                _logger.LogInformation(requestBody);
            }

            //Move to next delegate/middleware in the pipleline
            await _next.Invoke(httpContext);
        }
    }
}