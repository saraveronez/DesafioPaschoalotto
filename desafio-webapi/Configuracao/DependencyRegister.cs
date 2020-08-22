using desafio_core;
using desafio_core.Business;
using desafio_core.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_webapi.Configuracoes
{
    public static class DependencyRegister
    {
        public static void Register(IServiceCollection services)
        {
            // Context
            services.AddScoped<ApplicationDbContext, ApplicationDbContext>();
          
            // Contracts
            services.AddScoped<IClienteBusiness, ClienteBusiness>();

            // PowerStock
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IActionContextAccessor, ActionContextAccessor>();
        }
    }
}
