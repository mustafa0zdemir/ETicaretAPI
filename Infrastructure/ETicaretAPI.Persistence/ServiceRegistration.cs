using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretDbContext>(options =>
                options.UseNpgsql("Host=localhost;Port=5432;Database=ETicaretAPIDb;Username=admin;Password=123456;Pooling=true;"));
        }
    }
}