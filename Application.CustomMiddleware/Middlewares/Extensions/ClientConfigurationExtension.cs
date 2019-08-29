using Microsoft.AspNetCore.Builder;

namespace Application.CustomMiddleware.Middlewares.Extensions
{
    public static class ClientConfigurationExtension
    {
        public static IApplicationBuilder UseClientConfiguration(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<ClientConfigurationMiddleware>();
        }
    }
}