using DynamicApiBuilder.Application.BusinessRules.Implementation;
using DynamicApiBuilder.Application.BusinessRules.Interface;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly: FunctionsStartup(typeof(DynamicApiBuilder.Function.Startup))]
namespace DynamicApiBuilder.Function
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
        }
    }
}
