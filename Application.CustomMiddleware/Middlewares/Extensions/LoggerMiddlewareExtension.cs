using Microsoft.AspNetCore.Builder;

namespace Application.CustomMiddleware.Middlewares.Extensions
{
    public static class LoggerMiddlewareExtension
    {
        public static IApplicationBuilder UseLogger(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<LoggerMiddleware>();
        }
    }
}