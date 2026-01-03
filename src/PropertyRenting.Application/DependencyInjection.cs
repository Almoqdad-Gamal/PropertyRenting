using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using PropertyRenting.Application.Common;

namespace PropertyRenting.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => 
                cfg.RegisterServicesFromAssembly(typeof(ApplicationAssemblyMarker).Assembly));

            services.AddValidatorsFromAssemblyContaining<ApplicationAssemblyMarker>();

            return services;
        }
    }
}