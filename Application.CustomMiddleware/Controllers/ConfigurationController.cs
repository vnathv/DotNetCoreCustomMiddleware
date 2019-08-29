using Application.CustomMiddleware.Abstractions;
using Application.CustomMiddleware.Configurations;
using Microsoft.AspNetCore.Mvc;

namespace Application.CustomMiddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : Controller
    {
        private readonly IClientConfiguration clientConfiguration;

        public ConfigurationController(IClientConfiguration clientConfiguration)
        {
            this.clientConfiguration = clientConfiguration;
        }

        [HttpGet]
        public ActionResult<ClientConfiguration> GetConfigurationController()
        {
            return new ClientConfiguration
            {
                ClientName = clientConfiguration.ClientName,
                InvokedDateTime = clientConfiguration.InvokedDateTime
            };
        }
    }
}