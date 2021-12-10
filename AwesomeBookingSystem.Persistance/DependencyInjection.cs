using AwesomeBookingSystem.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeBookingSystem.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AwesomeDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("AwesomeDatabase")));

            services.AddScoped<IAwesomeDbContext, AwesomeDbContext>();

            return services;
        }
    }
}
