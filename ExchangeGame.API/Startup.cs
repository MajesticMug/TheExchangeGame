using System;
using ExchangeGame.Domain.Repositories.Players;
using ExchangeGame.Domain.Services.Implementations;
using ExchangeGame.Domain.Services.Interfaces;
using ExchangeGame.Infrastructure;
using ExchangeGame.Infrastructure.Repositories.Players;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExchangeGame.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            RegisterServices(services);
            SetupDb(services);
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IPlayerRepository, PlayerRepository>();

            services.AddScoped<IPlayerService, PlayerService>();
        }

        private static void SetupDb(IServiceCollection services)
        {
            services.AddDbContext<ExchangeGameDbContext>(options => 
                options.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ExchangeGameDb;Integrated Security=True;"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<ExchangeGameDbContext>();
                context.Database.EnsureCreated();
            }
        }
    }
}
