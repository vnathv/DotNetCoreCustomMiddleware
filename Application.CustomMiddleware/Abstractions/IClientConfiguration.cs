using System;

namespace Application.CustomMiddleware.Abstractions
{
    public interface IClientConfiguration
    {
        string ClientName { get; set; }

        DateTime InvokedDateTime { get; set; }
    }
}