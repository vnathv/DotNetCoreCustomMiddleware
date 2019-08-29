using Application.CustomMiddleware.Abstractions;
using System;

namespace Application.CustomMiddleware.Configurations
{
    public class ClientConfiguration : IClientConfiguration
    {
        public string ClientName { get; set; }

        public DateTime InvokedDateTime { get; set; }
    }
}