using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vs.Services
{
  public static  class SharedServicesExtension
    {
        public static IServiceCollection AddSharedServices(this IServiceCollection services, IHostingEnvironment env, IConfigurationRoot config)
        {
            
            if (env.IsDevelopment())
            {
                
            }
            else
            {
               
            }
            return services;
        }
    }
}
