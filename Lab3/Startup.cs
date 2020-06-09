using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Lab3.Context;
using Microsoft.EntityFrameworkCore;
using System;
using Lab3.Services;
using Lab3.DataAccess;
using Lab3.Services.Models;

namespace Lab3_web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApiContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:CoffeeMachineDB"]));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IService<Drink>, DrinkService>();
            services.AddScoped<IService<Ingredient>, IngredientService>();
            services.AddScoped<IService<Order>, OrderService>();
            services.AddScoped<IService<MachineConfig>, MachineConfigService>();
            services.AddMvc(o => o.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApiContext>();
            app.UseMvc();
        }
    }
}
